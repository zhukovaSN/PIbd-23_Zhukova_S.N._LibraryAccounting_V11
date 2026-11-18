using System;
using System.Windows.Forms;
using Unity;
using LibraryAccounting.Repositories;

namespace LibraryAccounting.Forms
{
    public partial class FormLiteraryItems : Form
    {
        private readonly IUnityContainer _container;
        private readonly ILiteraryItemRepository _itemRepository;

        public FormLiteraryItems(IUnityContainer container, ILiteraryItemRepository itemRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _itemRepository = itemRepository ?? throw new ArgumentNullException(nameof(itemRepository));
        }

        private void FormLiteraryItems_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            dataGridViewData.DataSource = _itemRepository.ReadItems();

            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Русские заголовки
            if (dataGridViewData.Columns["Id"] != null)
                dataGridViewData.Columns["Id"].HeaderText = "Код";
            if (dataGridViewData.Columns["Title"] != null)
                dataGridViewData.Columns["Title"].HeaderText = "Название";
            if (dataGridViewData.Columns["Theme"] != null)
                dataGridViewData.Columns["Theme"].HeaderText = "Тематика";
            if (dataGridViewData.Columns["Type"] != null)
                dataGridViewData.Columns["Type"].HeaderText = "Тип";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormLiteraryItemEdit>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count < 1) return;
            var id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);

            try
            {
                var form = _container.Resolve<FormLiteraryItemEdit>();
                form.Id = id;
                form.ShowDialog();
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

            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _itemRepository.DeleteItem(id);
                LoadList();
            }
        }
    }
}