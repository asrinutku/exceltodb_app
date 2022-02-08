using Dapper;
using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using Npgsql;
using Npgsql.Bulk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using Windows.Storage;
using Z.BulkOperations;

namespace nc_excel
{
    public partial class Form1 : Form
    {
        Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
        bool mouseDown;
        private System.Drawing.Point offset;
        public string _connString;

        string hedef_tablo_adi = "tasinmazlar";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExcelVerilistView.View = View.Details;
            ExcelVerilistView.FullRowSelect = true;
            ExcelVerilistView.Columns.Add("Dosya", 150);
            ExcelVerilistView.Columns.Add("Sheet", 150);
            ExcelVerilistView.Columns.Add("Veri", 150);
            DosyaYoluTextBox.Enabled = false;

            ReadWriteXML rwxml = new ReadWriteXML();
            DosyaYoluTextBox.Text = rwxml.GetFolderPath();
            _connString = rwxml.GetDatabaseConnectionString();
            

            bunifuProgressBar1.Value = 0;

        }


        // dışardan müdahale edemediğim form elemanlarına bu dışardan alttaki 2 fonksiyonu çağırarak erişiyorum
        public void FillListView(string[] items)
        {
            if (ExcelVerilistView.InvokeRequired)
            {
                ExcelVerilistView.Invoke(new MethodInvoker(delegate { ExcelVerilistView.Items.Add(new ListViewItem(items)); }));
            }
            else ExcelVerilistView.Items.Add(new ListViewItem(items));
        }

        public void FillProgressBar(bool Reset)
        {
            if (Reset)
            {
                bunifuProgressBar1.Value = 0;
            }
            else
            {
                this.bunifuProgressBar1.Invoke(new MethodInvoker(delegate
                {
                    bunifuProgressBar1.Value += 1;
                }));

            }
        }

        private async void KlasorAcButton_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            DosyaYoluTextBox.Text = folderBrowserDialog1.SelectedPath;
            ExcelVerilistView.Items.Clear();

            OpenFolder of = new OpenFolder(this);

            await of.KlasorAc(folderBrowserDialog1.SelectedPath);
            of = null;

            GC.Collect();

            
        }

        private void BaslatButton_Click(object sender, EventArgs e)
        {
            bool exists;

            CheckTableExist cte = new CheckTableExist();
            exists = cte.CheckTable(hedef_tablo_adi, _connString, false);
            cte = null;


            if (TabloOlusturCb.Checked && TabloTemizleCb.Checked)
            {
                MessageBox.Show("İki Fonksiyon Ayni Anda Kullanilamaz", "Tablo Fonksiyon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (!TabloOlusturCb.Checked && !TabloTemizleCb.Checked && exists)
            {
                if(ExcelVerilistView.Items.Count != 0)
                {
                    InsertOperation dto = new InsertOperation(this);
                    dto.OperationInsert(DosyaYoluTextBox.Text,hedef_tablo_adi);
                    dto = null;
                }
                else MessageBox.Show("Yeni Klasör Seçimi Yapılmadı veya Klasörde Excel Dosyası Yok", "Klasör Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (TabloTemizleCb.Checked)
            {
                if (exists)
                {
                    ExcelDb db = new ExcelDb(this);
                    db.Tablo_temizle(hedef_tablo_adi);

                }
                else
                {
                    MessageBox.Show("Temizlenecek tablo bulunamadi", "Tablo Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (TabloOlusturCb.Checked)
            {

                if (!exists)
                {
                    ExcelDb db = new ExcelDb(this);
                    db.Tablo_olustur(hedef_tablo_adi);
                }
                else
                {
                    MessageBox.Show("Tablo zaten var", "Tablo Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


            GC.Collect();

        }

        private void KontrolButton_Click_1(object sender, EventArgs e)
        {
            CheckTableExist cte = new CheckTableExist();
            cte.CheckTable(hedef_tablo_adi, _connString, true);

            cte = null;
            GC.Collect();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }
        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                System.Drawing.Point currentScreenPos = PointToScreen(e.Location);
                Location = new System.Drawing.Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }
        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
