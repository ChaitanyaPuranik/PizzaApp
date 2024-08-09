using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject.Business_Logic
{
    public class Pizza
    {
        private string _name;
        private string _description;
        private double _price;

        public Pizza(string name, string description, double _price)
        {
            Name = name;
            Description = description;
            Price = _price; 
        }
        #region Properties

        public string Name
        {
            get { return _name; }
            private set
            {
                if (value == null || value.Length == 0)
                {
                    throw new Exception("Name cannot be empty.");
                }
                _name = value;
            }
        }

        public string Description
        {
            get { return _description; }
            private set
            {
                if (value == null || value.Length == 0)
                {
                    throw new Exception("Description cannot be empty.");
                }
                _description = value;
            }
        }

        public double Price
        {
            get { return _price; }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Invalid Price. Price should be greater than 0.");
                }
                _price = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return Name;
        }
    }
}

