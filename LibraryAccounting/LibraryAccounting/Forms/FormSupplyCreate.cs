using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryAccounting.Entities;
using LibraryAccounting.Repositories;

namespace LibraryAccounting.Forms
{
    public partial class FormSupplyCreate : Form
    {
        private readonly ISupplyRepository _supplyRepository;

        public FormSupplyCreate(ISupplyRepository supplyRepository,
                                ILibrarianRepository librarianRepository,
                                ILiteraryItemRepository itemRepository)
        {
            InitializeComponent();
            _supplyRepository = supplyRepository ?? throw new ArgumentNullException(nameof(supplyRepository));

            comboBoxLibrarian.DataSource = librarianRepository.ReadLibrarians();
            comboBoxLibrarian.DisplayMember = "LastName";
            comboBoxLibrarian.ValueMember = "Id";

            ColumnItem.DataSource = itemRepository.ReadItems();
            ColumnItem.DisplayMember = "Title";
            ColumnItem.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxLibrarian.SelectedIndex < 0)
            {
                MessageBox.Show("Имеются незаполненные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var librarianId = (int)comboBoxLibrarian.SelectedValue!;

                var supplyItems = new List<SupplyItem>();
                foreach (DataGridViewRow row in dataGridViewItems.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["ColumnItem"].Value != null && row.Cells["ColumnCount"].Value != null)
                    {
                        supplyItems.Add(SupplyItem.CreateElement(
                            0, 
                            Convert.ToInt32(row.Cells["ColumnItem"].Value),
                            Convert.ToInt32(row.Cells["ColumnCount"].Value)));
                    }
                }

                if (supplyItems.Count == 0)
                {
                    MessageBox.Show("Имеются незаполненные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var supply = Supply.CreateOperation(0, librarianId, supplyItems);

                _supplyRepository.CreateSupply(supply);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}