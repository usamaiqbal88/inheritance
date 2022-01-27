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
    public partial class Form2 : Form
    {
        public Form2(Class3 std)
        {
            InitializeComponent();

            textBox1.Text = std.teacher;
            textBox2.Text = std.name[0];
            textBox3.Text = std.name[1];
            textBox4.Text = std.name[2];

            textBox5.Text = std.clas[0];
            textBox6.Text = std.clas[1];
            textBox7.Text = std.clas[2];


            textBox8.Text = Convert.ToString(std.roll[0]);
            textBox9.Text = Convert.ToString(std.roll[1]);
            textBox10.Text = Convert.ToString(std.roll[2]);

            textBox11.Text = std.subjectname[0];
            textBox12.Text = std.subjectname[1];
            textBox13.Text = std.subjectname[2];

            textBox14.Text = Convert.ToString(std.subjectcode[0]);
            textBox15.Text = Convert.ToString(std.subjectcode[1]);
            textBox16.Text = Convert.ToString(std.subjectcode[2]);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
