using System;
using System.Windows.Forms;
using LibraryAccounting.Entities;
using LibraryAccounting.Entities.Enums;
using LibraryAccounting.Repositories;

namespace LibraryAccounting.Forms
{
    public partial class FormLiteraryItemEdit : Form
    {
        private readonly ILiteraryItemRepository _itemRepository;
        private int? _itemId;

        public FormLiteraryItemEdit(ILiteraryItemRepository itemRepository)
        {
            InitializeComponent();
            _itemRepository = itemRepository ?? throw new ArgumentNullException(nameof(itemRepository));

            // Заполняем выпадающие списки значениями из перечислений
            comboBoxTheme.DataSource = Enum.GetValues(typeof(LiteraryTheme));
            comboBoxType.DataSource = Enum.GetValues(typeof(ItemType));
        }

        public int Id
        {
            set
            {
                try
                {
                    var item = _itemRepository.ReadItemById(value);
                    if (item == null) return;

                    textBoxTitle.Text = item.Title;
                    comboBoxTheme.SelectedItem = item.Theme;
                    comboBoxType.SelectedItem = item.Type;
                    _itemId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                MessageBox.Show("Имеются незаполненные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = LiteraryItem.CreateEntity(
                _itemId ?? 0,
                textBoxTitle.Text,
                (LiteraryTheme)comboBoxTheme.SelectedItem!,
                (ItemType)comboBoxType.SelectedItem!);

            if (_itemId.HasValue)
                _itemRepository.UpdateItem(item);
            else
                _itemRepository.CreateItem(item);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}