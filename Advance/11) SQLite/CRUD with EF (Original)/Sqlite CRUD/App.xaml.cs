using System.Windows;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Sqlite_CRUD
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {

            DatabaseFacade facade = new DatabaseFacade(new DataContext());
            facade.EnsureCreated();

        }

    }
}
