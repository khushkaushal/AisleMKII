using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AisleMKII
{
    public partial class MainPage : ContentPage
    {
        List<Item> _items = new List<Item>
        {
            new Item {Name="Shampoo", Aisle="Aisle 15"},
            new Item {Name="Chicken", Aisle="Aisle 10"},
            new Item {Name="Fish", Aisle="Aisle 9"},
            new Item {Name="Cereal", Aisle="Aisle 10"}
        };

        public MainPage()
        {
            InitializeComponent();
            BindingContext = _items;
            
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string keyword = searchBox.Text;

            BindingContext = _items.FindAll(x => x.Name.Contains(keyword));
        }
    }
}
