namespace Computers.Components.HardDrives
{
    using System.Collections.Generic;

    using Computers.Interfaces;
    
    public class HardDriver : IHardDrive
    {
        private int capacity;
        private Dictionary<int, string> data;

        public HardDriver(int capacity)
        {
            this.Capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            private set
            {
                this.capacity = value;
            }
        }

        public void SaveData(int addr, string newData)
        {
            this.data[addr] = newData;
        }

        public string LoadData(int address)
        {
            return this.data[address];
        }
    }
}