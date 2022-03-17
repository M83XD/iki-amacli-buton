using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool kontrol =false;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (kontrol)
            {

                timer1.Start();
                kontrol = false;
            } 
            else
            {
                timer1.Stop();
                kontrol = true;
            }
        }
        Color[] renkler = { Color.Pink, Color.Red, Color.ForestGreen, Color.DeepPink, Color.CadetBlue };
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            groupBox1.BackColor = renkler[rnd.Next(renkler.Length)];
            groupBox2.BackColor = renkler[rnd.Next(renkler.Length)];
            groupBox3.BackColor = renkler[rnd.Next(renkler.Length)];
        }

    }
}
