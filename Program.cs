public class MyDictionary<TKey,TValue>
{
    private List<TKey> _keys;
    private List<TValue> _values;

    public MyDictionary()
    {
        _keys = new List<TKey>();
        _values = new List<TValue>();
    }

    public void Add(TKey key, TValue value){
        if (_keys.Contains(key))
        {
            throw new ArgumentException("An item with the same key has already been added.");
        }
        _keys.Add(key);
        _values.Add(value);
    }
}
//Kendi sözlük yapımı tasarladım ve buna ekleme metodu yazdım 
