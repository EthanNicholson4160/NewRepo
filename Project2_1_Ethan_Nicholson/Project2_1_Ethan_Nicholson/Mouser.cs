using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_1_Ethan_Nicholson
{
    public partial class Mouser : Form
    {
        public Mouser()
        {
            InitializeComponent();
        }

        private void mouseClick(object sender, EventArgs e)
        {
            
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            lblCordinates.Text = ("Clicked at Postition " + e.X + ", " + e.Y);
            if((e.X == 250) && (e.Y == 250))
            {
                MessageBox.Show("Awesome Job");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
