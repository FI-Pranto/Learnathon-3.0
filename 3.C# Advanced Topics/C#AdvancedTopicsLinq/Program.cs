namespace C_AdvancedTopicsLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linq extension Methods
            var books=new BookRepository().GetBooks();
            //it is like sql where, orderby and select

            var cheapBooks = books.Where(b => b.Price < 25).OrderBy(b=>b.Title).Select(b=>b.Title);

            foreach (var book in cheapBooks)
            {
                //Console.WriteLine(book.Title);
                Console.WriteLine(book);
            }
            //Linq query operators

            var cheaperBooks= from b in books 
                              where b.Price < 25 
                              orderby b.Title 
                              select b.Title;

            //Works similarly like above but Above ones are the real deal 
            foreach(var book in cheaperBooks)
            {
                Console.WriteLine(book);
            }

            //More Extension Methods

            var oneBook = books.Single(b => b.Title == "FI's Advanture Part 4 : The Lost World");//if the value doesnot matches it gives Error so
            Console.WriteLine(oneBook.Title+"  "+oneBook.Price);
            //we have this method, this return null if no book is matched 
            oneBook = books.SingleOrDefault(b => b.Title == "FI's Advanture Part 4 : The Lost World ...");
            Console.WriteLine(oneBook==null);
            //similar methods
            //First() return 1st book that meets the condition
            //FirstOrDefault() return null if not found
            //Last()
            //LastOrDefault()

            var takenBooks = books.Skip(3).Take(2);
            //skip 1st 3 and then take two

            foreach (var book in takenBooks)
            {
                Console.WriteLine(book.Title);
            }
            int count = books.Count();
            Console.WriteLine(count);
            var maxPrice=books.Max(b=>b.Price);
            Console.WriteLine(maxPrice);
            var minPrice=books.Min(b=>b.Price);
            Console.WriteLine(minPrice);
            var totalPrice=books.Sum(b=>b.Price);
            Console.WriteLine(totalPrice);
            var avgPrice=books.Average(b=>b.Price);
            Console.WriteLine(avgPrice);
            



            
        }
    }
}
