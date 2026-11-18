using System;
using System.Windows.Forms;
using LibraryAccounting.Entities;
using LibraryAccounting.Entities.Enums;
using LibraryAccounting.Repositories;

namespace LibraryAccounting.Forms
{
    public partial class FormLibrarianEdit : Form
    {
        private readonly ILibrarianRepository _librarianRepository;
        private int? _librarianId;

        public FormLibrarianEdit(ILibrarianRepository librarianRepository)
        {
            InitializeComponent();
            _librarianRepository = librarianRepository ?? throw new ArgumentNullException(nameof(librarianRepository));

            // При создании формы заполняем CheckedListBox значениями из перечисления
            foreach (var elem in Enum.GetValues(typeof(LiteraryTheme)))
            {
                checkedListBoxThemes.Items.Add(elem);
            }
        }

        public int Id
        {
            set
            {
                try
                {
                    var librarian = _librarianRepository.ReadLibrarianById(value);
                    if (librarian == null) return;

                    textBoxFirstName.Text = librarian.FirstName;
                    textBoxLastName.Text = librarian.LastName;

                    // Проставляем галочки там, где темы совпадают
                    foreach (LiteraryTheme elem in Enum.GetValues(typeof(LiteraryTheme)))
                    {
                        if ((elem & librarian.AllowedThemes) != 0)
                        {
                            checkedListBoxThemes.SetItemChecked(checkedListBoxThemes.Items.IndexOf(elem), true);
                        }
                    }
                    _librarianId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                checkedListBoxThemes.CheckedItems.Count == 0)
            {
                MessageBox.Show("Имеются незаполненные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Магия флагового перечисления: собираем все галочки в одно число
            LiteraryTheme themes = LiteraryTheme.None;
            foreach (var elem in checkedListBoxThemes.CheckedItems)
            {
                themes |= (LiteraryTheme)elem;
            }

            var librarian = Librarian.CreateEntity(
                _librarianId ?? 0,
                textBoxFirstName.Text,
                textBoxLastName.Text,
                themes);

            if (_librarianId.HasValue)
                _librarianRepository.UpdateLibrarian(librarian);
            else
                _librarianRepository.CreateLibrarian(librarian);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}