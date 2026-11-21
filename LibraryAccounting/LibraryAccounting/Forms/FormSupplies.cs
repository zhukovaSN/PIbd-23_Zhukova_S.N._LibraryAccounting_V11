using LibraryAccounting.Entities;
using LibraryAccounting.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace LibraryAccounting.Forms
{
    public partial class FormSupplies : Form
    {
        private readonly IUnityContainer _container;
        private readonly ISupplyRepository _supplyRepository;
        private readonly ILibrarianRepository _librarianRepository;

        public FormSupplies(IUnityContainer container, ISupplyRepository supplyRepository, ILibrarianRepository librarianRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _supplyRepository = supplyRepository ?? throw new ArgumentNullException(nameof(supplyRepository));
            _librarianRepository = librarianRepository ?? throw new ArgumentNullException(nameof(librarianRepository));

            this.Load += FormSupplies_Load!;
        }

        private void FormSupplies_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            var librarians = _librarianRepository.ReadLibrarians().ToDictionary(l => l.Id, l => $"{l.LastName} {l.FirstName}");

            var supplies = _supplyRepository.ReadSupplies();

            var displayList = supplies.Select(s => new
            {
                Код = s.Id,
                Библиотекарь = librarians.ContainsKey(s.LibrarianId) ? librarians[s.LibrarianId] : "Неизвестен",
                Дата_поставки = s.SupplyDate.ToLocalTime()
            }).ToList();

            dataGridViewData.DataSource = displayList;
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            var id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Код"].Value);

            if (MessageBox.Show("Удалить поставку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _supplyRepository.DeleteSupply(id);
                LoadList();
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите поставку для просмотра!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Код"].Value);
            var supply = _supplyRepository.ReadSupplies().FirstOrDefault(s => s.Id == id);

            try
            {
                var form = _container.Resolve<FormSupplyCreate>();
                form.SetupForView(supply!);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}