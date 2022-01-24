using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonAndCustomerClass
{
    public partial class DisplayDetails : Form
    {
        public DisplayDetails()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DisplayDetails_Load(object sender, EventArgs e)
        {
            label1.Text = PersonAndCustomer.SetValueForText1;
            label2.Text = PersonAndCustomer.SetValueForText2;
            label3.Text = PersonAndCustomer.SetValueForText3;
            label4.Text = PersonAndCustomer.SetValueForRadioButton.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
