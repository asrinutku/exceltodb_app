using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nc_excel
{
    class ExcelData
    {
        Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
        public Form1 Form1 { get; set; }
        public ExcelData()
        {

        }
        public ExcelData(Form1 MainForm)
        {
            Form1 = MainForm;
        }
        

        public System.Data.DataTable GetAllData(string path, System.Data.DataTable dt)
        {
            var stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var result = reader.AsDataSet();
            var tables = result.Tables.Cast<System.Data.DataTable>();

            foreach (System.Data.DataTable table in tables)
            {
                dt = table;
            }

            foreach (DataColumn column in dt.Columns)
            {
                string cName = dt.Rows[0][column.ColumnName].ToString();
                if (!dt.Columns.Contains(cName) && cName != "")
                {
                    column.ColumnName = cName;
                }
            }
            dt.Rows[0].Delete();
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };
            dt.AcceptChanges();

            return dt;
        }

        public async Task FillListView(string dosya_yolu)
        {
            var result = await Task.Run(() =>
            {
                string[] dizindekiDosyalar = Directory.GetFiles(dosya_yolu);

                Workbook workBook;

                foreach (string dosya in dizindekiDosyalar)
                {

                    if (!dosya.Contains("~$") && dosya.Contains("xlsx"))
                    {

                        FileInfo fileInfo = new FileInfo(dosya);
                        string dosya_adi = fileInfo.Name;


                        workBook = application.Workbooks.Open(dosya);

                        for (int i = 1; i <= workBook.Sheets.Count; i++)
                        {
                            Worksheet worksheet = workBook.Worksheets[i];

                            Range excelCell = worksheet.UsedRange;
                            Object[,] sheetValues = (Object[,])excelCell.Value;

                            string[] items = { dosya_adi, worksheet.Name, sheetValues.GetLength(0).ToString() };

                         
                            Form1.FillListView(items);
                        }
                    }
                }
                return Task.FromResult(dizindekiDosyalar);
            });
        }
    }
}
