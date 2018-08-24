using System;

using Playground2.ObjectPool;

namespace Playground2.Creational.ObjectPool
{
    public static class ObjectPoolMain
    {
        public static void Run()
        {
            // https://www.infoworld.com/article/3221392/application-development/how-to-use-the-object-pool-design-pattern-in-c.html

            ObjectPool<MyClass> objPool = new ObjectPool<MyClass>();
            MyClass obj = objPool.Get();
            objPool.Release(obj);
            Console.Read();
        }
    }
}
