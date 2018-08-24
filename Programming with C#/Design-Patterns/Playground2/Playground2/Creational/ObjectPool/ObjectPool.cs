using System.Collections.Concurrent;

namespace Playground2.ObjectPool
{
    public class ObjectPool<T> where T : new()
    {
        private readonly ConcurrentBag<T> items = new ConcurrentBag<T>();

        private int counter = 0;

        private int MAX = 10;

        public void Release(T item)
        {
            if (this.counter < 10)
            {
                items.Add(item);
                this.counter++;
            }
        }

        public T Get()
        {
            T item;
            if (items.TryTake(out item))
            {
                counter--;
                return item;
            }
            else
            {
                item = new T();
                items.Add(item);
                counter++;
                return item;
            }
        }
    }

    internal class MyClass
    {
    }
}
