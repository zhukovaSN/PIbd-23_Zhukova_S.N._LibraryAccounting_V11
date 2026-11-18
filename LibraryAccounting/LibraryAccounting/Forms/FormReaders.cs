using System;
using System.Windows.Forms;
using Unity;
using LibraryAccounting.Repositories;
using LibraryAccounting.Forms; // Добавили для поиска других форм

namespace LibraryAccounting.Forms // Пространство имен должно быть ТАКИМ ЖЕ, как в дизайнере!
{
    public partial class FormReaders : Form
    {
        private readonly IUnityContainer _container;
        private readonly IReaderRepository _readerRepository;

        public FormReaders(IUnityContainer container, IReaderRepository readerRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _readerRepository = readerRepository ?? throw new ArgumentNullException(nameof(readerRepository));
        }

        private void FormReaders_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            dataGridViewData.RowHeadersVisible = false;
            // Получаем данные
            dataGridViewData.DataSource = _readerRepository.ReadReaders();
            
            // Если колонки существуют, меняем их заголовки на русские
            if (dataGridViewData.Columns["Id"] != null)
                dataGridViewData.Columns["Id"].HeaderText = "Код";

            if (dataGridViewData.Columns["FullName"] != null)
                dataGridViewData.Columns["FullName"].HeaderText = "ФИО";

            if (dataGridViewData.Columns["TicketNumber"] != null)
                dataGridViewData.Columns["TicketNumber"].HeaderText = "Номер билета";

            if (dataGridViewData.Columns["TicketValidUntil"] != null)
                dataGridViewData.Columns["TicketValidUntil"].HeaderText = "Действителен до";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormReaderEdit>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите запись для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
            try
            {
                var form = _container.Resolve<FormReaderEdit>();
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
                _readerRepository.DeleteReader(id);
                LoadList();
            }
        }
    }
}