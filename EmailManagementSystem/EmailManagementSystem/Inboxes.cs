using AE.Net.Mail;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailManagementSystem
{
    public partial class Inboxes : UserControl
    {
        public static string mailBox = "INBOX";
        public int currentIndex = -1;
        public Inboxes()
        {
            InitializeComponent();

            //refreshEmails();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            refreshEmails();
        }

        public void refreshEmails()
        {

            if (StaticsVariables.IC.IsConnected && StaticsVariables.IC.IsAuthenticated)
            {
                 
            StaticsVariables.IC.SelectMailbox(Inboxes.mailBox);
                if (this.currentIndex <= -1)
                    this.currentIndex = StaticsVariables.IC.GetMessageCount(Inboxes.mailBox) - 1;

                int i = this.currentIndex;
                for ( ; this.currentIndex  >= i - 15 && i - 15 >= 0; this.currentIndex--)
                {
                    try
                    {
                        this.loadMessage(StaticsVariables.IC.GetMessage(this.currentIndex), this.inboxesList, this.currentIndex);
                        //new Task(new Action( delegate () {  loadMessage(StaticsVariables.IC.GetMessage(i), this.inboxesList,i); })).RunSynchronously();
                    }
                    catch (Exception)
                    {
                    }
                }

                try
                {
                    StaticsVariables.IC.NewMessage += new EventHandler<AE.Net.Mail.Imap.MessageEventArgs>(this.renderNewMail);
                }
                catch (Exception)
                {

                  
                }


            }
            else
            {
                MessageBox.Show("You are not authenticated .... Login again");
                new Form1().ShowDialog();
            }
        }

        public void renderNewMail(object sender, AE.Net.Mail.Imap.MessageEventArgs e)
        {
            try
            {
                MessageBox.Show("You Have New Message");
                //MessageBox.Show(null,StaticsVariables.IC.GetMessage(e.MessageCount-1).Body, "You Have New Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                //this.currentIndex = -1;
                //Inboxes.mailBox = "inbox";
                //this.inboxesList.Controls.Clear();
                //this.refreshEmails();
            }
            catch (Exception)
            {
            }
        }

        public void loadMessage(MailMessage msg , System.Windows.Forms.FlowLayoutPanel inboxesList,int i )
        {

            EmailManagementSystem.EmailMessage emailMsg;
            try
            {
                emailMsg = new EmailManagementSystem.EmailMessage(msg.Flags.HasFlag(Flags.Seen));
            }
            catch (Exception ex)
            {

                emailMsg = new EmailManagementSystem.EmailMessage();
            }

            try
            {
                emailMsg.subject.Text = msg.Subject;
            }
            catch (Exception ex)
            {

                emailMsg.subject.Text = "(No Subject)";
                emailMsg.subject.ForeColor = System.Drawing.Color.DarkRed;
            }
            try
            {
                emailMsg.mailIcon.Text = msg.From.DisplayName.Substring(0,1);
            }
            catch (Exception ex)
            {

                emailMsg.mailIcon.Text = "?";
            }

            try
            {
                emailMsg.senderName.Text = msg.From.DisplayName != "" ? msg.From.DisplayName : msg.Sender.DisplayName;
            }
            catch (Exception ex)
            {
                emailMsg.senderName.Text = "[No Sender Data]";
                emailMsg.senderName.ForeColor = System.Drawing.Color.DarkRed;
            }

            emailMsg.Dock = System.Windows.Forms.DockStyle.Top;
            emailMsg.Tag = StaticsVariables.selectedIndex = i;
            emailMsg.Click += new System.EventHandler(this.showContent);
    
                inboxesList.Controls.Add(emailMsg);


        }

        public void showContent(object sender, EventArgs e)
        {
            
            try
            {
                EmailManagementSystem.EmailMessage mail = (EmailManagementSystem.EmailMessage)sender;
                this.emailBody.Text = StaticsVariables.IC.GetMessage((int)mail.Tag).Body;
                //mail.makeSeen();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }
    }
}
