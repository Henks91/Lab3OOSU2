using Business.Classes;
using BusinessLayer;
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

namespace PresentationsLager.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kontroller kontroller;
        Expidit exp { get; set; }
        private bool IsNotModified = true;
        public MainWindow()
        {
            InitializeComponent();
            kontroller = new Kontroller();
            kontroller.LaddaData();
        }

       
        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(TextBoxAnstNr.Text);
            string password = TextBoxLösen.Password;
            exp = kontroller.Inloggning(id, password);

            if (exp != null)
            {
                this.Hide();
                //NÄsta sida ska öppnas här
                HuvudMeny huvudMeny = new HuvudMeny(exp);
                huvudMeny.Show();
            }
            else
            {
                MessageBox.Show("Du har anget fel information");
            }
        }

        private void BtnAvsluta_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TextBoxAnstNr_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
