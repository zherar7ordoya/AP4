using System.Windows.Forms;

namespace CodeProjectWin
{
    public partial class MainForm
    {
        #region fields

        private ViewModel _viewModel;

        #endregion

        #region CTor

        public MainForm()
        {
            InitializeComponent();
            InitialControlHandlers();
        }

        #endregion

        #region Methods


        //Defining all Control handler methods
        //
        private void InitialControlHandlers()
        {
            _viewModel = new ViewModel();

            var listForm = new ListForm
            {
                ViewModel = _viewModel
            };

            //Defines the listForm as an owned form
            AddOwnedForm(listForm);

            //Defines: if ListForm closes, the MainForm will close too
            listForm.FormClosing += (sender, e) =>
            {
                listForm.Dispose();
                Close();
            };


            //If the end user press Enter key, it will be like he/she clicked on Add button. 
            NameForAdding.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)13)
                    AddToList();
            };

            Add.Click += (sender, e) => AddToList();

            Add.Tag = _viewModel.AddToListCommand;

            NameForAdding.Tag = _viewModel.TextChangedCommand;

            NameForAdding.DataBindings.Add(new Binding("Text", _viewModel, "Text"));

            listForm.Show();
        }

        private void AddToList()
        {

            _viewModel.Execute(Add.Tag, null);
            NameForAdding.Text = string.Empty;
            NameForAdding.Focus();
        }

        #endregion
    }
}
