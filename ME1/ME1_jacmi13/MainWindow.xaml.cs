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

namespace ME1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void registerBusinessHandler(object sender, RoutedEventArgs e)
        {
            // 1. indlæs værdierne fra textfields
            // 2. gem dem i variable
            // 3. send objektet ned mod databasen
            
            Business b = new Business();
            // sæt variaberne på objektet og send objektet ned mod dmoænelaget og domænelaget sender det ned mod foundation-laget

            String BusinessNameFieldTest = BusinessNameField.Text;
            b.CVR = BusinessNameFieldTest;
            // evt. lav en domæne/klasse-manager på domænet, som har alle metoder, og den manager har så referencer til alle klasser
            // smid objektet videre ned i lagene
            b.RegisterBusiness(b);
            

            Console.WriteLine(BusinessNameFieldTest);
        }
    }
}
