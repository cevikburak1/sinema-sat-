using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int mısır, su, çay, bilet, toplam, kasatutarı;

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            label1.BackColor = Color.Blue;
            groupBox1.BackColor = Color.Coral;
            groupBox2.BackColor = Color.DarkGoldenrod;
            groupBox3.BackColor = Color.Chocolate;
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            label1.BackColor = Color.Yellow;
            groupBox1.BackColor = Color.LightBlue;
            groupBox2.BackColor = Color.Brown;
            groupBox3.BackColor = Color.Azure;

        }

        private void morToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
            label1.BackColor = Color.Red;
            groupBox1.BackColor = Color.DimGray;
            groupBox2.BackColor = Color.Cornsilk;
            groupBox3.BackColor = Color.DarkKhaki;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu bir Sinema bilet satış yeri uygulmasaıdır", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            mısır = Convert.ToInt32(textBox1.Text);
            su= Convert.ToInt32(textBox2.Text);
            çay = Convert.ToInt32(textBox3.Text);
            bilet= Convert.ToInt32(textBox4.Text);
            toplam = (mısır * 4) + (su * 1 )+ (çay * 2) + (bilet * 8);
            kasatutarı = kasatutarı + toplam;


            label14.Text = toplam.ToString();
            label16.Text = kasatutarı.ToString();
            
        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
          
        }
    }
}
