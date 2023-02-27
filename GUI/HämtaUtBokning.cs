using Business.Classes;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class HämtaUtBokning : Form
    {
        Bokning bokning1 { get; set; }
        Expidit exp { get; set; }
        Kontroller kontroller = new Kontroller();
        public HämtaUtBokning(Expidit exp)
        {
            InitializeComponent();
            this.exp = exp;
        }

        #region BakåtFrånUtlämning
        /// <BakåtFrånUtlämning>
        /// När man hämtat ut en bokning i GUI fönstret "Utlämninig" 
        /// och vill gåtillbaka till menyn via Bakåt-knappen.
        /// Denna knappen kallar på metoden att visa menyn.
        /// </BakåtFrånUtlämning>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBakåtFrånUtlämning_Click(object sender, EventArgs e)
        {
            Meny meny = new Meny(exp);
            meny.Show();
            Visible = false;
        }
        #endregion BakåtFrånUtlämning

        #region VisaBokning
        /// <VisaBokning>
        /// En knapp som i fönstret listar upp bokningarna via ett bokningsnummer.
        /// En metod för att hämta bokningar via kontroller.cs listar upp detta i 
        /// dataGrid1View1. 
        /// </VisaBokning>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVisaBokning_Click(object sender, EventArgs e)
        {
            int bNr = int.Parse(textBox1.Text);
            Bokning bokning = kontroller.HämtaBokning(bNr);
            bokning1 = bokning;
            if (bokning != null)
            {
                dataGridView1.DataSource = kontroller.HämtaBokningensBöcker(bNr);
                
            }
            else 
            {
                MessageBox.Show("Du har skrivit fel bokningsnummer eller medelemsnummer" + "\n" +
                    "försök igen");
                
            }
            
        }
        #endregion VisaBokning

        #region HämtaBokning
        /// <HämtaBokning>
        /// Knappen trycks på när man bekräftar sin uthämning av bokningen. 
        /// Detta listas upp och presenteras i dataGridView1.
        /// </HämtaBokning>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHämtaBokning_Click(object sender, EventArgs e)
        {
            kontroller.HämtaUtBokning(bokning1);
            MessageBox.Show("Du ska lämna tillbaka boken/böckerna den:" + bokning1.ÅterTid);
            int bNr = int.Parse(textBox1.Text);
            dataGridView1.DataSource = kontroller.HämtaBokning(bNr);

            textBox1.Clear();


        }
        #endregion HämtaBokning
    }
}
