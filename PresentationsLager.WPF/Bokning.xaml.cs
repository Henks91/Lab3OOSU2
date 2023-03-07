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
    /// Interaction logic for Bokning.xaml
    /// </summary>
    public partial class Bokning : Window
    {
        private Kontroller kontroller;
        Expidit exp { get; set; }
        private IList<Bok> boks = new List<Bok>();

        public Bokning(exp)
        {
            InitializeComponent();
            kontroller = new Kontroller();
        }

        private void dgTillgängligaBöcker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            kontroller.HämtaTillgängligaBöcker();
        }
        private void dgValdaBöcker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
