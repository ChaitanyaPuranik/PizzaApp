using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject.Business_Logic
{
    public class Bill
    {
        Manager _manager;

        public Bill(Manager manager)
        {
            _manager = manager;
        }

        public double ItemsPrice
        {
            get
            {
                double prices = 0;
                foreach (Pizza pizza in _manager.SelectedPizzas)
                {
                    prices += pizza.Price;
                }
                return prices;
            }
        }

        public double HST
        {
            get { return Math.Round(ItemsPrice * 0.13, 2); }
        }

        public double TotalPrice
        {
            get { return Math.Round(HST + ItemsPrice, 2); }
        }
    }
}
