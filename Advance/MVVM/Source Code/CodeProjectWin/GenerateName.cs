using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeProjectWin
{
    public class GenerateName
    {
        private readonly string[] _firstNames = new [] { "Bill", "Robert", "Eric", "Barry", "Sean", "Michael", "Roger", "Fanya", "Ahmed", "Alolita", "Partha", "Alasdair", "Ipke", "Wim", "Peter", "Gerhard", "Cathy", "Susanne", "Anita", "Danese" };

        private readonly string[] _lastNames = new [] { "Gates", "Kozma", "Horvitz", "Smith", "McGrath", "Montalbano", "Sisson", "Montalvo", "Elmagarmid", "Sharma", "Niyogi", "Turner", "Wachsmuth", "Sweldens", "Norton", "Fischer", "Hudgins", "Albers", "Borg", "Cooper" };

        private readonly string[] _midleNames = new [] { "A.", "B.", "C.", "D.", "E.", "F.", "G.", "H.", "I.", "J.", "K.", "L.", "M.", "N.", "O.", "P.", "Q.", "R.", "S.", "T.", "U.", "V.", "W.", "X.", "Y.", "Z." };

        public List<string> FullNames()
        {
            var temp1 = new List<string>();
            var temp2 = new List<string>();

            for (int i = 0; i < 20; i++)
                temp1.Add(string.Format("{0} {1}", _firstNames[i], _lastNames[i]));

            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 26; j++)
                    for (int k = 0; k < 20; k++)
                        temp2.Add(string.Format("{0} {1} {2}", _firstNames[i], _midleNames[j], _lastNames[k]));

            var rnd = new Random();
            temp2 = temp2.OrderBy(s => rnd.Next()).ToList();

            temp1.AddRange(temp2);

            return temp1;
        }
    }
}
