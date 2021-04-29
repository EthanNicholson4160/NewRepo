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
    public partial class Form2 : Form
    {
        LinkedList<double> nums = new LinkedList<double>();
       
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double number;
            double.TryParse(txtNum.Text, out number);
            nums.AddFirst(number);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            foreach (double n in nums)
            {
                lstResults.Items.Add(n);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number;
            double.TryParse(txtNum.Text, out number);
            if (nums.Remove(number))
            {
                MessageBox.Show("Removed");
            }
            else
            {
                MessageBox.Show("Item not Found");
            }
        }

        private void btnContain_Click(object sender, EventArgs e)
        {
            double number;
            double.TryParse(txtNum.Text, out number);
            if(nums.Contains(number) == true)
            {
                MessageBox.Show("Found");
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inputOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input_Output input = new Input_Output();
            input.Show();
            this.Hide();
        }

        private void mouserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mouser mouse = new Mouser();
            mouse.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
