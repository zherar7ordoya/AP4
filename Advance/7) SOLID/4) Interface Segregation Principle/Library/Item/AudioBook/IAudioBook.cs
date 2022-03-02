using Library.Base;
using Library.Classic;
using Library.Digital;

namespace Library.Item.AudioBook
{
    public interface IAudioBook : ILibraryItem, IBookBase, IBorrowableItem, IPlayable
    {
    }
}
