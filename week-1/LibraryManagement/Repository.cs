using System.Collections.Generic;

namespace LibraryManagement
{
    public class Repository<T> where T : IIdentifiable
    {
        private readonly List<T> _items = new List<T>();
        private readonly Dictionary<string, T> _itemDictionary = new Dictionary<string, T>();

        public void Add(T item)
        {
            if (_itemDictionary.ContainsKey(item.Id))
            {
                throw new DuplicateItemException($"Item with ID '{item.Id}' already exists.");
            }

            _items.Add(item);
            _itemDictionary.Add(item.Id, item);
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public T GetById(string id)
        {
            if (!_itemDictionary.TryGetValue(id, out T item))
            {
                throw new ItemNotFoundException($"Item with ID '{id}' was not found.");
            }
            return item;
        }

        public void Remove(string id)
        {
            T item = GetById(id);
            _items.Remove(item);
            _itemDictionary.Remove(id);
        }
    }
}
