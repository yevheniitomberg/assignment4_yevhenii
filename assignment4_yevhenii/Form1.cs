using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4_yevhenii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                long number = int.Parse(this.input_num.Text);
                if (number <= 0)
                {
                    throw new Exception();
                }
                long factorial = 1;
                for (long i = factorial; i <= number; i++)
                {
                    factorial *= i;
                }
                this.label_result.Text = number + "! = " + factorial;
            } catch
            {
                MessageBox.Show("Wrong input type", "Input Error", MessageBoxButtons.OK);
            }
        }
    }
}
