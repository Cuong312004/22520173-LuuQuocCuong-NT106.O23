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
    public partial class Menu : Form
    {

        Bai1 bai1 = new Bai1(); 
        Bai2 bai2 = new Bai2();


        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            bai1.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            bai2.Show();
        }
    }
}
