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
    public partial class Bai4_Show : Form
    {
        public Bai4_Show()
        {
            InitializeComponent();
        }
        public void Hienthiweb(string s)
        {
            string url = s;
            webView21.Source = new Uri(url);
        }
    }
}
