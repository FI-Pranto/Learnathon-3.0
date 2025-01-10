namespace C_AdvancedTopicsNullableType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //we can make it assign null value by this way
            Nullable<DateTime> date = null;
            //or
            DateTime? date2 = null;

            Console.WriteLine(date2.GetValueOrDefault());//if the value is null return default dateTime else actual value
            Console.WriteLine(date2.HasValue);//return false if no value means null value

            DateTime date3 = date.GetValueOrDefault();//if null date3 will get default value

            DateTime? date4 = null;
            DateTime date5;

            /* if(date4!= null)
             {
                 date5 = date4.GetValueOrDefault();
             }
             else
             {
                 date5 = DateTime.Today;
             }*/
            //doing this using null colosing operator 
            date5 = date4 ?? DateTime.Today;

            Console.WriteLine(date5);

        }
    }
}
