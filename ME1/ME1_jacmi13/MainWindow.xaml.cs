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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // CustomerManager til registering af private- og forretningskunder
        private CustosmerManager CustomerManager = new CustosmerManager();
        private ContractManager ContractManager = new ContractManager();
        private CarManager CarManager = new CarManager();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void registerBusinessHandler(object sender, RoutedEventArgs e)
        {
            // opret en forretningskunde med hans oplysninger
            // sæt variaberne på objektet og send objektet ned mod dmoænelaget og domænelaget sender det ned mod foundation-laget
            CustomerManager.RegisterBusinessCustomer(txtBusinessFax.Text, txtBusinessCompanyname.Text, txtBusinessContactPerson.Text, txtBusinessCVR.Text,
                                                        txtBusinessPersonName.Text, txtBusinessPhone.Text, txtBusinessAddress.Text, txtBusinessCity.Text, 
                                                        txtBusinessZipcode.Text, txtBusinessCountry.Text);
        }
    }
}
