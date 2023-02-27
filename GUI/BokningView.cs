using Business.Classes;
using Business.Interface;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace GUI
{
    public partial class BokningView : Form
    {
        Expidit exp { get; set; } //Skapar en property av Expidit för att kunna föra med Expidit data genom alla Winforms.
        List<Bok> valdaBöcker = new List<Bok>(); //Temporär List<> för de valda böcker som ska placeras i listbox2.
        Kontroller kontroller = new Kontroller(); //Skapas för att kunna komma åt metoder i Affärslagret.
        public BokningView(Expidit exp) //Här hämtas ett objekt av Expidit in från Meny som används i denna Form.
        {
            InitializeComponent();

            this.exp = exp;
        }
        #region BakåtFrånBokning
        /// <BakåtFrånBokning-kommentar>
        /// Här skickas användaren till Form Meny.
        /// </BakåtFrånBokning-kommentar>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBakåtFrånBokning_Click(object sender, EventArgs e)
        {
            Meny meny = new Meny(exp);
            meny.Show();
            Visible = false;
        }
        #endregion
        #region VisaTillgängligaBöcker
        /// <VisaTillgängligaBöcker-kommentar>
        /// Här hämtas en List<> med böcker från Affärslagret som presenteras i listbox 1.
        /// </VisaTillgängligaBöcker-kommentar>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVisaTillgängligaBöcker_Click(object sender, EventArgs e)
        {
            List<Bok> list1 = kontroller.HämtaTillgängligaBöcker();
            listBox1.DataSource = list1;
            listBox1.DisplayMember = "Titel";
        }
        #endregion
        #region FlyttaBöckerTillVal
        /// <FlyttaBöckerTillVal-kommentar>
        /// Här flyttas valt objekt av Bok till den temporära List<> valdaBöcker.
        /// Om valt objekt av Bok redan finns i valdaBöcker så skickas ett error-meddelande till användare.
        /// Tempotära List<> valdaBöcker uppdateras vid varje click.
        /// </FlyttaBöckerTillVal-kommentar>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFlyttaBöckerTillVal_Click(object sender, EventArgs e)
        {
            Bok valdBok = (Bok)listBox1.SelectedItem;

            if (!valdaBöcker.Contains(valdBok))
            {
                valdaBöcker.Add(valdBok);
            }
            else
            {
                MessageBox.Show("Denna bok är redan i listan för valda böcker.");
            }
            listBox1.ValueMember = "titel";
            listBox2.DataSource = null;
            listBox2.DisplayMember = "titel";
            listBox2.DataSource = valdaBöcker;
        }
        #endregion
        #region BokaValdaBöcker
        /// <BokaValdaBöcker-kommentar>
        /// int bNr sätts till det som skrivs in i textbox1.
        /// bNr skickas in i metod HittaMedlem som returnerar ett objekt av Medlem från Affärslagret.
        /// Om objektet för Medlem inte är null skickas objekt för Medlem och Expidit samt parameter för datum och en List<> med valda böcker in i metoden SkapaBokning.
        /// listbox3 uppdateras med boknings List<> returen från Affärslagret.
        /// dataGridView1 uppdateras med böcker som finns i bokningen som skapades.
        /// </BokaValdaBöcker-kommentar>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBokaValdaBöcker_Click(object sender, EventArgs e)
        {
            int bNr = int.Parse(textBox1.Text);
            Medlem bokare = kontroller.Hittamedlem(bNr);

            if (bokare != null && textBox1 != null)
            {
                DateTime datum = dateTimePicker1.Value;
                listBox3.DataSource = kontroller.SkapaBokning(bokare, exp, datum, valdaBöcker);
                dataGridView1.DataSource = kontroller.HämtaBokningensBöcker(bNr);
            }
            else
            {
                MessageBox.Show("Du har skrivit fel medelemsnummer" + "\n" +
                    "försök igen");
            }
        }
        #endregion
        #region FlyttaBöckerFrånVal
        /// <FlyttaBöckerFrånVal-kommentar>
        /// Valda objekt av Bok i listbox2 tas bort från temporär List<> valdaBöcker.
        /// listbox2 uppdateras.
        /// </FlyttaBöckerFrånVal-kommentar>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFlyttaBöckerFrånVal_Click(object sender, EventArgs e)
        {
            Bok valdBok = (Bok)listBox2.SelectedItem;
            valdaBöcker.Remove(valdBok);
            listBox1.ValueMember = "titel";
            listBox2.DataSource = null;
            listBox2.DisplayMember = "titel";
            listBox2.DataSource = valdaBöcker;
        }
        #endregion
        #region listBox3_Format
        /// <listBox3_Format-kommentar>
        /// Här sätts formatet för visningen i listbox 3.
        /// </listBox3_Format-kommentar>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox3_Format(object sender, ListControlConvertEventArgs e)
        {
            int BokningsId = ((Bokning)e.ListItem).BokningId;
            int Expidit = ((Bokning)e.ListItem).Expidit.AnstId;
            int Medlem = ((Bokning)e.ListItem).Medlem.MedlemsId;
            DateTime StartLån = ((Bokning)e.ListItem).StartLån;
            e.Value = "Boknings Id: " + BokningsId + "\t" + "Expidit: " + Expidit + "\t    " + "Medlems Id: " + Medlem + "\t" + "Lån startat: " + StartLån;
        }
        #endregion
    }
}
