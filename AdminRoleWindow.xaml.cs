using PRAKTIK5.prak5DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PRAKTIK5
{
    public partial class AdminRoleWindow : Window
    {
        FoodTableAdapter food = new FoodTableAdapter();
        
        public AdminRoleWindow()
        {
            InitializeComponent();
            FoodDataGrid.ItemsSource = food.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            food.InsertQuery(FoodTbx.Text,Convert.ToDecimal(Pricetbx.Text),Descriptiontbx.Text);
            FoodDataGrid.ItemsSource = food.GetData();
        }
    }
}
