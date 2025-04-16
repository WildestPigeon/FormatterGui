using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.LinkLabel;

namespace FormatterGui
{


    internal class Lit
    {

        public static string inputxlsx = "input.xlsx";
        public static string linktxt = "link.txt";
        public static string outputtxt = "output.txt";
        public static string previoustxt = "previous.txt";
        public static string sn = "sheet_name.txt";
        public static string rg = "range.txt";
        public static string cn = "column_names.txt";
        public static string cnContent = "pont @image név íz m.e kínáló ár r.e r.min";
        public static string ip = "image_path.txt";
        public static string ipContent = "M:\\Marketing\\újság\\nagyker\\2025 friss képek\\";



        /*
         * Hol volt, hol nem volt, há volt egyszer egy ember, aki megjelent, satöbbi satöbbi, de az az ember nem tudom, ki látta. Senki nem látta. Senki. Én nem láttam, így nem is hittem el se. 

           Akkor is elhittem, én mikor valaki más látta, de mikor én láttam, hát az volt az igazi. De aki láttal, nem mondja, hogy nem látta. Arra látszatott a kapu háta mögött. Benedek hét méterről látta. Néger meg kergette, Vilivel. 

           Itt az utcába jövök be a motorral, azt láttam, hogy el kezd futni. Nézzed csak ott van a csávó, mondom láttam, na mondom menjünk le. Le akartunk menni, na akkor bement a tengeribe. Mondom neki állj meg kurva anyád erre azt mondja, hogy gyere. 

           Na mondom, megyek várja, hogy kihúztam a kaszát, azt mentem én csak addig elszökött, csak mezítláb voltam. Ebbe a cipőbe lettem volna elcsíptem volna.  Itt van egy cigánytelep, itt ahol balról le lehet kanyarodni oda futott be.

           Utána vágtam, én csak a fejét vágta le, a kertbe, ahogy szaladtam, utána vágtam én, csak nem érte el. A kert alatt kergettük, érted? Sikítás hallatszott, hogy ott megy, ott megy, és akkor az egész csapat, búm arra szaladt, és akkor valami kerítésen keresztül, átugorta, hogy onnan hova ment, már a rendőrök se találták. 

           Lehet, hogy keresünk egy olyan fantomképet, ami nem létezik. Vagy létezik, abszolút nem tudom. Nem láttam, de az biztos, hogy engem nagyon megrázott a dolog. És amikor meghallottam, hát én szeritem, valahogy depresszióba estem. 

           Annyira veszedelmes, vagy mit tudom én, hogy milyen ember akkor bántalmazott volna valakit, senkit nem bántott a faluban. A rendőrök is olyat mondanak, hogy túl sok x-aktát nézünk, meg ilyenek. Én se hittem el, még az utolsó napon is, ameddig nem jött be hozzám, kiröhögtem én is őket. 

           De amikor bejött hozzám, akkor én is azt montam, hogy ledermedtem egy kicsit. olyan 80%ig én benne vagyok hogy lehet hogy így van. Annyit tudok hogy azt mondják nagyon gyors. Bement egy helyre, elkezdett ott járkálni, meg minden. 2 perc múlva meg már amarra volt ott lent az izében.

           Van a főutca fele, innen vagy 2 km, 2 -3 perc volt az egész. Azt kirúgta a drótkerítést, lábbal kirúgta. Pedig az, le volt normálisan drótozva. Azt lábbal kirúgta. Fantom, vagy mi a jó isten volt? Egy űr az égből lepottyan és olyan gyors. 

           Kérdeztem tőle, na Géza, a ide figyelj, komán láttad? Komán láttam, mekkora! Hú, ne is mondj, de azt mondom, kétszer akkora  mint én. Nagyon magas volt. 195 körül volt. Magas volt, két méter. 

           Kettő, úgy körül volt. Akkora volt, meg ugyan ilyen széles is. Fele két méteres látott az ezen a részén volt a falunak, amikor másik részen meg a két méter, húsz, harmincöt. 

           Nekem sincsen vékony nakam, de ahogy a fenyképen láttam, ekkora nyaka volt neki annak az embernek. Még a fanton volt, őrültek az öregasszonyok, egy kerékpár nem veszett, egy kacsa nem veszett el. Azok sokan azt mondták, hogy bár ez a fantom, járkálna itt mindig. 

           Valamilyen telefon összeketetésbe volt, valakivel. Ha egy ilyen ember kérlek szépen telefon nélkül nem is mászkál, annak lenni kell minden.

           Felszerelve, lóvéval, a telefonnal, meg mindennel, amit csak létezik. Ezért nem tudtuk elkapni, nagyon jól informált volt. Valamikor voltak ezek a, nem a nazisták, nem a magyar gárdák, gárdisták. 

           Na például, lehet, hogy onnan, csak így teszem fel ezt a kérdést dee, lehet, hogy így is van, hogy na, kültek egy felmérést, hány cigány van, hogy ho laknak, satöbbi satöbbi. Magyar gárdistából egy ilyen felderítő, érted cigánság felé. 

           Na az biztos, hogy ha ilyeneket csinálnak, akkor nagyon rossz vége lesz. Itten, ide figyeljél, itten az emberek hullanak, mint a legyek. Csak elhiszem, majd majd, tulajdonképpen elhiszem, létezik, lehet.
         */
    }
    public class Func
    {
            

        
        public void dlInput(object sender, EventArgs e, Form1 a)
        {
                
            string link = File.ReadAllText(Lit.linktxt);
            WebClient wc = new WebClient();
                
                    
                    
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(a.ProgressChanged);
                    
            wc.DownloadFileAsync
            (
                new System.Uri("https://docs.google.com/spreadsheets/d/" + link + "/export?exportFormat=xlsx"),
                Lit.inputxlsx
                        
            );
            
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(a.Completed);

        }

        

        


        public void format(Form1 a)
        {
            if (File.Exists(Lit.outputtxt))
            {
                if (File.Exists(Lit.previoustxt)) File.Delete(Lit.previoustxt);
                File.Copy(Lit.outputtxt, Lit.previoustxt);
            }

            a.createFormatFiles();
            

            Process process = Process.Start("Format_xlsx.exe");
            int id = process.Id;
            Process tempProc = Process.GetProcessById(id);
            //a.Visible = false;
            tempProc.WaitForExit();
           //a.Visible = true;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            if (File.Exists(Lit.outputtxt))
            {
                var fullPath = Path.GetFullPath(Lit.outputtxt);
                Workbook wb = excel.Workbooks.Open(fullPath);
                excel.Visible = true;
            }
        }


        public void pageFind(string shit, string page, Form1 a, bool f)
        {
            string filePath = Path.GetFullPath(Lit.inputxlsx);
            string expression = page;

            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = null;
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            Microsoft.Office.Interop.Excel.Range usedRange = null;

            try
            {
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[shit];

                usedRange = worksheet.UsedRange;
                int rowCount = usedRange.Rows.Count;

                int firstMatchRow = -1;
                int lastMatchRow = -1;

                for (int row = 1; row <= rowCount; row++)
                {
                    var cell = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[row, 1];
                    string cellValue = cell.Value2?.ToString(); // Safer and faster than .Text

                    if (cellValue == expression)
                    {
                        if (firstMatchRow == -1)
                            firstMatchRow = row;

                        lastMatchRow = row;
                    }

                    // 🔥 Always release cell object
                    Marshal.ReleaseComObject(cell);
                }

                if (firstMatchRow != -1)
                {
                    a.label5.Text = firstMatchRow.ToString();
                    a.label6.Text = lastMatchRow.ToString();

                    using (var stream = File.Create(Lit.rg)) { }
                    using (var sw = new StreamWriter(Lit.rg, true))
                    {
                        sw.Write(firstMatchRow + ":" + lastMatchRow);
                    }
                    if (f) format(a);
                }
                else
                {
                    MessageBox.Show("no match");
                }
            }
            finally
            {
                if (usedRange != null) Marshal.ReleaseComObject(usedRange);
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null)
                {
                    workbook.Close(false);
                    Marshal.ReleaseComObject(workbook);
                }

                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

    }

    


}
