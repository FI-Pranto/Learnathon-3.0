namespace C_AdvancedTopicsGenerics
{
    //where T: IComparable
    //where T: struct
    //where T: class
    //where T: new()
    //where T: Book // any class and its  subclasses
    class Utilities<T> where T: IComparable,new()
    {
        public T Max(T a,T b)// you could make the Function Generic only not the class by public T Max<T>(T a, T b) where T: IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;//a>b check
        }

        public void DoSomeThing()
        {
            var obj = new T();
        }
    }
}
