using Microsoft.EntityFrameworkCore.Infrastructure;

namespace SQLiteCRUD
{
    public partial class App : Form
    {
        public App() => InitializeComponent();

        private void App_Load(object sender, EventArgs e)
        {
            DatabaseFacade facade = new DatabaseFacade(new DataContext());
            facade.EnsureCreated();
        }
    }
}