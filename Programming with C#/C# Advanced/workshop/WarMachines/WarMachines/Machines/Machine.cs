namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private IPilot pilot;
        private string name;
        private double attackPoints;
        private double defensePoints;
        private double healthPoints;

        private IEnumerable<string> targets;

        public Machine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.checkIfNullOrEmpty(value);
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                Validator.checkIfNullObj(value);
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                Validator.checkIfPositive(value);
                this.healthPoints = value;
            }
        }

        public IList<string> Targets
        {
            get
            {
                return new List<string>(this.targets);
            }
        }

        public double AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                this.attackPoints = value;
            }
        }

        public double DefensePoints { get => defensePoints; set => defensePoints = value; }

        public void Attack(string target)
        {
            Validator.checkIfNullOrEmpty(target);
            targets.Add(target);
        }

        public override string ToString()
        {
            return string.Format("- {0} *Type: {1} *Health: {2} *Attack: {3} *Defense: {4} *Targets: {5}",
                this.name + Environment.NewLine,
                this.GetType().Name + Environment.NewLine,
                this.healthPoints + Environment.NewLine,
                this.attackPoints + Environment.NewLine,
                this.defensePoints + Environment.NewLine,
                this.targets.Count > 0
                    ? string.Join(", ", this.targets) + Environment.NewLine
                    : "no" + Environment.NewLine);
        }
    }
}
