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
using Application;

namespace UI
{
    /// <summary>
    /// Interaction logic for NewCustomerWindow.xaml
    /// </summary>
    public partial class NewCustomerWindow : Window
    {
        Controller control = new Controller();

        public NewCustomerWindow()
        {
            InitializeComponent();
        }

       

        private void button_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void CreateCustomer(object sender, RoutedEventArgs e)
        {
            int Id = control.GetCountOfCustomers() + 1;
            control.CreateCustomer(Id, TextboxName.Text, TextboxAddress.Text, TextboxZIP.Text, TextboxCity.Text, TextboxPhone.Text);
        }
    }
}
