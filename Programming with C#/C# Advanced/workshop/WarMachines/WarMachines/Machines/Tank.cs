namespace WarMachines.Machines
{
    using System;
    using WarMachines.Interfaces;

    public class Tank : Machine, IMachine, ITank
    {
        private bool defenceMode;
        private const int changeAttackPoints = 40;
        private const int changeDefencePoints = 30;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, 200)
        {
            this.defenceMode = true;
            ToggleDefenseMode();
        }

        public bool DefenseMode
        {
            get
            {
                return this.defenceMode;
            }
        }

        public void ToggleDefenseMode()
        {
            this.defenceMode = !this.defenceMode;
            if (!this.defenceMode)
            {
                this.DefensePoints += changeDefencePoints;
                this.AttackPoints -= changeAttackPoints;
            }
            else
            {
                this.DefensePoints -= changeDefencePoints;
                this.AttackPoints += changeAttackPoints;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} *Defence: {1}{2}", 
                base.ToString(), 
                this.defenceMode 
                ? "ON" 
                : "OFF", 
                Environment.NewLine);
        }
    }
}
