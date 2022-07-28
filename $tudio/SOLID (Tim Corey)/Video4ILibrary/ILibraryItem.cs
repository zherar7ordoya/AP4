using System.Collections.Generic;

namespace Video4ILibrary
{
    public interface ILibraryItem
    {
        string LibraryId { get; set; }
        string Title { get; set; }

        /*
        string Author { get; set; }
        int Pages { get; set; }

        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; } 
        void CheckIn();
        void CheckOut();
        DateTime GetDueDate();
        */
    }


    public interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }


    public interface IBorrowableAudiobook : IAudioBook, IBorrowable
    {

    }

    public interface IDVD
    {
        List<string> Actors { get; set; }
        int RuntimeInMinutes { get; set; }
    }


    public interface IBorrowableDVD :IDVD, IBorrowable

}
