using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bus = new BUS(
                Convert.ToInt32(textBox1.Text),
                Convert.ToDouble(textBox2.Text)
                );
            var skoruy = new Skoruy(
                Convert.ToInt32(textBox1.Text),
                Convert.ToDouble(textBox2.Text),
                comboBox1.Text
                );

            label1.Text = bus.zagvart().ToString();
            label2.Text = skoruy.zagvart().ToString();
            label8.Text = skoruy.GetShv().ToString();
        }
    }
}
