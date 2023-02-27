using BusinessLayer;
using Business.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Återlämning : Form
    {
        Expidit exp { get; set; }
        Kontroller kontroller;
        public Återlämning(Expidit exp)
        {
            InitializeComponent();
            this.exp = exp;
            kontroller = new Kontroller();
        }
        #region BakåtFrånÄterlämning
        /// <BakåtFrånÅterlämning>
        /// När man lämnat tillbaka en bokning i GUI fönstret "Återlämning" 
        /// och vill gåtillbaka till menyn via Bakåt-knappen.
        /// Denna knappen kallar på metoden att visa menyn.
        /// </BakåtFrånÅterlämning>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBakåtFrånÅterlämning_Click(object sender, EventArgs e)
        {
            Meny meny = new Meny(exp);
            meny.Show();
            Visible = false;
        }
        #endregion BakåtFrånÄterlämning

        #region ÅterlämnaBokning
        /// <ÅterlämnaBokning>
        /// Knappen trycks på när användaren vill lämna tillbaka sin bokning.
        /// Ett bokningsnummer matas in som matchas in i metoden HämtaBokningensBöcker 
        /// som ligger i Kontroller.cs. Sedan skapas en faktura som retuneras till användaren.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonÅterlämnaBokning_Click(object sender, EventArgs e)
        {
            
            int bNr = int.Parse(textBox1.Text);
            dataGridView3.DataSource = kontroller.HämtaBokningensBöcker(bNr);
            List<Faktura> faktura = kontroller.SkapaFaktura(exp, bNr);
            if (faktura != null)
            {
                listBox1.DataSource = faktura;
            }
            else
            {
                MessageBox.Show("Du har redan återlämnat denna bokning!");
            }
        }
        #endregion ÅterLämnaBokning

        //Formatering för Listbox3
        private void listBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            int FakturaId = ((Faktura)e.ListItem).FakturaId;
            string Namn = ((Faktura)e.ListItem).Expidit.Namn;
            int TotalPris = ((Faktura)e.ListItem).TotalPris;
            DateTime FaktiskÅterLån = ((Faktura)e.ListItem).FaktiskÅterTid;

            e.Value = "Faktura Id: " + FakturaId + "   " + "Expidit namn: " + Namn + "   " + "Pris: " + TotalPris + "   " + "Återlämnad" + FaktiskÅterLån;
        }
    }
}
