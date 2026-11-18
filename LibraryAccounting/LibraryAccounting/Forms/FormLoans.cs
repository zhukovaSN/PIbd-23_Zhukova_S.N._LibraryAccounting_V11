using System;
using System.Windows.Forms;
using Unity;
using LibraryAccounting.Repositories;

namespace LibraryAccounting.Forms
{
    public partial class FormLoans : Form
    {
        private readonly IUnityContainer _container;
        private readonly ILoanRepository _loanRepository;

        public FormLoans(IUnityContainer container, ILoanRepository loanRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _loanRepository = loanRepository ?? throw new ArgumentNullException(nameof(loanRepository));
        }

        private void FormLoans_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            dataGridViewData.DataSource = _loanRepository.ReadLoans();

            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridViewData.Columns["ReturnDate"] != null)
                dataGridViewData.Columns["ReturnDate"].Visible = false;

            if (dataGridViewData.Columns["Id"] != null)
                dataGridViewData.Columns["Id"].HeaderText = "Код";
            if (dataGridViewData.Columns["ReaderId"] != null)
                dataGridViewData.Columns["ReaderId"].HeaderText = "Читатель";
            if (dataGridViewData.Columns["LibrarianId"] != null)
                dataGridViewData.Columns["LibrarianId"].HeaderText = "Библиотекарь";
            if (dataGridViewData.Columns["LiteraryItemId"] != null)
                dataGridViewData.Columns["LiteraryItemId"].HeaderText = "Издание";
            if (dataGridViewData.Columns["LoanDate"] != null)
                dataGridViewData.Columns["LoanDate"].HeaderText = "Дата выдачи";
            if (dataGridViewData.Columns["DueDate"] != null)
                dataGridViewData.Columns["DueDate"].HeaderText = "Дата возврата";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormLoanCreate>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}