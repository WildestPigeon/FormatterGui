using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.Security.Policy;
using System.Diagnostics;
using System.Net;
using Microsoft.Office.Interop.Excel;
using FormatterGui;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FormatterGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //check requied files
            if (!File.Exists(Lit.cn))
            {
                using (var stream = File.Create(Lit.cn))
                {
                    //dont
                }
                using (var sw = new StreamWriter(Lit.cn, true))
                {
                    sw.Write(Lit.cnContent);
                }
            }

            if (!File.Exists(Lit.ip))
            {
                using (var stream = File.Create(Lit.ip))
                {
                    //dont
                }
                using (var sw = new StreamWriter(Lit.ip, true))
                {
                    sw.Write(Lit.ipContent);
                }
            }

            if (!File.Exists(Lit.linktxt)) MessageBox.Show("Nincs beállított link, configban lehet beállítani", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (!File.Exists("Format_xlsx.exe")) MessageBox.Show("Hiányzik a Format_xlsx.exe", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void buttonFormat_Click(object sender, EventArgs e)
        {
            Func sajt = new Func();


            if (textBoxPage.Text != "")
            {
                if (comboBoxSheetName.Text != "")
                {

                    if (checkBoxUpdate.Checked || !File.Exists(Lit.inputxlsx))
                    {
                        File.Delete(Lit.inputxlsx);
                        sajt.dlInput(sender, e, this);
                    }
                    else sajt.pageFind(comboBoxSheetName.Text, textBoxPage.Text, this, true); ;
                }
                else MessageBox.Show("Megadott munkalap nem lehet null");
            }
            else MessageBox.Show("Megadott oldal nem lehet null");

            

            //}



        }

        private void textBoxPage_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxSheetName.Text) && !string.IsNullOrEmpty(textBoxPage.Text))
            {
                pictureBox1.Image = Properties.Resources.OK;
            }
            else pictureBox1.Image = Properties.Resources.NOK;
        }

        

        private void comboBoxSheetName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxSheetName.Text) && !string.IsNullOrEmpty(textBoxPage.Text))
            {
                pictureBox1.Image = Properties.Resources.OK;
            }
            else pictureBox1.Image = Properties.Resources.NOK;
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        public void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        public void Completed(object sender, AsyncCompletedEventArgs e)
        {
            Func sajt = new Func();
            sajt.format(this);

        }

        public void createFormatFiles()
        {
            //File.Create(sn);
            using (var stream = File.Create(Lit.sn))
            {
                //dont Use stream
            }
            using (var sw = new StreamWriter(Lit.sn, true))
            {
                sw.Write(comboBoxSheetName.Text);
            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Test_Click(object sender, EventArgs e)
        {
            if (textBoxPage.Text != "")
            {
                if (comboBoxSheetName.Text != "")
                {
                    Func sajt = new Func();
                    sajt.pageFind(comboBoxSheetName.Text, textBoxPage.Text, this, false);
                }
                else MessageBox.Show("Megadott munkalap nem lehet null");
            }
            else MessageBox.Show("Megadott oldal nem lehet null");
            
        }

        
    }
}
