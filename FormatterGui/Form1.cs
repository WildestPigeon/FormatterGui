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
            if (!File.Exists("column_names.txt"))
            {
                using (var stream = File.Create("column_names.txt"))
                {
                    //dont
                }
                using (var sw = new StreamWriter("column_names.txt", true))
                {
                    sw.Write("pont @image név íz m.e kínáló ár r.e r.min");
                }
            }

            if (!File.Exists("image_path.txt"))
            {
                using (var stream = File.Create("image_path.txt"))
                {
                    //dont
                }
                using (var sw = new StreamWriter("image_path.txt", true))
                {
                    sw.Write("M:\\Marketing\\újság\\nagyker\\2025 friss képek\\");
                }
            }

            if (!File.Exists("link.txt")) MessageBox.Show("Nincs beállított link, configban lehet beállítani", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if(!File.Exists("Format_xlsx.exe")) MessageBox.Show("Hiányzik a Format_xlsx.exe", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void buttonFormat_Click(object sender, EventArgs e)
        {
            if (checkBoxUpdate.Checked || !File.Exists("input.xlsx"))
            {
                string link = File.ReadAllText("link.txt");
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile
                    (
                        new System.Uri("https://docs.google.com/spreadsheets/d/" + link + "/export?exportFormat=xlsx"),
                        "input.xlsx"

                    );
                }
                
            }

            if (string.IsNullOrEmpty(comboBoxSheetName.Text) || string.IsNullOrEmpty(textBoxFirstRow.Text) || string.IsNullOrEmpty(textBoxLastRow.Text))
            {
                MessageBox.Show("Üres adatmezõk", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                //FORMAT

                if (File.Exists("output.txt"))
                {
                    if (File.Exists ("previous.txt")) File.Delete("previous.txt");
                    File.Copy("output.txt", "previous.txt");
                }
                string sn = "sheet_name.txt";
                //File.Create(sn);
                using (var stream = File.Create(sn))
                {
                    //dont Use stream
                }
                using (var sw = new StreamWriter(sn, true))
                {
                    sw.Write(comboBoxSheetName.Text);
                }
                

                string rg = "range.txt";
                //File.Create(rg);
                using (var stream = File.Create(rg))
                {
                    //dont Use stream
                }
                using (var sw = new StreamWriter(rg, true))
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
                if (File.Exists("output.txt")){
                    var fullPath = Path.GetFullPath("output.txt");
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
