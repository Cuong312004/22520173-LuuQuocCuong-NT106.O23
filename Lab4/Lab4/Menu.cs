using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Menu : Form
    {
        Bai7 bai7 = new Bai7(); 
        public Menu()
        {
            InitializeComponent();
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            bai7.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
