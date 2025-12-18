using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zad_12_tsk
{
    public partial class Form1 : Form
    {
        public float x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = (float)Convert.ToDouble(textBox1.Text);
            y = (float)Convert.ToDouble(textBox2.Text);
            label4.Text = "Wynik: " + (x / y).ToString();
            label5.Text = "Format: " + (x / y).ToString("F" + textBox3.Text);

        }
    }
}
