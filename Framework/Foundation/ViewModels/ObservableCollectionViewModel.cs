using Mediator;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

public partial class ObservableCollectionViewModel<T> : IList<T>, IList, IReadOnlyList<T>, INotifyCollectionChanged
{
    public ObservableCollection<T> items = new();

    private readonly IMediator mediator;

    public ObservableCollectionViewModel(IMediator mediator)
    {
        this.mediator = mediator;
        items.CollectionChanged += OnCollectionChanged;
    }

    public event NotifyCollectionChangedEventHandler? CollectionChanged;

    public int Count => items.Count;

    bool IList.IsFixedSize => false;

    bool ICollection<T>.IsReadOnly => false;

    bool IList.IsReadOnly => false;

    bool ICollection.IsSynchronized => false;

    object ICollection.SyncRoot => this;

    protected IList<T> Items => items;

    public T this[int index]
    {
        get => items[index];
        set
        {
            SetItem(index, value);
        }
    }

    object? IList.this[int index]
    {
        get => items[index];
        set
        {
            T? item = default;

            try
            {
                item = (T)value!;
            }
            catch (InvalidCastException)
            {

            }

            this[index] = item!;
        }
    }

    public async void Add(params object?[] parameters)
    {
        int index = items.Count;
        if (await mediator.Send(new Create(typeof(T), parameters)) is object item)
        {
            InsertItem(index, (T)item);
        }
    }

    public async void Add<TItem>(params object?[] parameters) where TItem : T
    {
        int index = items.Count;
        if (await mediator.Send(new Create(typeof(TItem), parameters)) is object item)
        {
            InsertItem(index, (T)item);
        }
    }

    public void Add(T item)
    {
        int index = items.Count;
        InsertItem(index, item);
    }

    int IList.Add(object? value)
    {
        T? item = default;

        try
        {
            item = (T)value!;
        }
        catch (InvalidCastException)
        {

        }

        Add(item!);
        return Count - 1;
    }

    public void Clear()
    {
        ClearItems();
    }

    public bool Contains(T item)
    {
        return items.Contains(item);
    }

    bool IList.Contains(object? value)
    {
        if (IsCompatibleObject(value))
        {
            return Contains((T)value!);
        }
        return false;
    }

    public void CopyTo(T[] array, int index)
    {
        items.CopyTo(array, index);
    }

    void ICollection.CopyTo(Array array, int index)
    {
        items.CopyTo((T[])array, index);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)items).GetEnumerator();
    }

    public int IndexOf(T item)
    {
        return items.IndexOf(item);
    }

    int IList.IndexOf(object? value)
    {
        if (IsCompatibleObject(value))
        {
            return IndexOf((T)value!);
        }
        return -1;
    }

    public void Insert(int index, T item)
    {
        InsertItem(index, item);
    }

    void IList.Insert(int index, object? value)
    {
        if (value is T item)
        {
            Insert(index, item);
        }
    }

    public bool Remove(T item)
    {
        int index = items.IndexOf(item);
        if (index < 0) return false;
        RemoveItem(index);
        return true;
    }

    void IList.Remove(object? value)
    {
        if (IsCompatibleObject(value))
        {
            Remove((T)value!);
        }
    }

    public void RemoveAt(int index)
    {
        RemoveItem(index);
    }

    protected virtual void ClearItems()
    {
        items.Clear();
    }

    protected virtual void InsertItem(int index, T value)
    {
        if (value is T item)
        {
            items.Insert(index, item);
        }
    }

    protected virtual void RemoveItem(int index)
    {
        items.RemoveAt(index);
    }

    protected virtual void SetItem(int index, T item)
    {
        items[index] = item;
    }

    private static bool IsCompatibleObject(object? value)
    {
        return (value is T) || (value == null && default(T) == null);
    }

    private void OnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
    {
        CollectionChanged?.Invoke(this, args);
    }
}
