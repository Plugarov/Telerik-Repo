namespace Playground2.LazyInitialization
{
    using Playground2.Creational.LazyInitialization;
    using Playground2.Creational.LazyInitialization.VirtualProxy;
    using System;
    using System.IO;

    public static class LazyInitializationMain
    {
        public static void Run()
        {
            var lazyFactoryObject = new LazyFactoryObject();
            var list = lazyFactoryObject.GetLazyFactoryObject(LazyObjectType.Big);
            Console.WriteLine(list.Result.Count);

            Console.WriteLine(new string('-', 60));

            var lazyInit = new Lazy<StreamReader>(() => new StreamReader("LazyInitialization.exe.config"));
            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {
                var result = lazyInit.Value.ReadToEnd();
                Console.WriteLine(result);
            }

            Console.WriteLine(new string('-', 60));
            var db = new DataContext();
            var user = db.GetUserById(1337);
            Console.WriteLine(user.Roles.Count);
        }
    }
}
