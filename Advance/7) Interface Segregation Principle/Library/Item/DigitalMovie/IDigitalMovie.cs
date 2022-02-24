using Library.Base;
using Library.Digital;

namespace Library.Item.DigitalMovie
{
    public interface IDigitalMovie : ILibraryItem, IBorrowableItem, IScreenable, IPlayable
    {
    }
}
