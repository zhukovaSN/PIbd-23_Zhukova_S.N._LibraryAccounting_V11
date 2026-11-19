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

            checkedListBoxThemes.Items.Clear();
            foreach (var elem in Enum.GetValues(typeof(LiteraryTheme)))
            {
                checkedListBoxThemes.Items.Add(elem);
            }
        }

        public int Id
        {
            set
            {
                _librarianId = value;
                try
                {
                    var librarian = _librarianRepository.ReadLibrarianById(value);
                    if (librarian == null) return;

                    textBoxFirstName.Text = librarian.FirstName;
                    textBoxLastName.Text = librarian.LastName;

                    for (int i = 0; i < checkedListBoxThemes.Items.Count; i++)
                    {
                        checkedListBoxThemes.SetItemChecked(i, false);
                    }

                    foreach (LiteraryTheme theme in Enum.GetValues(typeof(LiteraryTheme)))
                    {
                        if ((librarian.AllowedThemes & theme) != 0 && theme != LiteraryTheme.None)
                        {
                            int index = checkedListBoxThemes.Items.IndexOf(theme);
                            if (index >= 0)
                            {
                                checkedListBoxThemes.SetItemChecked(index, true);
                            }
                        }
                    }
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

            try
            {
                LiteraryTheme themes = LiteraryTheme.None;
                foreach (var item in checkedListBoxThemes.CheckedItems)
                {
                    themes |= (LiteraryTheme)item;
                }

                var librarian = Librarian.CreateEntity(
                    _librarianId ?? 0,
                    textBoxFirstName.Text,
                    textBoxLastName.Text,
                    themes);

                if (_librarianId.HasValue)
                {
                    _librarianRepository.UpdateLibrarian(librarian);
                }
                else
                {
                    _librarianRepository.CreateLibrarian(librarian);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}