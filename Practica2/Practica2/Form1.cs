using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_FC_Click(object sender, EventArgs e)
        {
            float f = float.Parse(txt_F.Text);
            float c = (f - 32) * 0.5f / 9.0f;

            txt_C.Text = c.ToString();

            
        }

        private void btn_CF_Click(object sender, EventArgs e)
        {
            float c = float.Parse(txt_C.Text);
            float f = (c * 9f / 5f) + 32;
            txt_F.Text = f.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_C.Text = "0.0";
            txt_F.Text = "0.0";
        }
    }
}
