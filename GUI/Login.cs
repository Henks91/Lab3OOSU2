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
    
    public partial class Login : Form
    {
        Expidit exp { get; set; }
        Kontroller kontroller = new Kontroller();
        public Login()
        {
            InitializeComponent();
        }

        /// <KnappenLoggaIn>
        /// Id och lösenord matas in i separata textboxar och skickas till metoden 
        /// Inloggning i kontrollern. Om försöket godkänns visas menyn för användaren. 
        /// Vid felaktigt försök visas en MessageBox om att fel info angets. 
        /// </KnappenLoggaIn>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1Login_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1Id.Text);
            string password = textBox2Password.Text;
            exp = kontroller.Inloggning(id, password);

            if (exp != null)
            {
                this.Hide();
                //NÄsta sida ska öppnas här
                Meny meny = new Meny(exp);
                meny.Show();
            }
            else
            {
                MessageBox.Show("Du har anget fel information");
            }
        }

        private void buttonAvsluta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
