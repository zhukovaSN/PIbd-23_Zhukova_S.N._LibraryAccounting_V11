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

            comboBoxTheme.DataSource = Enum.GetValues(typeof(LiteraryTheme));
            comboBoxType.DataSource = Enum.GetValues(typeof(ItemType));
        }

        public int Id
        {
            set
            {
                _itemId = value;
                try
                {
                    var item = _itemRepository.ReadItemById(value);
                    if (item == null) return;

                    textBoxTitle.Text = item.Title;
                    comboBoxTheme.SelectedItem = item.Theme;
                    comboBoxType.SelectedItem = item.Type;
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

            try
            {
                var item = LiteraryItem.CreateEntity(
                    _itemId ?? 0,
                    textBoxTitle.Text,
                    (LiteraryTheme)comboBoxTheme.SelectedItem!,
                    (ItemType)comboBoxType.SelectedItem!);

                if (_itemId.HasValue)
                {
                    _itemRepository.UpdateItem(item);
                }
                else
                {
                    _itemRepository.CreateItem(item);
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