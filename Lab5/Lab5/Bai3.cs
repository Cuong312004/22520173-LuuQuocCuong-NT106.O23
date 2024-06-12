using MailKit.Net.Pop3;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            dgvEmails.Rows.Clear();
            dgvEmails.Columns.Clear();
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            var client = new Pop3Client();

            try
            {
                client.Connect("pop.gmail.com", 995, true);
                client.Authenticate(email, password);

                int totalEmails = client.GetMessageCount();

                int messageCount = client.Count;
                lblTotalEmails.Text = "Total Emails: " + totalEmails.ToString();


                dgvEmails.Columns.Add("Subject", "Subject");
                dgvEmails.Columns.Add("From", "From");
                dgvEmails.Columns.Add("Date", "Date");
                dgvEmails.Columns["Subject"].ReadOnly = true;
                dgvEmails.Columns["From"].ReadOnly = true;
                dgvEmails.Columns["Date"].ReadOnly = true;

                dgvEmails.Rows.Clear();
                for (int i = messageCount - 1; i >= 0; i--)
                {
                    MimeMessage message = await client.GetMessageAsync(i);
                    dgvEmails.Rows.Add(message.Subject, message.From.ToString(), message.Date);
                }

                await client.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
