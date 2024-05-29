using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Lab4
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = txbURL.Text;
            string filePath = txbFilePath.Text;

            if (!string.IsNullOrEmpty(url) && !string.IsNullOrEmpty(filePath))
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(url, filePath);
                    string htmlContent = File.ReadAllText(filePath);
                    richTextBox1.Text = htmlContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid URL and file path !");
            }
        }
    }
}
