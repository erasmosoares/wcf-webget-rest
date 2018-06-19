using ContentType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;


namespace CoffeemanagerService
{
    [ServiceBehavior]
    public class CoffeeService : ICoffeeService
    {
        private List<Coffee> _coffee;
        internal List<Coffee> Storage
        {
            get
            {
                this._coffee = this._coffee ?? this.LoadList();
                return this._coffee;
            }
        }

        private List<Coffee> LoadList()
        {
            List<Coffee> cList = new List<Coffee>();
            cList.Add(new Coffee { Id = 1, Title = "Café São Bráz", Description = "Forte e encorpado", Date = DateTime.UtcNow, Url = "www.cafe.com" });
            cList.Add(new Coffee { Id = 2, Title = "Café Maratá", Description = "Fraco e aromatizado", Date = DateTime.UtcNow, Url = "www.cafe.com" });

            return cList;
        }

        public List<Coffee> GetAllCoffees()
        {
            return this.Storage;
        }

        public Coffee GetCoffee(string id)
        {
            return this.Storage.FirstOrDefault(item => item.Id.ToString().Equals(id));
        }

        public bool RemoveCoffee(string id)
        {
            var currentCoffee = this.Storage.Where(item => item.Id.ToString().Equals(id));

            if (currentCoffee.Count() <= 0)
                return false;

            foreach (Coffee coffee in currentCoffee)
                this.Storage.Remove(coffee);

            return true;
        }

        public bool SaveCoffee(Coffee currentCoffee)
        {
            if (this.Storage.Any(item => item.Id == currentCoffee.Id))
                return false;
            this.Storage.Add(currentCoffee);
            return true;
        }
    }
}
