using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using AE.Net.Mail;

namespace EmailManagementSystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaticsVariables.email = email.Text;
            StaticsVariables.password = password.Text;

            if (email.Text.Length == 0 || !email.Text.Contains('@') || password.Text.Length == 0)
                MessageBox.Show("Invalid Credentials");
            else
            {
                if (Form1.login(StaticsVariables.email, StaticsVariables.password))
                {
                    new Dashboard().Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Invalid Credentials");
            }
        }

        public static bool login(string email, string password)
        {
            try
            {
                StaticsVariables.IC = new ImapClient("imap.gmail.com", StaticsVariables.email, StaticsVariables.password, AuthMethods.Login, 993, true);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
