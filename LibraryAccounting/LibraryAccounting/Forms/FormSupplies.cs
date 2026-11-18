using System;
using System.Windows.Forms;
using Unity;
using LibraryAccounting.Repositories;

namespace LibraryAccounting.Forms
{
    public partial class FormSupplies : Form
    {
        private readonly IUnityContainer _container;
        private readonly ISupplyRepository _supplyRepository;

        public FormSupplies(IUnityContainer container, ISupplyRepository supplyRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _supplyRepository = supplyRepository ?? throw new ArgumentNullException(nameof(supplyRepository));
        }

        private void FormSupplies_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            dataGridViewData.DataSource = _supplyRepository.ReadSupplies();

            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataGridViewData.Columns["SupplyItems"] != null)
                dataGridViewData.Columns["SupplyItems"].Visible = false;


            if (dataGridViewData.Columns["Id"] != null)
                dataGridViewData.Columns["Id"].HeaderText = "Код";
            if (dataGridViewData.Columns["LibrarianId"] != null)
                dataGridViewData.Columns["LibrarianId"].HeaderText = "Библиотекарь";
            if (dataGridViewData.Columns["SupplyDate"] != null)
                dataGridViewData.Columns["SupplyDate"].HeaderText = "Дата поставки";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormSupplyCreate>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count < 1) return;
            var id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);

            if (MessageBox.Show("Удалить поставку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _supplyRepository.DeleteSupply(id);
                LoadList();
            }
        }
    }
}