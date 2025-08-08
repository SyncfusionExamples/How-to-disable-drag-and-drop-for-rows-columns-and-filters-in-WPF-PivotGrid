using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PivotGridDemo
{
    public class ProductSales : INotifyPropertyChanged
    {
        private string product;
        private string date;
        private string country;
        private string state;
        private int quantity;
        private double amount;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Product
        {
            get { return product; }
            set { product = value; OnPropertyChanged(nameof(Product)); }
        }
        public string Date
        {
            get { return date; }
            set { date = value; OnPropertyChanged(nameof(Date)); }
        }
        public string Country
        {
            get { return country; }
            set { country = value; OnPropertyChanged(nameof(Country)); }
        }
        public string State
        {
            get { return state; }
            set { state = value; OnPropertyChanged(nameof(State)); }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; OnPropertyChanged(nameof(Quantity)); }
        }
        public double Amount
        {
            get { return amount; }
            set { amount = value; OnPropertyChanged(nameof(Amount)); }
        }        

        public static ProductSalesCollection GetSalesData()
        {
            /// Geography
            string[] countries = new string[] 
            {
             "Canada"
            };
            string[] canadaStates = new string[] 
            {
             "Alberta",
             "British Columbia",
             "Ontario"
            };
            /// Time
            string[] dates = new string[] 
            {
             "FY 2005",
             "FY 2006",
             "FY 2007"
            };
            /// Products
            string[] products = new string[] 
            {
             "Bike",
             "Car"
            };
            Random r = new Random(123345345);
            int numberOfRecords = 2000;
            ProductSalesCollection listOfProductSales = new ProductSalesCollection();
            for (int i = 0; i < numberOfRecords; i++)
            {
                ProductSales sales = new ProductSales();
                sales.Country = countries[r.Next(0, countries.GetLength(0))];
                sales.Quantity = r.Next(1, 12);
                /// 1 percent discount for 1 quantity
                double discount = (30000 * sales.Quantity) * (double.Parse(sales.Quantity.ToString()) / 100);
                sales.Amount = (30000 * sales.Quantity) - discount;
                sales.Date = dates[r.Next(r.Next(dates.GetLength(0) + 1))];
                sales.Product = products[r.Next(r.Next(products.GetLength(0) + 1))];
                sales.State = canadaStates[r.Next(canadaStates.GetLength(0))];
                listOfProductSales.Add(sales);
            }
            return listOfProductSales;
        }        
        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", this.Country, this.State, this.Product);
        }
        public class ProductSalesCollection : List<ProductSales>
        {

        }
        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
