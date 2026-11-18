using System;
using System.Windows.Forms;
using Unity;
using LibraryAccounting.Repositories;

namespace LibraryAccounting.Forms
{
    public partial class FormLibrarians : Form
    {
        private readonly IUnityContainer _container;
        private readonly ILibrarianRepository _librarianRepository;

        public FormLibrarians(IUnityContainer container, ILibrarianRepository librarianRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _librarianRepository = librarianRepository ?? throw new ArgumentNullException(nameof(librarianRepository));
        }

        private void FormLibrarians_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            // Получаем данные из репозитория
            dataGridViewData.DataSource = _librarianRepository.ReadLibrarians();

            // Убираем пустую колонку слева
            dataGridViewData.RowHeadersVisible = false;

            // Растягиваем колонки на всю ширину
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Переводим заголовки на русский
            if (dataGridViewData.Columns["Id"] != null)
                dataGridViewData.Columns["Id"].HeaderText = "Код";

            if (dataGridViewData.Columns["FirstName"] != null)
                dataGridViewData.Columns["FirstName"].HeaderText = "Имя";

            if (dataGridViewData.Columns["LastName"] != null)
                dataGridViewData.Columns["LastName"].HeaderText = "Фамилия";

            if (dataGridViewData.Columns["AllowedThemes"] != null)
                dataGridViewData.Columns["AllowedThemes"].HeaderText = "Доступные темы";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormLibrarianEdit>().ShowDialog();
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
                var form = _container.Resolve<FormLibrarianEdit>();
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
                _librarianRepository.DeleteLibrarian(id);
                LoadList();
            }
        }
    }
}