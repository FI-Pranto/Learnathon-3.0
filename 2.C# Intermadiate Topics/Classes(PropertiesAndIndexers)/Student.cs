namespace Classes_PropertiesAndIndexers_
{
    class Student
    {
        public readonly Dictionary<string, string> Students;
        public Student()
        {
            Students = new Dictionary<string,string>();
        }

        public string this[string key]
        {
            get { return Students[key]; }
            set { Students[key] = value; }
        }
    }
}
