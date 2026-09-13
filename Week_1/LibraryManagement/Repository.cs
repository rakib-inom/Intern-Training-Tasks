namespace LibraryManagement
{
    public class Repository<T> where T : IIdentifiable
    {
        private readonly List<T> _items;
        private readonly Dictionary<string, T> _itemsById;

        public Repository()
        {
            _items = new List<T>();
            _itemsById = new Dictionary<string, T>();
        }

        public void Add(T item)
        {
            if (_itemsById.ContainsKey(item.Id))
            {
                throw new DuplicateItemException($"An item with ID '{item.Id}' already exists.");
            }
            _items.Add(item);
            _itemsById.Add(item.Id, item);
        }

        public List<T> GetAll()
        {
            return _items;
        }

        public T GetById(string id)
        {
            if (!_itemsById.TryGetValue(id, out T? item))
            {
                throw new NotFoundException($"Item with ID '{id}' not found.");
            }
            return item;
        }

        public void Remove(string id)
        {
            T item = GetById(id);
            _items.Remove(item);
            _itemsById.Remove(item.Id);
        }
    }
}
