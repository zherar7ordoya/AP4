using System;

namespace Library.Base
{
    public interface IBorrowableItem
    {
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }
        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}
