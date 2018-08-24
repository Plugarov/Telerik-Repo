using Playground2.Behavioral.Observer.ClearImplementation;
using Playground2.Behavioral.Observer.DotNetEvents;
using System;

namespace Playground2.Behavioral.Observer
{
    public static class Observer
    {
        public static void Run()
        {
            ClearImplementationExample();
            Console.WriteLine(new string('-', 60));
            DotNetEventsExample();
        }

        private static void ClearImplementationExample()
        {
            // Create stocks and attach investors
            var sorrosInvestor = new SorrosInvestor();
            var berkshireInvestor = new BerkshireInvestor();

            var ibmStock = new IbmStock(120.00);
            ibmStock.Attach(sorrosInvestor);
            ibmStock.Attach(berkshireInvestor);

            var googleStock = new GoogleStock(200.00);
            googleStock.Attach(sorrosInvestor);
            googleStock.Attach(berkshireInvestor);

            // Fluctuating prices will notify investors
            ibmStock.Price = 120.10;
            ibmStock.Price = 121.00;
            ibmStock.Detach(sorrosInvestor);
            ibmStock.Price = 120.50;
            ibmStock.Price = 120.75;
            googleStock.Price = 202.00;
        }

        private static void DotNetEventsExample()
        {
            var ibm = new ObservableStock("IBM", 120.00);
            ibm.StockPriceChanged += ObservableStockOnStockPriceChanged;
            ibm.StockPriceChanged +=
                (sender, stockPriceChangedEventArgs) =>
                    Console.WriteLine(
                    "Anonymous method notified of {0}'s " + "change to {1:C}",
                        stockPriceChangedEventArgs.Stock.Symbol,
                        stockPriceChangedEventArgs.Stock.Price);

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
            ibm.Price = 110.75;
        }

        private static void ObservableStockOnStockPriceChanged(
            object sender,
            StockPriceChangedEventArgs stockPriceChangedEventArgs)
        {
            Console.WriteLine(
                "Named method notified of {0}'s " + "change to {1:C}",
                stockPriceChangedEventArgs.Stock.Symbol,
                stockPriceChangedEventArgs.Stock.Price);
        }
    }
}
