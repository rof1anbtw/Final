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
    /// <summary>
    /// Логика взаимодействия для UserRoleWindow.xaml
    /// </summary>
    public partial class UserRoleWindow : Window
    {
        ComputersTableAdapter computers = new ComputersTableAdapter();
        FoodTableAdapter food = new FoodTableAdapter(); 
        Events_TableAdapter events = new Events_TableAdapter();
        RatesTableAdapter rates = new RatesTableAdapter();
        public UserRoleWindow()
        {
            InitializeComponent();
            CompInfo.ItemsSource = computers.GetData();
            FoodInfo.ItemsSource = food.GetData();
            EventsInfo.ItemsSource = events.GetData();
            RatesInfo.ItemsSource = rates.GetData();
        }

    }
}
