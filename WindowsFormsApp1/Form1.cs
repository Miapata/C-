using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string beep_item = "Beep: Hertz - " + hertzText.Text + " Interval - " + intervalText.Text;
            listBox1.Items.Add(beep_item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var item  in listBox1.Items)
            {
                string qeuedItem = item.ToString();
                string hertz = qeuedItem.Split('-')[12];
                hertzText.Text = hertz;
            }
        }
    }
}
