using LibraryAccounting.Data;
using LibraryAccounting.Repositories;
using LibraryAccounting.Repositories.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.IO;
using System.Windows.Forms;
using Unity;
using Unity.Microsoft.Logging;

namespace LibraryAccounting
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<FormLibrary>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            container.AddExtension(new LoggingExtension(CreateLoggerFactory()));

            container.RegisterType<LibraryContext>(new Unity.Lifetime.TransientLifetimeManager());

            container.RegisterType<IReaderRepository, ReaderRepository>();
            container.RegisterType<ILibrarianRepository, LibrarianRepository>();
            container.RegisterType<ILiteraryItemRepository, LiteraryItemRepository>();
            container.RegisterType<ILoanRepository, LoanRepository>();
            container.RegisterType<ISupplyRepository, SupplyRepository>();

            return container;
        }

        private static LoggerFactory CreateLoggerFactory()
        {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddSerilog(new LoggerConfiguration()
                .ReadFrom.Configuration(new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build())
                .CreateLogger());
            return loggerFactory;
        }
    }
}