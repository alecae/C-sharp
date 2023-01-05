using System.Collections.Generic;
using System;


public class Pile<T>
{
    private readonly List<T> _items = new List<T>();

    public void Push(T item)
    {
        _items.Add(item);
    }

    public Inventaire()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("La pile est vide.");
        }

        T item = _items[_items.Count - 1];
        _items.RemoveAt(_items.Count - 1);
        return item;
    }
}