namespace Playground2
{
    internal abstract class Decorator : LibraryItem
    {
        protected Decorator(LibraryItem libraryItem)
        {
            this.LibraryItem = libraryItem;
        }

        protected LibraryItem LibraryItem { get; private set; }

        public override void Display()
        {
            this.LibraryItem.Display();
        }
    }
}
