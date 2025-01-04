namespace Classes_PropertiesAndIndexers_
{
    class Pokemon
    {
        private string name;
        private int pokedexId;



        public string Name
        {

            get
            {
                return name;
            }
            set
            {

                name = value;

            }
        }
        public int ID 
        { 
            private get 
            {
                return pokedexId; 
            
            }


            set
            {
                pokedexId = value;
            }
        
        }


        public void Show()
        {
            Console.WriteLine(name);
        }

    }
}
