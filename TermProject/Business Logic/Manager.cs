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
            new Pizza("Cheese Pizza", "A Pizza topped only with cheese and tomato sauce", 7.45,"pizza_1.png",1),
            new Pizza("Detroit-style Pizza","Thin crust pizza with Californian toppings like figs, baby aruguala and pesto", 6.80, "pizza_2.png", 1),
            new Pizza("Pepperoni Pizza","Lots of cheese topped with crispy, salty round pepperoni", 8.25, "pizza_3.png", 1),
            new Pizza("Pizzeta","Small version of pizza about 3 inches in size and shape", 9.75, "pizza_4.png", 1),
            new Pizza("Margherita Pizza","Pizza made with fresh basil, mozzarella and tomatoes", 5.55, "pizza_5.png", 1),
            new Pizza("Veggie Pizza","Topped with zucchini, bell peppers, sun dried tomatoes with little Parmesan cheese", 6.15, "pizza_6.png", 1),
        };

        private ObservableCollection<Pizza> _selectedPizzas = new ObservableCollection<Pizza>();

        public ObservableCollection<Pizza> Pizzas
        {
            get { return _pizzas; }
        }

        public ObservableCollection<Pizza> SelectedPizzas
        {
            get { return _selectedPizzas; }
        }



        public void AddToOrder(Pizza pizza)
        {
            if(pizza != null && !_selectedPizzas.Contains(pizza)) 
            {
                _selectedPizzas.Add(pizza);
            }
        }

        public void RemoveFromCart(Pizza pizza)
        {
            _selectedPizzas.Remove(pizza);
        }

            
    }
}
