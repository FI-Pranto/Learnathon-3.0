namespace Classes_Constructors_
{
    class Enemy
    {
       public string name;
       public int hpLevel;
       public readonly List<int> targets;


        public Enemy()//ctor is shortcut to create constructor
        {
           targets=new List<int>();
            
        }
      /*  void Hello() //Shows error because the list is readonly means only initialized inside constructor or when declared
        {
            targets = new List<int>();
        }*/

        public Enemy(int hpLevel)
            :this()
        {
            this.hpLevel = hpLevel;
        }
        public Enemy(string name,int hpLevel)
            :this(hpLevel)
        {
            this.name = name;
        }



    }
}
