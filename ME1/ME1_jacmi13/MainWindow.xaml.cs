﻿using Domain;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Common;
using Domain;

namespace ME1
{
    /// <summary>
    /// <author>Jens Schwee & Jacob Michelsen</author>
    /// <date>14/09/2015</date>
    /// </summary>
    public partial class MainWindow : Window
    {
        private CustomerManager CustomerManager = new CustomerManager();
        private ContractManager ContractManager = new ContractManager();
        private CarManager CarManager = new CarManager();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void registerBusinessHandler(object sender, RoutedEventArgs e)
        {
            CustomerManager.RegisterBusinessCustomer(txtBusinessFax.Text, txtBusinessCompanyname.Text, txtBusinessContactPerson.Text, txtBusinessCVR.Text,
                                                        txtBusinessPersonName.Text, txtBusinessPhone.Text, txtBusinessAddress.Text, txtBusinessCity.Text,
                                                        txtBusinessZipcode.Text, txtBusinessCountry.Text);
        }

        private void registerPrivateCustomerHandler(object sender, RoutedEventArgs e)
        {
            CustomerManager.RegisterPrivateCustomer(txtPrivateAge.Text, txtPrivateSex.Text, txtPrivateName.Text, txtPrvatePhone.Text, txtPrivateAddress.Text,
                                                        txtPrivateCity.Text, txtPrivateZipcode.Text, txtPrivateCountry.Text);
        }

        private void registerCarHandler(object sender, RoutedEventArgs e)
        {
            if (radioRegisterCar.IsChecked == true)
            {
                Console.Out.WriteLine("Test");
                CarManager.RegisterCar(txtRegisterModel.Text, Double.Parse(txtRegisterPrice.Text), txtRegsiterColor.Text);
                Console.Out.WriteLine("Test2");
            }
            else
                CarManager.RegisterTruckCar(txtRegisterModel.Text, Double.Parse(txtRegisterPrice.Text), txtRegsiterColor.Text);
        }
    }
}
