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
        private ObservableCollection<Pizza> _pizzas = new ObservableCollection<Pizza>()
        {
            new Pizza("Pizza 1", "...", 7.45),
            new Pizza("Pizza 2","...", 6.80),
            new Pizza("Pizza 3","...", 8.25),
            new Pizza("Pizza 4","...", 9.75),
            new Pizza("Pizza 5","...", 5.55),
            new Pizza("Pizza 6","...", 6.15),
        };

        private ObservableCollection<Pizza> _selectedPizzas = new ObservableCollection<Pizza>();

        public ObservableCollection<Pizza> Pizzas
        {
            get { return _selectedPizzas; }
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
