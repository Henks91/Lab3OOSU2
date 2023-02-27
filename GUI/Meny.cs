using Business.Classes;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class Meny : Form
    {
        Expidit exp { get; set; }
        public Meny(Expidit exp)
        {
            InitializeComponent();
            this.exp = exp;
        }

        /// <KnapparFörMenyValen>
        /// Här finns alla knappar för de fyra olika menyvalen. Vid interaktion med valfri
        /// skickas man till önskat GUI för att utföra sina ärenden.
        /// </KnapparFörMenyValen>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonSkapaBokningMeny_Click(object sender, EventArgs e)
        {
            BokningView bokning = new BokningView(exp);
            bokning.Show();
            Visible = false;
        }

        private void buttonHämtaUtBokning_Click(object sender, EventArgs e)
        {
            HämtaUtBokning utlämning = new HämtaUtBokning(exp);
            utlämning.Show();
            Visible = false;
        }

        private void buttonÅterlämningAvBokning_Click(object sender, EventArgs e)
        {
            Återlämning återlämning = new Återlämning(exp);
            återlämning.Show();
            Visible = false;
        }

        private void buttonLoggaUt_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Visible = false;
        }
    }
}
