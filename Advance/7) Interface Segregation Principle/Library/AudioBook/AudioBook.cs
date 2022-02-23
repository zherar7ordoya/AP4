using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class AudioBook : IBorrowableAudioBook
    {
        public string LibraryId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int RuntimeInMinutes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime BorrowDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Borrower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CheckOutDurationInDays { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CheckIn()
        {
            throw new NotImplementedException();
        }

        public void CheckOut()
        {
            throw new NotImplementedException();
        }

        public DateTime GetDueDate()
        {
            throw new NotImplementedException();
        }
    }
}
