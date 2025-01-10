namespace C_AdvancedTopicsLinq
{
    class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() { Title = "FI's Advanture : End Of Era", Price = 20 },
                new Book() { Title = "FI's Advanture Part 2 : New Planet", Price = 25 },
                new Book() { Title = "FI's Advanture Part 3.1 : Known", Price = 31 },
                new Book() { Title = "FI's Advanture Part 3.2 : Unkown", Price = 22 },
                new Book() { Title = "FI's Advanture Part 4 : The Lost World", Price = 35 }
            };
        }
    }
}
