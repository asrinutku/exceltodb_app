using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nc_excel
{
    class DtToSql
    {
        public Form1 Form1 { get; set; }
        public DtToSql()
        {

        }
        public DtToSql(Form1 MainForm)
        {
            Form1 = MainForm;
        }

        public async Task<int> InsertData(string hedef_tablo_adi , DataTable dt)
        {
            int result = 0, row_counter = 1, percent_counter = 1;
            int[] percentes = new int[100];

            // progressbar ın doldurulması için ilerleminin toplam veri büyüklüğüne bölünmesi
            for (int i = 1; i < 100; i++)
            {
                percentes[i - 1] = dt.Rows.Count * i / 100;
            }

            var process = await Task.Run(() =>
            {
                using (var conn = new NpgsqlConnection(Form1._connString))
                {

                    conn.Open();
                    // execute edilecek sql sorgusunun sütunlar kısmı
                    string _sql = CreateSqlQuery(hedef_tablo_adi, dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        row_counter += 1;

                        if (row_counter == percentes[percent_counter])
                        {
                            Form1.FillProgressBar(false);
                            percent_counter += 1;
                        }

                        string _copysql = string.Copy(_sql);

                        _copysql += ParseDataType(dr);

                        result = conn.Execute(_copysql);
                    }
                    
                    conn.Close();
                }
                return result;
            });

            return process;
        }

        // sql sorgusunun VALUES ten sonraki kısmının oluşturulması
        private string ParseDataType(DataRow dr)
        {
            string _sqlValues = "(";
            DateTime dateTime;


            foreach (var i in dr.ItemArray)
            {
                if      (i.GetType().ToString() == "System.Double")
                {
                    _sqlValues += Convert.ToInt64(i) + ",";

                }
                else if (i.GetType().ToString() == "System.String")
                {
                    if (DateTime.TryParse(i.ToString(), out dateTime))
                    {
                        _sqlValues += "'" + Convert.ToDateTime(i) + "'" + ",";
                    }
                    else
                    {
                        _sqlValues += "'" + i.ToString() + "'" + ",";
                    }
                }
                else if (i.GetType().ToString() == "System.DBNull")
                {
                    _sqlValues += "null" + ",";
                }

                else _sqlValues += i + ",";

            }
            _sqlValues = _sqlValues.Remove(_sqlValues.Length - 1);
            _sqlValues += ")";

            return _sqlValues +";";
        }

        // sql sorgusunun VALUES ten önceki kısmının oluşturulması
        private string CreateSqlQuery(string hedef_tablo_adi,DataTable dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dt.Columns[i].ColumnName = dt.Columns[i].ColumnName.ToLower().Replace("ı", "i");
            }

            string _sql = @"INSERT INTO " + hedef_tablo_adi + "(";
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                _sql += dt.Columns[i].ColumnName + ",";

            }
            _sql = _sql.Remove(_sql.Length - 1);
            _sql += ") VALUES ";

            return _sql;
        }
        
    }
}
