namespace C_AdvancedTopicsGenerics
{

    class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
            
        }
        public Nullable(T value)
        {
            _value = value;

        }
        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetDefaultValue()
        {
            if (HasValue)
            {
                return (T)_value;
            }
            else
            {
                return default(T);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //List of any type using Generics
            BookList<int> bookList = new BookList<int>();
            bookList.Add(1);
            bookList.Add(1000);
            Console.WriteLine(bookList[1]);

            BookList<Book> bookList2 = new BookList<Book>();

            bookList2.Add(new Book("World of AI"));
            bookList2 .Add(new Book("Life Of FI"));
            Console.WriteLine(bookList2[0].name);
            Console.WriteLine(bookList2[1].name);


            //Dictionary using Generics
            GenericDictionary<string,int> myDict=new GenericDictionary<string, int>();

            myDict.Add("Hello", 100);

            Console.WriteLine("For Key \"Hello\" :"+myDict["Hello"]);

            //Nullable

            var val=new Nullable<int>(100);

            Console.WriteLine("Has Value : "+val.HasValue);

            Console.WriteLine("Value : "+val.GetDefaultValue());

            var val1 = new Nullable<int>();

            Console.WriteLine("Has Value : " + val1.HasValue);

            Console.WriteLine("Value : " + val1.GetDefaultValue());



        }
    }
}
