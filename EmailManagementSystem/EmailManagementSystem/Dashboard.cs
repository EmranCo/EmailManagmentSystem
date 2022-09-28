using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AE.Net.Mail;

namespace EmailManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            AE.Net.Mail.Imap.Mailbox[] mailBoxes = StaticsVariables.IC.ListMailboxes(string.Empty, "*");
            foreach (var mailBox in mailBoxes)
            {
                string msgCount = "   [ " + StaticsVariables.IC.GetMessageCount(mailBox.Name) + " ] ";

                if (mailBox.Name == "INBOX")
                    inboxBtn.Text += msgCount;

                if (mailBox.Name == "[Gmail]/المهـملات")
                    trashedBtn.Text += msgCount;

                if (mailBox.Name == "[Gmail]/بريد مرسل")
                    sentMailBtn.Text += msgCount;

                if (mailBox.Name == "[Gmail]/كل البريد")
                    allMailsBtn.Text += msgCount;

                if (mailBox.Name == "[Gmail]/الرسائل غير المرغوب فيها")
                    spamMailsBtn.Text += msgCount;
            }


        }

        

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendEmail1.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Inboxes.mailBox = "inbox";
            inboxes1.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Inboxes.mailBox = "[Gmail]/المهـملات";
            draft.BringToFront();
        }

        private void SentMailBtn_Click(object sender, EventArgs e)
        {
            Inboxes.mailBox = "[Gmail]/بريد مرسل";
            sentMails.BringToFront();
        }

        private void AllMailsBtn_Click(object sender, EventArgs e)
        {
            Inboxes.mailBox = "[Gmail]/كل البريد";
            allMails.BringToFront();
        }

        private void SpamMailsBtn_Click(object sender, EventArgs e)
        {
            Inboxes.mailBox = "[Gmail]/الرسائل غير المرغوب فيها";
            spamMails.BringToFront();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
