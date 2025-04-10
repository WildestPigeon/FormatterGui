using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatterGui
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if (File.Exists(Lit.linktxt)) textBox1.Text = File.ReadAllText(Lit.linktxt);
            textBox2.Text = File.ReadAllText(Lit.ip);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
            //File.Create(sn);
            using (var stream = File.Create(Lit.linktxt))
            {
                // Use stream
            }
            using (var sw = new StreamWriter(Lit.linktxt, true))
            {
                sw.Write(textBox1.Text);
            }

            
            //File.Create(sn);
            using (var stream = File.Create(Lit.ip))
            {
                // Use stream
            }
            using (var sw = new StreamWriter(Lit.ip, true))
            {
                sw.Write(textBox2.Text);
            }

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
