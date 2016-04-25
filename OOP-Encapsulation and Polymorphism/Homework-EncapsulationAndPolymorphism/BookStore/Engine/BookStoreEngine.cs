namespace BookStore.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Books;
    using Interfaces;

    public class BookStoreEngine
    {
        private readonly IRenderer renderer;
        private readonly IInputHandler input;
        private readonly List<IBook> books;
        private decimal revenue;

        public BookStoreEngine(IRenderer renderer,IInputHandler input)
        {
            this.renderer=renderer;
            this.input=input;
            this.books = new List<IBook>();
            this.revenue = 0;
        }

        public bool IsRunning { get; private set; }

        
        public void Run()
        {
            this.IsRunning = true;
            while (this.IsRunning)
            {
                string command = this.input.ReadLine();

                if (string.IsNullOrWhiteSpace(command))
                {
                    continue;
                }

                string[] commandArgs = command.Split();

                string commandResult = this.ExecuteCommand(commandArgs);

                this.renderer.WriteLine(commandResult);
            }

            this.renderer.WriteLine("Total revenue: {0:0.00}", this.revenue);
        }

        private string ExecuteCommand(string[] commandArgs)
        {
            switch (commandArgs[0])
            {
                case "add":
                    return this.ExecuteAddBookCommand(commandArgs);
                case "sell":
                    return this.ExecuteSellBookCommand(commandArgs);
                case "remove":
                    return this.ExecuteRemoveBookCommand(commandArgs);
                case "stop":
                    this.IsRunning = false;
                    return "Goodbye!";
                default:
                    return "Unknown command";
            }
        }

        private string ExecuteSellBookCommand(string[] commandArgs)
        {
            string title = commandArgs[1];

            IBook bookToSellOrRemove = this.books.FirstOrDefault(book => book.Title == title);

            if (bookToSellOrRemove == null)
            {
                return "Book does not exist";
            }

            this.books.Remove(bookToSellOrRemove);

            this.revenue += bookToSellOrRemove.Price;
            return "Book sold";
           
        }

        private string ExecuteRemoveBookCommand(string[] commandArgs)
        {
            string title = commandArgs[1];

            IBook bookToSellOrRemove = this.books.FirstOrDefault(book => book.Title == title);

            if (bookToSellOrRemove == null)
            {
                return "Book does not exist";
            }

            this.books.Remove(bookToSellOrRemove);

            return "Book removed";
        }

        private string ExecuteAddBookCommand(string[] commandArgs)
        {
            string title = commandArgs[1];
            string author = commandArgs[2];
            decimal price = decimal.Parse(commandArgs[3]);

            this.books.Add(new Book(title, author, price));

            return "Book added";
        }
    }
}
