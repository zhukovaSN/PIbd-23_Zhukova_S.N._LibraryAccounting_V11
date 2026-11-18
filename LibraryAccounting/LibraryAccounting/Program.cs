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

            // Создаем IoC-контейнер и просим его запустить главную форму
            Application.Run(CreateContainer().Resolve<FormLibrary>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            // Регистрируем наши репозитории. 
            // По умолчанию Unity создает новый экземпляр при каждом запросе (Transient)
            container.RegisterType<IReaderRepository, ReaderRepository>();
            container.RegisterType<ILibrarianRepository, LibrarianRepository>();
            container.RegisterType<ILiteraryItemRepository, LiteraryItemRepository>();
            container.RegisterType<ILoanRepository, LoanRepository>();
            container.RegisterType<ISupplyRepository, SupplyRepository>();

            return container;
        }
    }
}