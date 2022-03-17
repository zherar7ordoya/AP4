using System.Windows.Forms;

namespace CodeProjectWin
{
    public partial class ListForm
    {
        public ListForm()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        //Properties
        public ViewModel ViewModel { get; set; }

        //Methods
        private void InitializeEventHandlers()
        {
            Load += (sender, e) =>
            {
                var binding = new BindingSource
                {
                    DataSource = ViewModel.NameList
                };
                DataGridView.DataSource = binding;
                ViewModel.PropertyChanged += (o, eventArg) => BindDataGridView();
            };
        }

        private void BindDataGridView()
        {
            var binding = new BindingSource
            {
                DataSource = ViewModel.NameList
            };
            DataGridView.DataSource = binding;
        }
    }
}
