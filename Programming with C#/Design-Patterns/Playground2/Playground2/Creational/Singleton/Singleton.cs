using System;

namespace Playground2.Creational.Singleton
{
    public class Singleton
    {
        //
        //The lock keyword ensures that one thread does not enter a 
        //critical section of code while another thread is in the 
        //critical section.If another thread tries to enter a locked 
        //code, it will wait, block, until the object is released.

        private static Singleton instance;

        private static object lockObject = new Object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                // Scenario

                // Why tp use if(instance == null) 
                // 1. First thread enters, reach "instance == null" and creates instance 
                // 2. When second thread enters, there would be already an instance,
                // and there will be no reason to wait on the LOCK point until first
                // thread leaves, so thats why we check for intstance. If there is one,
                // it will automaticly go down.

                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }

                        return instance;
                    }
                }

                return instance;
            }
        }

        public void Log(string input)
        {
            Console.WriteLine(DateTime.Now + " " + input);
        }
    }
}
