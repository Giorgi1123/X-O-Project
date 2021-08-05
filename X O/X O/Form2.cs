using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newform1 = new Form1(false,textBox1.Text);
            Form2 form2 = new Form2();
            form2.Hide();
            if (!newform1.IsDisposed)
                newform1.ShowDialog();
            Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newform1 = new Form1(true);
            Form2 form2 = new Form2();
            form2.Hide();
            Visible = false;
            if (!newform1.IsDisposed)
                newform1.ShowDialog();
            Visible = true;
        }
    }
}
