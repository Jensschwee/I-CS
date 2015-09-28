using Domain;
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
            ClearTxtBusiness();
        }

        private void ClearTxtBusiness()
        {
            txtBusinessFax.Clear();
            txtBusinessCompanyname.Clear();
            txtBusinessContactPerson.Clear();
            txtBusinessCVR.Clear();
            txtBusinessPersonName.Clear();
            txtBusinessPhone.Clear();
            txtBusinessAddress.Clear();
            txtBusinessCity.Clear();
            txtBusinessZipcode.Clear();
            txtBusinessCountry.Clear();
        }

        private void registerPrivateCustomerHandler(object sender, RoutedEventArgs e)
        {
            CustomerManager.RegisterPrivateCustomer(txtPrivateAge.Text, txtPrivateSex.Text, txtPrivateName.Text, txtPrvatePhone.Text, txtPrivateAddress.Text,
                                                        txtPrivateCity.Text, txtPrivateZipcode.Text, txtPrivateCountry.Text);
            ClearTxtPrivate();
        }

        private void ClearTxtPrivate()
        {
            txtPrivateAge.Clear();
            txtPrivateSex.Clear();
            txtPrivateName.Clear();
            txtPrvatePhone.Clear();
            txtPrivateAddress.Clear();
            txtPrivateCity.Clear();
            txtPrivateZipcode.Clear();
            txtPrivateCountry.Clear();
        }

        private void registerCarHandler(object sender, RoutedEventArgs e)
        {
            if (radioRegisterCar.IsChecked == true)
            {
                try
                {
                    CarManager.RegisterCar(txtRegisterModel.Text, txtRegisterPrice.Text, txtRegsiterColor.Text);
                    ClearTxtCar();

                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Error in input: This is not a price");
                }
            }
            else
            {
                try
                {
                    CarManager.RegisterTruckCar(txtRegisterModel.Text, txtRegisterPrice.Text, txtRegsiterColor.Text);
                    ClearTxtCar();
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Error in input: This is not a price");
                }
            }


        }

        private void ClearTxtCar()
        {
            txtRegisterModel.Clear();
            txtRegisterPrice.Clear();
            txtRegsiterColor.Clear();
        }
    }
}
