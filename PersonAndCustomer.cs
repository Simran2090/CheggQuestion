﻿using System;
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
    public partial class PersonAndCustomer : Form
    {
        public string fullName { get; set; }

        public string address { get; set; }

        public double phoneNumber { get; set; }

        public bool mailingPreference { get; set; }

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static bool SetValueForRadioButton = false;

        public PersonAndCustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PersonAndCustomer_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;
            SetValueForText2 = textBox2.Text;
            SetValueForText3 = textBox3.Text;
            SetValueForRadioButton = radioButton1.Checked;

            DisplayDetails form2 = new DisplayDetails();
            form2.Show();
        }
    }
}
