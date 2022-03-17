using System.ComponentModel;
using System.Collections.ObjectModel;
using CodeProjectWin;

namespace CodeProjectWin
{
    public class ViewModel : INotifyPropertyChanged
    {
        #region Properties

        public string Text { get; set; }

        private ICommand _addToListCommand;
        public ICommand AddToListCommand
        {
            get
            {
                return _addToListCommand ?? (_addToListCommand = new AddToList(this));
            }
        }

        private ICommand _textChangedCommand;
        public ICommand TextChangedCommand
        {
            get
            {
                return _textChangedCommand ?? (_textChangedCommand = new TextChanged(this));
            }
        }

        private ObservableCollection<StringValue> _nameList;
        public ObservableCollection<StringValue> NameList
        {
            get
            {
                return _nameList;
            }

            set
            {
                _nameList = value;

                _nameList.CollectionChanged += MyPropertyCollectionChanged;
            }
        }

        #endregion

        #region CTor

        public ViewModel()
        {
            var model = new Model();
            model.PropertyChanged += ModelPropertyChanged;
            NameList = model.List;
        }

        #endregion

        #region PropeetyChanged Handlers

        void ModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NameList = (ObservableCollection<StringValue>)sender; //For Get any new entity Changed 
        }

        void MyPropertyCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            {
                NotifyPropertyChanged("NameList");
            }
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        public void Execute(object sender, object parameter)
        {
            ((ICommand)sender).Execute(parameter);
        }

        #endregion
    }


}

#region I Classes

public class AddToList : ICommand
{
    #region CTor

    public AddToList(ViewModel viewModel)
    {
        ViewModel = viewModel;
    }

    #endregion

    #region Properties

    public ViewModel ViewModel { get; set; }

    #endregion

    #region ICommand Members

    public void Execute(object sender)
    {
        if (string.IsNullOrEmpty(ViewModel.Text))
            return;
        if (string.IsNullOrEmpty(ViewModel.Text.Trim()))
            return;

        ViewModel.NameList.Add(new StringValue(ViewModel.Text));
    }

    #endregion
}

public class TextChanged : ICommand
{
    #region CTor

    public TextChanged(ViewModel viewModel)
    {
        DataAccess = viewModel;
    }

    #endregion

    #region Properties

    public ViewModel DataAccess { get; set; }

    #endregion

    #region ICommand Members

    public void Execute(object sender)
    {
        DataAccess.Text = sender.ToString();
    }

    #endregion
}

#endregion



#region StringValue Class

public class StringValue
{
    public string Value { get; set; }

    public StringValue(string value)
    {
        Value = value;
    }
}

#endregion
