using LibraryAccounting.Repositories;
using LibraryAccounting.Repositories.Implementations;
using System;
using System.Windows.Forms;
using Unity;

namespace LibraryAccounting
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(CreateContainer().Resolve<FormLibrary>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IReaderRepository, ReaderRepository>();
            container.RegisterType<ILibrarianRepository, LibrarianRepository>();
            container.RegisterType<ILiteraryItemRepository, LiteraryItemRepository>();
            container.RegisterType<ILoanRepository, LoanRepository>();
            container.RegisterType<ISupplyRepository, SupplyRepository>();

            return container;
        }
    }
}