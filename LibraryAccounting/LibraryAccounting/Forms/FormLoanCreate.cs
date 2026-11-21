using System;
using System.Windows.Forms;
using LibraryAccounting.Entities;
using LibraryAccounting.Repositories;

namespace LibraryAccounting.Forms
{
    public partial class FormLoanCreate : Form
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IReaderRepository _readerRepository;
        private readonly ILibrarianRepository _librarianRepository;
        private readonly ILiteraryItemRepository _itemRepository;

        public FormLoanCreate(ILoanRepository loanRepository,
                              IReaderRepository readerRepository,
                              ILibrarianRepository librarianRepository,
                              ILiteraryItemRepository itemRepository)
        {
            InitializeComponent();
            _loanRepository = loanRepository;
            _readerRepository = readerRepository;
            _librarianRepository = librarianRepository;
            _itemRepository = itemRepository;

            comboBoxReader.DataSource = _readerRepository.ReadReaders();
            comboBoxReader.DisplayMember = "FullName";
            comboBoxReader.ValueMember = "Id";

            comboBoxLibrarian.DataSource = _librarianRepository.ReadLibrarians();
            comboBoxLibrarian.DisplayMember = "LastName";
            comboBoxLibrarian.ValueMember = "Id";

            comboBoxItem.DataSource = _itemRepository.ReadItems();
            comboBoxItem.DisplayMember = "Title";
            comboBoxItem.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxReader.SelectedIndex < 0 ||
                comboBoxLibrarian.SelectedIndex < 0 ||
                comboBoxItem.SelectedIndex < 0)
            {
                MessageBox.Show("Имеются незаполненные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var readerId = (int)comboBoxReader.SelectedValue!;
                var librarianId = (int)comboBoxLibrarian.SelectedValue!;
                var itemId = (int)comboBoxItem.SelectedValue!;

                var reader = _readerRepository.ReadReaderById(readerId);
                var librarian = _librarianRepository.ReadLibrarianById(librarianId);
                var item = _itemRepository.ReadItemById(itemId);

                if (reader != null && reader.TicketValidUntil < DateTime.UtcNow)
                {
                    MessageBox.Show($"У читателя {reader.FullName} просрочен билет!", "Отказ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (librarian != null && item != null)
                {
                    if ((librarian.AllowedThemes & item.Theme) == 0)
                    {
                        MessageBox.Show($"Библиотекарь {librarian.LastName} не имеет права выдавать литературу этой тематики!", "Отказ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }

                var loan = Loan.CreateOperation(
                    0,
                    readerId,
                    librarianId,
                    itemId,
                    dateTimePickerDueDate.Value.ToUniversalTime());

                _loanRepository.CreateLoan(loan);
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