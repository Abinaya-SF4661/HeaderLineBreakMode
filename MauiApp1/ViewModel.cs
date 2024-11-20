using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class ViewModel : INotifyCollectionChanged
    {

        private ObservableCollection<Model> _orders;
        public ObservableCollection<Model> Orders { get { return _orders; } set { _orders = value; CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add)); } }
        public event PropertyChangedEventHandler? PropertyChanged;

        void OnPropertChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ViewModel()
        {
            Orders = new ObservableCollection<Model>();
            this.GenerateOrders();
        }

        public event NotifyCollectionChangedEventHandler? CollectionChanged;

        public void GenerateOrders()
        {

            var image = ImageSource.FromResource("DataGridSample.Resources.Images.syncfusion_logo1.png", typeof(Model).GetTypeInfo().Assembly);

            Orders.Add(new Model("1001", "Thomas Hardy", "Sweden", "BERGS", "London"));
            Orders.Add(new Model("1002", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F."));
            Orders.Add(new Model("1003", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F."));
            Orders.Add(new Model("1004", "Thomas Hardy", "UK", "AROUT", "London"));
            Orders.Add(new Model("1005", "Tim Adams", "Sweden", "BERGS", "London"));
            Orders.Add(new Model("1006", "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            Orders.Add(new Model("10011", "Thomas Hardy", "Sweden", "BERGS", "London"));
            Orders.Add(new Model("10012", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F."));
            Orders.Add(new Model("10013", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F."));
            Orders.Add(new Model("10014", "Thomas Hardy", "UK", "AROUT", "London"));
            Orders.Add(new Model("10015", "Tim Adams", "Sweden", "BERGS", "London"));
            Orders.Add(new Model("10016", "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            Orders.Add(new Model("10021", "Thomas Hardy", "Sweden", "BERGS", "London"));
            Orders.Add(new Model("10022", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F."));
            Orders.Add(new Model("10023", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F."));
            Orders.Add(new Model("10024", "Thomas Hardy", "UK", "AROUT", "London"));
            Orders.Add(new Model("10025", "Tim Adams", "Sweden", "BERGS", "London"));
            Orders.Add(new Model("10026", "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            Orders.Add(new Model("1001", "Thomas Hardy", "Sweden", "BERGS", "London"));
            Orders.Add(new Model("1002", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F."));
            Orders.Add(new Model("1003", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F."));
            Orders.Add(new Model("1004", "Thomas Hardy", "UK", "AROUT", "London"));
            Orders.Add(new Model("1005", "Tim Adams", "Sweden", "BERGS", "London"));
            Orders.Add(new Model("1006", "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            Orders.Add(new Model("10011", "Thomas Hardy", "Sweden", "BERGS", "London"));
            Orders.Add(new Model("10012", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F."));
            Orders.Add(new Model("10013", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F."));
            Orders.Add(new Model("10014", "Thomas Hardy", "UK", "AROUT", "London"));
            Orders.Add(new Model("10015", "Tim Adams", "Sweden", "BERGS", "London"));
            Orders.Add(new Model("10016", "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            Orders.Add(new Model("10021", "Thomas Hardy", "Sweden", "BERGS", "London"));
            Orders.Add(new Model("10022", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F."));
            Orders.Add(new Model("10023", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F."));
            Orders.Add(new Model("10024", "Thomas Hardy", "UK", "AROUT", "London"));
            Orders.Add(new Model("10025", "Tim Adams", "Sweden", "BERGS", "London"));
            Orders.Add(new Model("10026", "Hanna Moos", "Germany", "BLAUS", "Mannheim"));

        }
    }
}
