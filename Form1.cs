using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ToplamaÇarpma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnİslem_Click(object sender, EventArgs e)
        {
            int deger1 = Convert.ToInt32(textBox1.Text);
            int deger2 = Convert.ToInt32(textBox2.Text);
            int sonuc;
            if (RBtnToplama.Checked == true)
            {
                lblSonuc.Text = (deger1 + deger2).ToString();
            }
            if (RBtnCıkarma.Checked == true)
            {
                lblSonuc.Text = (deger1 - deger2).ToString();
            }
            if (RBtnCarpma.Checked == true)
            {
                lblSonuc.Text = (deger1 * deger2).ToString();
            }
            if (RBtnBölme.Checked == true)
            {
                lblSonuc.Text = (deger1 / deger2).ToString();
            }
        }
    }
}
