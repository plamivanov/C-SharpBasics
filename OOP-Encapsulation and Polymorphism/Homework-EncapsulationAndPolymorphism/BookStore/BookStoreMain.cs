namespace BookStore
{
    using Interfaces;
    using UI;
    using Engine;
    using Books;                  //slojil sym druga zadacha...igrite ne me kefqt...mani,healthove,demedji...

    public class BookStoreMain
    {
        public static void Main()
        {
            IInputHandler input = new ConsoleInputHandler();
            IRenderer renderer = new ConsoleRenderer();
            BookStoreEngine engine = new BookStoreEngine(renderer,input);

            engine.Run();
        }
    }
}
