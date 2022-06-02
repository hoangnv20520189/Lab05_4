using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MailKit;
using MailKit.Search;
using MailKit.Net.Imap;

namespace lab5_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void Main(string[] args)
        {
            using (var client = new ImapClient()) {
                client.Connect("imap.friends.com", 993, true);

                client.Authenticate("joey", "password");

                // The Inbox folder is always available on all IMAP servers...
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                Console.WriteLine("Total messages: {0}", inbox.Count);
                Console.WriteLine("Recent messages: {0}", inbox.Recent);

                for (int i = 0; i < inbox.Count; i++) {
                    var message = inbox.GetMessage(i);
                    Console.WriteLine("Subject: {0}", message.Subject);
                }

                client.Disconnect(true);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var client = new ImapClient())
            {
                client.Connect("imap.gmail.com", 993, true);

                client.Authenticate("username", "passs");

                // The Inbox folder is always available on all IMAP servers...
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                Console.WriteLine("Total messages: {0}", inbox.Count);
                Console.WriteLine("Recent messages: {0}", inbox.Recent);

                //for (int i = 0; i < inbox.Count; i++)
                //{
                //    var message = inbox.GetMessage(i);
                //    Console.WriteLine("Subject: {0}", message.Subject);
                //}

                

                listView1.Columns.Add("Email", 200);
                listView1.Columns.Add("From", 100);
                listView1.Columns.Add("Thời gian", 100);
                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    ListViewItem name = new ListViewItem(message.Subject);

                    ListViewItem.ListViewSubItem from = new;
                    ListViewItem.ListViewSubItem(name, message.From.ToString());
                    name.SubItems.Add(from);

                    ListViewItem.ListViewSubItem date = new;
                    ListViewItem.ListViewSubItem(name, message.Date.ToString());
                    name.SubItems.Add(date);
                    listView1.Items.Add(name);
                }
                client.Disconnect(true);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void txbUsr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
