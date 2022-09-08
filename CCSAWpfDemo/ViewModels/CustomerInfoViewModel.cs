using CCSAWpfDemo.Models;
using CCSAWpfDemo.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CCSAWpfDemo.ViewModels
{
    public class CustomerInfoViewModel : ValidationViewModelBase
    {
        public CustomerInfoViewModel(CustomerService customerService, DummyService dummyService)
        {
            CustomerService = customerService;
            var customers = CustomerService.GetCustomers();
            customers.ForEach(customer => Customers.Add(customer));
        }

        public CustomerService CustomerService { get; private set; }

        public ObservableCollection<Customer> Customers { get; set; } = new();

        private Customer selectedCustomer;
        public Customer SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                FirstName = value.FirstName;
                RaisePropertyChanged(nameof(SelectedCustomer));
            }
        }

        private bool _listViewIsVisible;

        public bool ListViewIsVisible
        {
            get { return _listViewIsVisible; }
            set { _listViewIsVisible = value; RaisePropertyChanged(); }
        }


        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set 
            { 
                _firstName = value; 
                RaisePropertyChanged();
                if (string.IsNullOrEmpty(_firstName))
                {
                    AddError(nameof(FirstName), "First name required");
                }
                else
                {
                    ClearErrors(nameof(FirstName));
                }
            }
        }

        public List<Gender> Genders => new List<Gender> { Gender.Male, Gender.Female };
    }
}
