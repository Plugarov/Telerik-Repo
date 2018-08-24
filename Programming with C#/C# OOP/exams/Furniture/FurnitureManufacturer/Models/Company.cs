namespace FurnitureManufacturer.Models
{
    using System.Linq;
    using System.Collections.Generic;
    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private List<IFurniture> models;

        public Company(string name, string registrationNumber)
        {
            Validator.CheckStringNameMinRequirements(name, 5);
            this.name = name;
            //TODO validation min length
            //Validator.CheckInputLength(registrationNumber);
            this.registrationNumber = registrationNumber;
            this.models = new List<IFurniture>();
        }

        public string Name { get; }

        public string RegistrationNumber { get; }

        public ICollection<IFurniture> Furnitures
        {
            get { return this.models; }
        }

        public void Add(IFurniture furniture)
        {
            models.Add(furniture);
        }

        public string Catalog()
        {
            StringBuilder items = new StringBuilder();
            List<IFurniture> models = 
                this.models
                .OrderBy(x => x.Price)
                .ThenBy(x => x.Model)
                .ToList();

            foreach (IFurniture item in models)
            {
                items.Append(item.ToString());
            }


            return string.Format("{0} - {1} - {2} {3}{4}",
                this.name,
                this.registrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture",
                items);
        }

        public IFurniture Find(string model)
        {
            return this.models.Find(x => x.Model.ToUpper() == model.ToUpper());
        }

        public void Remove(IFurniture furniture)
        {
            for (int i = 0; i < this.models.Count; i++)
            {
                if (this.models[i].Equals(furniture))
                {
                    this.models.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
