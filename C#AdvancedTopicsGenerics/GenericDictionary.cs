namespace C_AdvancedTopicsGenerics
{
    class GenericDictionary<TKey, TValue>
    {

        private readonly Dictionary<TKey, TValue> _dict;
        public GenericDictionary()
        {
            
            _dict = new Dictionary<TKey, TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            _dict[key] = value;

        }

        public TValue this[TKey key]
        {
            get { return _dict[key];  }
        }

    }
}
