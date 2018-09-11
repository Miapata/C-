using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public StringBuilder stringBuilder;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string beep_item = "Hertz=" + hertzText.Text + " Interval=" + intervalText.Text;
            listBox1.Items.Add(beep_item);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string interval_String;
            string hertz_String;

            foreach (var item  in listBox1.Items)
            {
                if (item.ToString().Contains('='))
                {
                    //This can give us the interval
                    interval_String = item.ToString().Split('=').Last();

                    //This can give us the hertz
                    hertz_String = item.ToString().Split('=', 'I')[1].TrimEnd(' ');


                    Console.Beep(Convert.ToInt32(hertz_String), Convert.ToInt32(interval_String));
                }
                else
                {
                    Thread.Sleep(Convert.ToInt32( item.ToString().Split(':').Last())); 
                }
            }

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string item = "Sleep:" + sleepText.Text;
            listBox1.Items.Add(item);
        }
    }
}
