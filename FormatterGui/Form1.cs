using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.Security.Policy;
using System.Diagnostics;
using System.Net;
using Microsoft.Office.Interop.Excel;


namespace FormatterGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //check requied files
            if (!File.Exists(Important.cn))
            {
                using (var stream = File.Create(Important.cn))
                {
                    //dont
                }
                using (var sw = new StreamWriter(Important.cn, true))
                {
                    sw.Write(Important.cnContent);
                }
            }

            if (!File.Exists(Important.ip))
            {
                using (var stream = File.Create(Important.ip))
                {
                    //dont
                }
                using (var sw = new StreamWriter(Important.ip, true))
                {
                    sw.Write(Important.ipContent);
                }
            }

            if (!File.Exists(Important.linktxt)) MessageBox.Show("Nincs beállított link, configban lehet beállítani", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if(!File.Exists("Format_xlsx.exe")) MessageBox.Show("Hiányzik a Format_xlsx.exe", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void buttonFormat_Click(object sender, EventArgs e)
        {
            if (checkBoxUpdate.Checked || !File.Exists(Important.inputxlsx))
            {
                File.Delete(Important.inputxlsx);
                string link = File.ReadAllText(Important.linktxt);
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile
                    (
                        new System.Uri("https://docs.google.com/spreadsheets/d/" + link + "/export?exportFormat=xlsx"),
                        Important.inputxlsx
                        
                    );
                    /*while (!File.Exists(Important.inputxlsx))
                    {
                        System.Threading.Thread.Sleep(500);
                    }
                    MessageBox.Show("ok");
                }
                */
            }

            if (string.IsNullOrEmpty(comboBoxSheetName.Text) || string.IsNullOrEmpty(textBoxFirstRow.Text) || string.IsNullOrEmpty(textBoxLastRow.Text))
            {
                MessageBox.Show("Üres adatmezõk", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                //FORMAT

                if (File.Exists(Important.outputtxt))
                {
                    if (File.Exists (Important.previoustxt)) File.Delete(Important.previoustxt);
                    File.Copy(Important.outputtxt, Important.previoustxt);
                }
                
                //File.Create(sn);
                using (var stream = File.Create(Important.sn))
                {
                    //dont Use stream
                }
                using (var sw = new StreamWriter(Important.sn, true))
                {
                    sw.Write(comboBoxSheetName.Text);
                }
                

                
                //File.Create(rg);
                using (var stream = File.Create(Important.rg))
                {
                    //dont Use stream
                }
                using (var sw = new StreamWriter(Important.rg, true))
                {
                    sw.Write(textBoxFirstRow.Text+":"+textBoxLastRow.Text);
                }
                Process process = Process.Start("Format_xlsx.exe");
                int id = process.Id;
                Process tempProc = Process.GetProcessById(id);
                this.Visible = false;
                tempProc.WaitForExit();
                this.Visible = true;

                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                if (File.Exists(Important.outputtxt)){
                    var fullPath = Path.GetFullPath(Important.outputtxt);
                    Workbook wb = excel.Workbooks.Open(fullPath);
                    excel.Visible = true;
                }

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
    }
}
