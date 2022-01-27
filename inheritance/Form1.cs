using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class3 obj = new Class3();

            string teacherr;
            string[] n = new string[3];
            string[] c = new string[3];
            int[] r = new int[3];
            string[] sn = new string[3];
            int[] sc = new int[3];

            teacherr = textBox1.Text;

            n[0] = textBox2.Text;
            n[1] = textBox3.Text;
            n[2] = textBox4.Text;

            c[0] = textBox5.Text;
            c[1] = textBox6.Text;
            c[2] = textBox7.Text;

            r[0] = int.Parse(textBox8.Text);
            r[1] = int.Parse(textBox9.Text);
            r[2] = int.Parse(textBox10.Text);

            sn[0] = textBox11.Text;
            sn[1] = textBox12.Text;
            sn[2] = textBox13.Text;

            sc[0] = int.Parse(textBox14.Text);
            sc[1] = int.Parse(textBox15.Text);
            sc[2] = int.Parse(textBox16.Text);

            obj.setvalues(teacherr, sn, sc, n, c, r);

            Form2 f = new Form2(obj);
            this.Hide();
            f.Show();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
