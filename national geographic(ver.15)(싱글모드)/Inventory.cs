using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace national_geographic
{
    public partial class Inventory : Form
    {
        Form1 f1;
        Bitmap st = Properties.Resources.stone;
        Bitmap wd = Properties.Resources.firewood;
        Bitmap mt = Properties.Resources.meat;
        public Inventory(Form1 frm1)
        {
            InitializeComponent();
            f1 = frm1;
        }
        
        private void Inventory_Load(object sender, EventArgs e)
        {
            
            pictureBox1.Image = wd;
            pictureBox2.Image = st;
            pictureBox3.Image = mt;

        }
    }
}
