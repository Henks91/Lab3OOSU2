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
            Bokning bokningen = new Bokning(exp)
        }
    }
}
