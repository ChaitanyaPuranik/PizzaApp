using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject.Business_Logic
{
    public class Manager
    {
        private ObservableCollection<Pizza> _pizzas1 = new ObservableCollection<Pizza>()
        {
            new Pizza("Pizza 1", "...", 7.45,"pizza_1.png"),
            new Pizza("Pizza 3","...", 8.25, "pizza_3.png"),
            new Pizza("Pizza 5","...", 5.55, "pizza_5.png"),
        };

        private ObservableCollection<Pizza> _pizzas2 = new ObservableCollection<Pizza>()
        {
            new Pizza("Pizza 2","...", 6.80, "pizza_2.png"),
            new Pizza("Pizza 4","...", 9.75, "pizza_4.png"),
            new Pizza("Pizza 6","...", 6.15, "pizza_6.png"),
        };

        private ObservableCollection<Pizza> _selectedPizzas = new ObservableCollection<Pizza>();

        public ObservableCollection<Pizza> Pizzas1
        {
            get { return _pizzas1; }
        }

        public ObservableCollection<Pizza> Pizzas2
        {
            get { return _pizzas2;}
        }

        public ObservableCollection<Pizza> SelectedPizzas
        {
            get { return _selectedPizzas; }
        }

        public void AddToOrder(Pizza pizza)
        {
            if(pizza != null) 
            {
                _selectedPizzas.Add(pizza);
            }
        }

        public void Remove(Pizza pizza)
        {
            _selectedPizzas.Remove(pizza);
        }

            
    }
}
