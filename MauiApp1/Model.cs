using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class Model : INotifyPropertyChanged
    {
        private string _orderId;
        private string _customerId;
        private string _customer;
        private string _city;
        private string _country;

        public event PropertyChangedEventHandler? RecordePropertyChanged;
        public event PropertyChangedEventHandler? PropertyChanged;

        public string OrderId
        {
            get { return _orderId; }
            set
            {
                _orderId = value;
                RecordePropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OrderId)));
            }
        }
        public string CustomerId { get { return _customerId; } set { _customerId = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomerId))); } }
        public string Customer { get { return _customer; } set { _customer = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Customer))); } }
        public string City { get { return _city; } set { _city = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(City))); } }
        public string Country { get { return _country; } set { _country = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Country))); } }
        
        public Model(string orderId, string customerID, string customer, string city, string country)
        {
            OrderId = orderId;
            CustomerId = customerID;
            Customer = customer;
            City = city;
            Country = country;
        }
    }
}
