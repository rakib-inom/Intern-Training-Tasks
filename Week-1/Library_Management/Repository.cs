public class Repository<T> where T: IIdentifiable
{
    private List<T> items = new List<T>();
    private Dictionary<string, T> itemsById = new Dictionary<string, T>();
    
    public void Add(T item)
    {
        if (itemsById.ContainsKey(item.ID))
        {
            
            throw new DuplicateItemException("this ID already esxists.");

        }
        items.Add(item);
        itemsById.Add(item.ID, item);
    }

    public List<T> getAll()
    {
        return items;
    }

    public T GetById(string id)
    {
        if (!itemsById.ContainsKey(id))
        {
            throw new ItemNotFoundException("book not found");
        }
        return itemsById[id];
    }

    public void Remove(string id)
    {
        T item = GetById(id);

        itemsById.Remove(id);
        items.Remove(item);
    }
}