﻿namespace Playground2.Behavioral.Observer.ClearImplementation
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    public class GoogleStock : Stock
    {
        public GoogleStock(double initialPrice)
            : base("GOOG", initialPrice)
        {
        }
    }
}
