using System;
using System.Windows.Forms;
using LibraryAccounting.Entities;
using LibraryAccounting.Repositories;

namespace LibraryAccounting.Forms
{
    public partial class FormReaderEdit : Form
    {
        private readonly IReaderRepository _readerRepository;
        private int? _readerId;

        public FormReaderEdit(IReaderRepository readerRepository)
        {
            InitializeComponent();
            _readerRepository = readerRepository ?? throw new ArgumentNullException(nameof(readerRepository));
        }

        public int Id
        {
            set
            {
                try
                {
                    var reader = _readerRepository.ReadReaderById(value);
                    if (reader == null) return;

                    textBoxFullName.Text = reader.FullName;
                    textBoxTicketNumber.Text = reader.TicketNumber;
                    dateTimePickerValidUntil.Value = reader.TicketValidUntil;
                    _readerId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text) || string.IsNullOrWhiteSpace(textBoxTicketNumber.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var reader = Reader.CreateEntity(
                _readerId ?? 0,
                textBoxFullName.Text,
                textBoxTicketNumber.Text,
                dateTimePickerValidUntil.Value);

            if (_readerId.HasValue)
                _readerRepository.UpdateReader(reader);
            else
                _readerRepository.CreateReader(reader);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}