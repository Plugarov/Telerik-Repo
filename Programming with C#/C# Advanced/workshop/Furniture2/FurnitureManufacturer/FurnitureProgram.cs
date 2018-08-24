namespace FurnitureManufacturer
{
    using Engine;

    //  BELOW  IS TEMP
    using System;
    using FurnitureManufacturer.Interfaces;
    using FurnitureManufacturer.Models;

    public class FurnitureProgram
    {
        public static void Main()
        {
            FurnitureManufacturerEngine.Instance.Start();

            //IChair c = new Chair("one", "wooden", 10, 10, 4);
            //ITable t = new Table("one", "wooden", 10, 10, 10, 5);
            //IConvertibleChair z = new ConvertibleChair("one", "wooden", 10, 10, 10);
            //IAdjustableChair ac = new AdjustableChair("one", "wooden", 10, 10, 4);
            //IConvertibleChair cc = new ConvertibleChair("one", "wooden", 10, 10, 4);
            //IFurniture f = new Furniture("asd", "asd", 10, 10);
            //ICompany co = new Company("La", "100");
            //co.Add(c);
            //co.Add(t);
            //co.Add(z);
            //Console.WriteLine(co.Catalog());

        }
    }
}
