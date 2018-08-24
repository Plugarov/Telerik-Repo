using System;
using System.Collections.Generic;

namespace Playground2.Structural.Adapter
{
    // Making class more portable, ignore unnecessary properties and methods
    // Adapt only the most important ones. 
    // Making it simple, with cel readability

    internal class RichCompound : ICompound
    {
        private readonly string chemical;

        private readonly float boilingPoint;
        private readonly float meltingPoint;
        private readonly double molecularWeight;
        private readonly string molecularFormula;

        public RichCompound(string chemical)
        {
            this.chemical = chemical;
            var bank = new ChemicalDatabank();

            this.boilingPoint = bank.GetCriticalPoint(this.chemical, "B");
            this.meltingPoint = bank.GetCriticalPoint(chemical, "M");
            this.molecularWeight = bank.GetMolecularWeight(chemical);
            this.molecularFormula = bank.GetMolecularStructure(chemical);
        }

        public void Display()
        {
            Console.WriteLine("Compound: {0} ------ ", this.chemical);
            Console.WriteLine(" Formula: {0}", this.molecularFormula);
            Console.WriteLine(" Weight : {0}", this.molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", this.meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", this.boilingPoint);
            Console.WriteLine();
        }
    }

    internal interface ICompound
    {
    }

    internal class ChemicalDatabank
    {
        // The databank 'legacy API'
        public float GetCriticalPoint(string compound, string point)
        {
            if (point == "M")
            {
                // Melting Point
                switch (compound.ToLower())
                {
                    case "water":
                        return 0.0f;
                    case "benzene":
                        return 5.5f;
                    case "ethanol":
                        return -114.1f;
                    default:
                        return 0f;
                }
            }
            else
            {
                // Boiling Point
                switch (compound.ToLower())
                {
                    case "water":
                        return 100.0f;
                    case "benzene":
                        return 80.1f;
                    case "ethanol":
                        return 78.3f;
                    default:
                        return 0f;
                }
            }
        }

        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "water":
                    return "H20";
                case "benzene":
                    return "C6H6";
                case "ethanol":
                    return "C2H5OH";
                default:
                    return string.Empty;
            }
        }

        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "water":
                    return 18.015;
                case "benzene":
                    return 78.1134;
                case "ethanol":
                    return 46.0688;
                default:
                    return 0d;
            }
        }
    }

}
