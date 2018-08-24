namespace Computers.Components.HardDrives
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using Computers.Interfaces;

    public class RaidArray : IHardDrive
    {
        private List<HardDriver> hds;

        public RaidArray(List<IHardDrive> hardDrives)
        {
            this.hds = new List<HardDriver>();
        }

        public int Capacity
        {
            get
            {
                if (!this.hds.Any())
                {
                    return 0;
                }

                return this.hds.First().Capacity;
            }
        }

        public string LoadData(int address)
        {
            if (!this.hds.Any())
            {
                throw new OutOfMemoryException("No hard drive in the RAID array!");
            }

            return this.hds.First().LoadData(address);
        }

        public void SaveData(int addr, string newData)
        {
            foreach (var hardDrive in this.hds)
            {
                hardDrive.SaveData(addr, newData);
            }
        }
    }
}
