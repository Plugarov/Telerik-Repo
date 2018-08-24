namespace WarMachines.Engine
{
    using WarMachines.Interfaces;
    using WarMachines.Machines;

    public class MachineFactory : IMachineFactory
    {
        public IPilot HirePilot(string name)
        {
            return new Pilot(name);
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            return new Fighter(name, attackPoints, defensePoints, stealthMode);
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            return new Tank(name, attackPoints, defensePoints);
        }
    }
}
