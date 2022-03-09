using Library.Base;
using Library.Classic;

namespace Library.Item.Book
{
    public interface IBook : ILibraryItem, IBookBase, IBorrowableItem, IPaperBook
    {
    }
}
