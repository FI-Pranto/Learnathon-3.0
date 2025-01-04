namespace Classes_Constructors_
{
    class Enemey
    {
       public string name;
       public int hpLevel;
        List<int> targets;


        public Enemey()//ctor is shortcut to create constructor
        {
            targets=new List<int>();
            
        }

        public Enemey(int hpLevel)
            :this()
        {
            this.hpLevel = hpLevel;
        }
        public Enemey(string name,int hpLevel)
            :this(hpLevel)
        {
            this.name = name;
        }



    }
}
