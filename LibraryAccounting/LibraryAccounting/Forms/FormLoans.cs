using LibraryAccounting.Entities;
using LibraryAccounting.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace LibraryAccounting.Forms
{
    public partial class FormLoans : Form
    {
        private readonly IUnityContainer _container;
        private readonly ILoanRepository _loanRepository;
        private readonly IReaderRepository _readerRepository;
        private readonly ILibrarianRepository _librarianRepository;
        private readonly ILiteraryItemRepository _itemRepository;

        public FormLoans(IUnityContainer container, ILoanRepository loanRepository,
                         IReaderRepository readerRepository, ILibrarianRepository librarianRepository,
                         ILiteraryItemRepository itemRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _loanRepository = loanRepository ?? throw new ArgumentNullException(nameof(loanRepository));
            _readerRepository = readerRepository ?? throw new ArgumentNullException(nameof(readerRepository));
            _librarianRepository = librarianRepository ?? throw new ArgumentNullException(nameof(librarianRepository));
            _itemRepository = itemRepository ?? throw new ArgumentNullException(nameof(itemRepository));

            this.Load += FormLoans_Load!;
        }

        private void FormLoans_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            var readers = _readerRepository.ReadReaders().ToDictionary(r => r.Id, r => r.FullName);
            var librarians = _librarianRepository.ReadLibrarians().ToDictionary(l => l.Id, l => $"{l.LastName} {l.FirstName}");
            var items = _itemRepository.ReadItems().ToDictionary(i => i.Id, i => i.Title);
            var loans = _loanRepository.ReadLoans();

            var displayList = loans.Select(l => new
            {
                Код = l.Id,
                Читатель = readers.ContainsKey(l.ReaderId) ? readers[l.ReaderId] : "Неизвестен",
                Библиотекарь = librarians.ContainsKey(l.LibrarianId) ? librarians[l.LibrarianId] : "Неизвестен",
                Издание = items.ContainsKey(l.LiteraryItemId) ? items[l.LiteraryItemId] : "Неизвестно",
                Дата_выдачи = l.LoanDate.ToLocalTime(),
                Дата_возврата = l.DueDate.ToLocalTime()
            }).ToList();

            dataGridViewData.DataSource = displayList;
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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