namespace Classes_PropertiesAndIndexers_
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Properties
            Pokemon p = new Pokemon();
            p.Name = "Pikachu";
            p.ID = 126;
            Console.WriteLine(p.Name);
            //Console.WriteLine(p.ID); //error cause set is private for iD property

            //Indexers
            var s1 = new Student();
            s1["B-225"] = "Akash";
            Console.WriteLine(s1["B-225"]);

      
        }
    }
}
