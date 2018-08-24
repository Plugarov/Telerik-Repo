namespace WarMachines.Machines
{
    using System;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IMachine, IFighter
    {
        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints, 200)
        {
            this.stealthMode = stealthMode;
        }

        public bool StealthMode
        {
            get
            {
                return this.stealthMode;
            }
        }

        public void ToggleStealthMode()
        {
            this.stealthMode = !this.stealthMode;
        }
    }
}
