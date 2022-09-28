using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;



namespace EmailManagementSystem
{
    public partial class SendEmail : UserControl
    {
        public SendEmail()
        {
            InitializeComponent();
            fromEmail.Text = StaticsVariables.email;
        }

        private void sendMailBtn_Click(object sender, EventArgs e)
        {
            loader.Visible = true;

            if (Form1.login(StaticsVariables.email, StaticsVariables.password))
            {
                try
                {
                    using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                    {
                        client.EnableSsl = true;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential(StaticsVariables.email, StaticsVariables.password);

                        MailMessage msgObj = new MailMessage();
                        msgObj.To.Add(new MailAddress(reciever.Text));
                        msgObj.From = new MailAddress(StaticsVariables.email);
                        msgObj.Subject = subject.Text;
                        msgObj.Body = body.Text;
                        client.Send(msgObj);
                        MessageBox.Show("Message Sent");
                        reciever.Clear();
                        subject.Clear();
                        body.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Message not Sent" + ex);
                    
                }
                loader.Visible = false;
                
            }
            else
                MessageBox.Show("Invalid Credentials");
        }


        private void Discard_Click(object sender, EventArgs e)
        {
            reciever.Clear();
            subject.Clear();
            body.Clear();
        }
    }
}
