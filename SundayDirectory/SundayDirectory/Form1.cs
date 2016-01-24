using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace SundayDirectory
{
    public partial class Form1 : Form
    {
        private string path;
        private string pathHari;
        private decimal tahun;
        public Form1()
        {
            InitializeComponent();
            TahunNumericUpDown1.Value = DateTime.Now.Year;
        }

        private void SelectDirButton_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                path = folderBrowserDialog1.SelectedPath;
            }
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            try
            {
                tahun = TahunNumericUpDown1.Value;
                DateTime awal = new DateTime((int)tahun,1,1);
                DateTime akhir = new DateTime((int)tahun, 12, 31);
                int i = 1;
                int tempMonth = awal.Month;
                bool cek = true;
                while (awal<=akhir)
                {
                    if (cek)
                    {
                        string Numtemp = i.ToString("00");
                        string bulan = awal.ToString("MMMM", CultureInfo.CreateSpecificCulture("id"));
                        bulan = path + "\\" + Numtemp + " - " + bulan;
                        Directory.CreateDirectory(bulan);
                        pathHari = bulan;
                        i++;
                        cek = false;
                        CreateFolderIfSunday(awal);
                    }
                    awal = awal.AddDays(1);

                    CreateFolderIfSunday(awal);

                    if (awal.Month > tempMonth)
                    {
                        tempMonth++;
                        cek = true;
                    }

                }
                MessageBox.Show("Selesai Membuat !");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CreateFolderIfSunday(DateTime awal)
        {
            if (awal.DayOfWeek == DayOfWeek.Sunday)
            {
                Directory.CreateDirectory(pathHari + "\\" + awal.Day.ToString("00") + " " + awal.ToString("MMMM", CultureInfo.CreateSpecificCulture("id")));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutForm a = new AboutForm();
            a.ShowDialog();
        }
    }
}
