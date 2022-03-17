using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace CodeProjectWin
{
    public class DataAccess
    {
        private readonly Random _random = new Random();
        private int _counter;

        private readonly List<string> _names;
        public DataAccess()
        {
            _names = new GenerateName().FullNames();
        }

        public static ObservableCollection<StringValue> Data = new ObservableCollection<StringValue>();

        public ObservableCollection<StringValue> Select()
        {
            var temp = new ObservableCollection<StringValue>();

            foreach (StringValue s in Data)
            {
                temp.Add(s);
            }

            return temp;
        }

        public void Update(ObservableCollection<StringValue> data)
        {
            Data = new ObservableCollection<StringValue>();

            foreach (StringValue s in data)
            {
                Data.Add(s);
            }

            var k = _random.Next(0, 3);

            for (var i = 0; i < k; i++)
            {
                Data.Add(new StringValue(_names[_counter]));
                _counter = (_counter >= _names.Count()) ? 0 : _counter + 1;
            }

            if (DatabaseUpdated != null)
                DatabaseUpdated(Data);
        }

        public delegate void UpdateHandler(ObservableCollection<StringValue> list);
        public UpdateHandler DatabaseUpdated;
    }
}
