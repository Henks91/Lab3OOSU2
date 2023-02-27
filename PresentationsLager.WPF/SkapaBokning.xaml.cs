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
    public partial class SkapaBokning : Window
    {

        Kontroller kontroller;
        IList<Bok> boks = new List<Bok>();
        List<Bok> valdaBöcker = new List<Bok>();
        private bool isNotModified = true;
        Expidit exp { get; set; }

        public SkapaBokning(Expidit exp)
        {
            InitializeComponent();
            kontroller = new Kontroller();
            UpdateControls();
        }

        private void UpdateControls()  //Fyll i efterhand vad som ska k
        {         
            dgTillgängligaBöcker.IsEnabled = isNotModified;          
            BtnBokaBöcker.IsEnabled = !isNotModified;
            BtnBokaBöcker.IsEnabled = dgValdaBöckerBokning.Items.Count > 0;
        }

        private void dgTillgängligaBöcker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Bok bok = dgTillgängligaBöcker.SelectedItem as Bok;
            //Bokning bokning = dgValdaBöckerBokning.SelectedItem as Bokning;

            //if (true)
            //{

            //}
            
        }
        private void dgValdaBöcker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
        
        private void BtnVisaTillgängligaBöcker_Click(object sender, RoutedEventArgs e)
        {
            boks = kontroller.HämtaTillgängligaBöcker();
            dgTillgängligaBöcker.ItemsSource = boks;
            dgTillgängligaBöcker.DisplayMemberPath = "Titel";

        }

        private void BtnBokaBöcker_Click(object sender, RoutedEventArgs e)
        { 
            Bokning bokning = new Bokning();            
            int bNr = int.Parse(TextBoxMedlemsNr.Text);
            Medlem bokare = kontroller.Hittamedlem(bNr);
            StartTid.SelectedDate = bokning.StartLån;
            //StartTid.SelectedDateFormat = System.Windows.Controls.DatePickerFormat.Short;
            dgValdaBöckerBokning.DataContext = kontroller.SkapaBokning(bokare, exp, bokning.StartLån, valdaBöcker);
        }

        private void BtnLäggTillBok_Click(object sender, RoutedEventArgs e)
        {
            Bok bok = (Bok)dgTillgängligaBöcker.SelectedItem;
            //Bok bok = dgTillgängligaBöcker.SelectedItem as Bok;
            
            valdaBöcker.Add(bok);
            dgValdaBöckerBokning.ItemsSource = null;
            dgValdaBöckerBokning.ItemsSource = valdaBöcker;
            dgValdaBöckerBokning.DisplayMemberPath = "Titel";

        }


    }
}
