using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TermProject.Business_Logic
{
    public class Pizza : INotifyPropertyChanged
    {
        private string _name;
        private string _description;
        private double _price;
        private string _image;
        private int _qty;
        private bool _isAddButtonVisible = true;
        private bool _isQuantityControlsVisible = false;

        public Pizza(string name, string description, double price, string image, int qty)
        {
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            Quantity = qty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Properties

        public string Name
        {
            get { return _name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be empty.");
                }
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return _description; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Description cannot be empty.");
                }
                _description = value;
                OnPropertyChanged();
            }
        }

        public string Image
        {
            get { return _image; }
            set
            {
                _image = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        public int Quantity
        {
            get { return _qty; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid Quantity. Quantity should be greater than or equal to 0.");
                }
                _qty = value;
                OnPropertyChanged();
            }
        }

        public bool IsAddButtonVisible
        {
            get { return _isAddButtonVisible; }
            set
            {
                _isAddButtonVisible = value;
                OnPropertyChanged();
            }
        }

        public bool IsQuantityControlsVisible
        {
            get { return _isQuantityControlsVisible; }
            set
            {
                _isQuantityControlsVisible = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public override string ToString()
        {
            return Name;
        }
    }
}
