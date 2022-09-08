using CCSAWpfDemo.ViewModels;
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

namespace CCSAWpfDemo
{
    /// <summary>
    /// Interaction logic for CustomerInfo.xaml
    /// </summary>
    public partial class CustomerInfo : Window
    {
        public CustomerInfo(CustomerInfoViewModel customerInfoViewModel)
        {
            InitializeComponent();
            _viewModel = customerInfoViewModel;
            DataContext = _viewModel;
        }

        private CustomerInfoViewModel _viewModel { get; set; }


        private void Add_Customer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Text = txtLastName.Text = "";
        }
    }
}
