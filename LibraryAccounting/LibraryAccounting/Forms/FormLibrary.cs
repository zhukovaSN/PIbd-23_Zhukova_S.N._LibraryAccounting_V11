using LibraryAccounting.Forms;
using System;
using System.Windows.Forms;
using Unity;

namespace LibraryAccounting // Убрали .Forms, чтобы совпадало с дизайнером!
{
    public partial class FormLibrary : Form
    {
        private readonly IUnityContainer _container;

        public FormLibrary(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        private void readersMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormReaders>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void librariansMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormLibrarians>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void literaryItemsMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormLiteraryItems>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loansMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormLoans>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void suppliesMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormSupplies>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}