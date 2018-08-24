namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public Pilot(string name)
        {
            this.name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public void AddMachine(IMachine machine)
        {
            Validator.checkIfNullObj(machine);
            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            string name = this.name;
            string numberOfMachines =
                this.machines.Count > 0
                ? this.machines.Count + ""
                : "no";
            string ending =
                this.machines.Count > 1
                ? "machines"
                : "machine";
            List<IMachine> units = 
                this.machines
                .OrderBy(x => x.HealthPoints)
                .ThenBy(x => x.Name)
                .ToList();

            result.AppendFormat("{0} - {1} {2}\n{3}", 
                name, numberOfMachines, 
                ending, 
                string.Join("", units));

            return result.ToString();
        }
    }
}
