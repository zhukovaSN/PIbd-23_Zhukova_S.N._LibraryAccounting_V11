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

            // 1. Заполняем ComboBox библиотекарями
            comboBoxLibrarian.DataSource = librarianRepository.ReadLibrarians();
            comboBoxLibrarian.DisplayMember = "LastName";
            comboBoxLibrarian.ValueMember = "Id";

            // 2. Заполняем выпадающий список ВНУТРИ таблицы (колонку ColumnItem)
            ColumnItem.DataSource = itemRepository.ReadItems();
            ColumnItem.DisplayMember = "Title";
            ColumnItem.ValueMember = "Id";
        }

        // Дважды кликните по кнопке "Сохранить"
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

                // Собираем список книг из таблицы
                var supplyItems = new List<SupplyItem>();
                foreach (DataGridViewRow row in dataGridViewItems.Rows)
                {
                    // Пропускаем пустую последнюю строку (для добавления новых)
                    if (row.IsNewRow) continue;

                    if (row.Cells["ColumnItem"].Value != null && row.Cells["ColumnCount"].Value != null)
                    {
                        supplyItems.Add(SupplyItem.CreateElement(
                            0, // Id
                            Convert.ToInt32(row.Cells["ColumnItem"].Value),
                            Convert.ToInt32(row.Cells["ColumnCount"].Value)));
                    }
                }

                if (supplyItems.Count == 0)
                {
                    MessageBox.Show("Имеются незаполненные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Создаем поставку (дата ставится автоматически в методе CreateOperation)
                var supply = Supply.CreateOperation(0, librarianId, supplyItems);

                _supplyRepository.CreateSupply(supply);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Дважды кликните по кнопке "Отмена"
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}