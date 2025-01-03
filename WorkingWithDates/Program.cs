namespace WorkingWithDates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Date Time
            DateTime dateTime = new DateTime(2015, 1, 1);

            DateTime now=DateTime.Now;

            DateTime today=DateTime.Today;

            Console.WriteLine(now.Minute);
            Console.WriteLine(now.Hour);

            var dayTwo=dateTime.AddDays(2);

          //  Console.WriteLine(dayTwo);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy:MM:dd:hh:mm:ss"));


            //TimeSpan

            TimeSpan timeSpan = new TimeSpan(1, 2, 3);

            TimeSpan timeSpan1=TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = start.AddMinutes(2);
            Console.WriteLine(end-start);

            //Properties
            Console.WriteLine("Minutes "+timeSpan.Minutes);
            Console.WriteLine("Total minutes "+timeSpan.TotalMinutes);

            //Add
            Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(timeSpan.Subtract(timeSpan1));

            Console.WriteLine(timeSpan1.ToString());

            //we can directly give string and convert it as TimeSpan (V.V.I)
            Console.WriteLine("Parse "+TimeSpan.Parse("01:02:09"));
        }
    }
}
