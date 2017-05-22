using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Basico1 b1 = new Basico1();
            b1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Basico2 b2 = new Basico2();
            b2.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Basico5 b5 = new Basico5();
            b5.Show();
            this.Hide();
        }
    }
}
