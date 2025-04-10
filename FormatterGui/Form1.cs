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

            if(!File.Exists("Format_xlsx.exe")) MessageBox.Show("Hiányzik a Format_xlsx.exe", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void buttonFormat_Click(object sender, EventArgs e)
        {
            Func sajt = new Func();
            

            if (string.IsNullOrEmpty(comboBoxSheetName.Text) || string.IsNullOrEmpty(textBoxFirstRow.Text) || string.IsNullOrEmpty(textBoxLastRow.Text))
            {
                MessageBox.Show("Üres adatmezõk", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkBoxUpdate.Checked || !File.Exists(Lit.inputxlsx))
                {
                    File.Delete(Lit.inputxlsx);
                    sajt.dlInput(sender, e, this);
                }
                else sajt.format(this);

            }



        }

        private void textBoxLastRow_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxSheetName.Text) && !string.IsNullOrEmpty(textBoxFirstRow.Text) && !string.IsNullOrEmpty(textBoxLastRow.Text))
            {
                pictureBox1.Image = Properties.Resources.OK;
            }
            else pictureBox1.Image = Properties.Resources.NOK;
        }

        private void textBoxFirstRow_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxSheetName.Text) && !string.IsNullOrEmpty(textBoxFirstRow.Text) && !string.IsNullOrEmpty(textBoxLastRow.Text))
            {
                pictureBox1.Image = Properties.Resources.OK;
            }
            else pictureBox1.Image = Properties.Resources.NOK;
        }

        private void comboBoxSheetName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxSheetName.Text) && !string.IsNullOrEmpty(textBoxFirstRow.Text) && !string.IsNullOrEmpty(textBoxLastRow.Text))
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
            label3.Text = e.ProgressPercentage.ToString();
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



            //File.Create(rg);
            using (var stream = File.Create(Lit.rg))
            {
                //dont Use stream
            }
            using (var sw = new StreamWriter(Lit.rg, true))
            {
                sw.Write(textBoxFirstRow.Text + ":" + textBoxLastRow.Text);
            }
        }
    }
}
