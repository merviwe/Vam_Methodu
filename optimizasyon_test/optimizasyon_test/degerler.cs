using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace optimizasyon_test
{
    public partial class degerler : Form
    {
        public degerler()
        {
            InitializeComponent();
           
        }

        private void degerler_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void degerler_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            foreach (Control x in this.Controls )
            {
                if(x is TextBox )
                {
                    if(((TextBox)x).Text !="")
                    {

                    MessageBox.Show(((TextBox)x).Text);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
