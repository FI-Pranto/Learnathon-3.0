namespace C_AdvancedTopicsLamdaExpression
{

    class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }

    class BookRepository
    {
        public  List<Book> GetList()
        {
            return new List<Book>()
            {
                new Book(){Title="T1",Price=7},
                new Book(){Title="T2",Price=9},
                new Book(){Title="T3",Price=12}

            };
            

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            //args => expression
            //() => ..
            // x=> ....
            // (x,y) => ...
           
            Func<int, int> Power = num => num * num;
            Console.WriteLine(Power(5));

            Func<int,int,int> Mul=(x,y)=> x * y;
            //3 int last one is for output type 1st two is for input type
            Console.WriteLine(Mul(5,6));

            var books = new BookRepository().GetList();

            var cheapBooks=books.FindAll(b => b.Price < 10);

            foreach(var book in cheapBooks)
                Console.WriteLine(book.Title);

            

            
        }
    }
}
