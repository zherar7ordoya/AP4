using Microsoft.EntityFrameworkCore.Infrastructure;

namespace SQLiteCRUD
{
    public partial class App : Form
    {
        public List<User> DatabaseUsers { get; private set; }

        public App() => InitializeComponent();

        private void App_Load(object sender, EventArgs e)
        {
            DatabaseFacade facade = new DatabaseFacade(new DataContext());
            facade.EnsureCreated();
            ReadButton_Click(sender, EventArgs.Empty);
            CoordinateComponents();
        }

        private void CoordinateComponents()
        {
            if (ItemList.SelectedRows.Count != 0)
            {
                NameTextBox.Text = ItemList.SelectedRows[0].Cells[1].Value.ToString();
                AddressTextBox.Text = ItemList.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext())
            {
                var name = NameTextBox.Text;
                var address = AddressTextBox.Text;

                if(name != null && address != null)
                {
                    context
                    .Users
                    .Add(new User()
                    {
                        Name = name,
                        Address = address
                    });
                    context.SaveChanges();
                }
            }
            ReadButton_Click(sender, EventArgs.Empty);
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext())
            {
                DatabaseUsers = context.Users.ToList();
                ItemList.DataSource = DatabaseUsers;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext())
            {
                // https://stackoverflow.com/a/19682606/14009797
                User selectedUser = (User)ItemList.CurrentRow.DataBoundItem;
                var name = NameTextBox.Text;
                var address = AddressTextBox.Text;

                if (name != null && address != null)
                {
                    User user = context.Users.Find(selectedUser.Id);
                    user.Name = name;
                    user.Address = address;
                    context.SaveChanges();
                }
            }
            ReadButton_Click(sender, EventArgs.Empty);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (DataContext context = new DataContext())
            {
                // https://stackoverflow.com/a/19682606/14009797
                User selectedUser = (User)ItemList.CurrentRow.DataBoundItem;

                if (selectedUser != null)
                {
                    User user = context.Users.Single(x => x.Id == selectedUser.Id);
                    context.Remove(user);
                    context.SaveChanges();
                }
            }
            ReadButton_Click(sender, EventArgs.Empty);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseUsers = null;
            ItemList.DataSource = DatabaseUsers;
        }

        private void ItemList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CoordinateComponents();
        }

        private void EditCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NameLabel.Enabled)
            {
                NameLabel.Enabled = false;
                NameTextBox.Enabled = false;
                AddressLabel.Enabled = false;
                AddressTextBox.Enabled = false;
            }
            else
            {
                NameLabel.Enabled = true;
                NameTextBox.Enabled = true;
                AddressLabel.Enabled = true;
                AddressTextBox.Enabled = true;
            }
        }
    }
}