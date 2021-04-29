using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Project2_1_Ethan_Nicholson
{
    public partial class Input_Output : Form
    {
        public Input_Output()
        {
            InitializeComponent();
        }
        StreamReader sr = new StreamReader("numbers.txt");
        StreamWriter sw = new StreamWriter("report.txt");
        double[] numbers = new double[6];
        double total;
        double average;
        private void Input_Output_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(sr.ReadLine());
                lstNums.Items.Add(numbers[i].ToString());

            }
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];

            }
            sw.WriteLine("Total: " + total.ToString());
            average = total / 9;
            sw.WriteLine("Average: " + average.ToString());
            for (int i = 0; i < numbers.Length; i++)
            {
               if(numbers[i] > 90)
                {
                    sw.WriteLine("A");
                }
               else if(numbers[i] < 90 && numbers[i] > 80)
                {
                    sw.WriteLine("B");
                }
                else if (numbers[i] < 80 && numbers[i] > 70)
                {
                    sw.WriteLine("C");
                }
                else if (numbers[i] < 70 && numbers[i] > 60)
                {
                    sw.WriteLine("D");
                }
                else if (numbers[i] < 60)
                {
                    sw.WriteLine("F");
                }
            }
            sw.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
