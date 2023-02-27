using Business.Classes;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PresentationsLager.WPF
{
    /// <summary>
    /// Interaction logic for HuvudMeny.xaml
    /// </summary>
    public partial class HuvudMeny : Window
    {
        Kontroller kontroller;
        Expidit exp { get; set; }
        public HuvudMeny(Expidit exp)
        {
            InitializeComponent();
            kontroller = new Kontroller();
        }

        private void BtnBokaBok_Click(object sender, RoutedEventArgs e)
        {
            HuvudMeny huvudMeny = new HuvudMeny(exp);
            SkapaBokning bokning = new SkapaBokning(exp);
            bokning.Show();
            huvudMeny.Close(); // fixxxa så fönstret bakom försvinner
        }

        private void BtnHämtaBokning_Click(object sender, RoutedEventArgs e)
        {
            HämtaUtBokning hämtaUtBokning = new HämtaUtBokning();
            hämtaUtBokning.Show();
        }

        private void BtnÅterlämning_Click(object sender, RoutedEventArgs e)
        {
            Återlämning återlämning = new Återlämning();
            återlämning.Show();
        }

        private void BtnLoggaUt_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
