namespace C_AdvancedTopicsGenerics
{
    class BookList<T> // you can give Any name Instead of <T> Like <MyType> but for better readability use <T>
    {
        private readonly List<T> _list;
        public BookList()
        {
            _list = new List<T>();
        }
        public void Add(T item)
        {
            _list.Add(item);

        }

        public T this[int idx]
        {
            get {

                if (_list.Count != 0 && (idx >= 0 && idx <= _list.Count))
                {

                    return _list[idx];
                }
                else
                {
                    throw new IndexOutOfRangeException("Out of Range");
                }




            }
        }
    }
}
