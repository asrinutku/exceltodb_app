using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nc_excel
{
    class InsertOperation
    {
        public Form1 Form1 { get; set; }
        Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
        Workbook workBook;

        public InsertOperation()
        {

        }
        public InsertOperation(Form1 MainForm)
        {
            Form1 = MainForm;
        }

        public async void OperationInsert(string klasor_yolu,string hedef_tablo_adi)
        {
            string[] dizindekiDosyalar = Directory.GetFiles(klasor_yolu);
            int result = 0;
            System.Data.DataTable dt =null;

            foreach (string dosya in dizindekiDosyalar)
            {
                if (!dosya.Contains("~$") && dosya.Contains("xlsx"))
                {
                    FileInfo fileInfo = new FileInfo(dosya);
                    workBook = application.Workbooks.Open(dosya);

                    // excel içinde tek sheet olduğunu varsayıyorum 
                    // excel_veri fonksiyonunun içinde olası bir durum için multiple sheet okuma yapabilirsin

                    // excel datası datatable a alınıyor
                    ExcelData ed = new ExcelData();
                    dt = ed.GetAllData(fileInfo.FullName, dt);

                    // dt verisinin sql tablosuna aktarılacağı classın objesinin üretilmesi ve fonksiyonun çağırılması
                    DtToSql dts = new DtToSql(Form1);

                    try
                    {
                        result = await dts.InsertData(hedef_tablo_adi, dt);
                        if (result == 1)
                        {
                            System.Threading.Thread.Sleep(500);
                            Form1.FillProgressBar(true);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Excel verileri database aktarılamadı", "Tablo Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex);
                    }
                }
            }
            if (result == 1)
            {
                MessageBox.Show("Tüm Excel Dosyaları Başarıyla Db'ye Aktarıldı", "Tablo Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Rows.Clear();
                dt.AcceptChanges();
            }

            GC.Collect();

        }
    
    }
}
