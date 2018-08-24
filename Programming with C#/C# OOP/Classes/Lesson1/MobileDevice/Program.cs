using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileDevice Nokia = new MobileDevice("Nokia", "Lumia 650", 99, "Mtel",
                new Display(30, 10000), new Battery());

            //MobileDevice Samsung = new MobileDevice("Samsung", "S600", 199, "Globul",
            //    new Display(10, 10000), new Battery("Samsung LongLiveBattery", 20, 5));

            Console.WriteLine(Nokia);

            //Console.WriteLine(Samsung);

            Nokia.AddCall("0876253132", 120);
            Nokia.AddCall("0876253452", 22);
            Nokia.AddCall("0876245555", 42);
            Nokia.AddCall("0876356565", 52);
            Nokia.RemoveCall(1);
            Nokia.CallHistory();
            Nokia.AllCallsPrice();
            Console.WriteLine("Total Call Price: {0}", Nokia.AllCallsPrice());
        }
    }

    class MobileDevice
    {
        private const int defaultPrice = 0;
        private const string defaultOwner = "Stock";
        private string brand;
        private string model;
        private int price;
        private string owner;
        private Display display;
        private Battery battery;

        private List<Call> callHistory;
        private double fixedCallPrice = 1.5;

        public MobileDevice(string brand, string model)
            : this(brand, model, defaultPrice, defaultOwner, new Display(), new Battery())
        {

        }

        public MobileDevice(string brand, string model, int price, string owner, Display display, Battery battery)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.owner = owner;
            this.display = display;
            this.battery = battery;
            this.callHistory = new List<Call>();
        }

        public string GetSetBrandName
        {
            get
            {
                return this.brand;
            }
            set
            {
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Model can not be null or empty.");
                    }
                    this.brand = value;
                }

            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("- - - - - -\nMobile Device Information: ");
            result.Append(string.Format("\n Brand: {0}\n Model: {1}\n Owner: {2}\n Price: {3}\n",
                this.brand, this.model, this.owner, this.price));
            result.Append(this.battery);
            result.Append(this.display);
            return result.ToString();
        }

        public void AddCall(string number, int duration)
        {
            callHistory.Add(new Call(number, duration));
        }

        public void RemoveCall(int index)
        {
            callHistory.RemoveAt(index);
        }

        public void CallHistory()
        {
            foreach (Call singleCall in callHistory)
            {
                Console.WriteLine(singleCall);
            }
        }

        public double AllCallsPrice()
        {
            double totalCallPrice = 0;

            foreach (Call singleCall in callHistory)
            {
                totalCallPrice += (singleCall.GetCallDuration() * fixedCallPrice);
            }
            return totalCallPrice;
        }
    }
}