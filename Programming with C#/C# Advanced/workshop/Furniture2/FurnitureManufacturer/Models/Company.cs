namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class Company : ICompany
    {
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name { get; }

        public string RegistrationNumber { get; }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return new List<IFurniture>(this.furnitures);
            }
        }


        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public string Catalog()
        {
            StringBuilder items = new StringBuilder();

            foreach (IFurniture item in this.furnitures)
            {
                items.Append(item.ToString());
            }

            return string.Format("{0} - {1} - {2} {3}{4}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture",
                items);

        }

        public IFurniture Find(string model)
        {
            throw new NotImplementedException();
        }

        public void Remove(IFurniture furniture)
        {
            throw new NotImplementedException();
        }
    }
}
