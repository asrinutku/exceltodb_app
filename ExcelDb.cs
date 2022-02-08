using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace nc_excel
{
    class ExcelDb
    {
        public Form1 Form1 { get; set; }

        public ExcelDb()
        {

        }
        public ExcelDb(Form1 MainForm)
        {
            Form1 = MainForm;
        }


        public void Tablo_olustur(string hedef_tablo_adi)
        {
            ReadWriteXML rxml = new ReadWriteXML();
            List<ReadWriteXML.column> tb = rxml.ReadDbColumns();
            rxml = null;

            string _sql = "CREATE TABLE " + hedef_tablo_adi + " (";

            foreach (var item in tb)
            {
                string _Type = "character varying(400)";
               
                if (item.name != null)
                {
                    // daha fazla veri tipi olduğunda buraya ekleme yapılabilir
                    if (item.type.ToString() == "System.Double") _Type = "double precision";
                    if (item.type.ToString() == "System.Int64") _Type = "integer";
                    if (item.type.ToString() == "date") _Type = "date";
                }

                _sql += item.name + " " + _Type + ",";
            }
            _sql = _sql.Remove(_sql.Length - 1);
            _sql += ");";

            using (var conn = new NpgsqlConnection(Form1._connString))
            {
                try
                {
                    conn.Open();
                    NpgsqlCommand sql_command = new NpgsqlCommand(_sql, conn);

                    try
                    {
                        sql_command.ExecuteNonQuery();
                        MessageBox.Show("Tablo basariyla olusturuldu", "Tablo Olustur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex){
                        Console.WriteLine(ex);
                    }
                    conn.Close();

                }
                catch (NpgsqlException ex)
                {
                    Console.WriteLine(ex);
                }
            }
            GC.Collect();
        }

        public void Tablo_temizle(string hedef_tablo_adi)
        {
            string _sql = "TRUNCATE TABLE " + hedef_tablo_adi + ";";

            using (var conn = new NpgsqlConnection(Form1._connString))
            {
                try
                {
                    conn.Open();
                    NpgsqlCommand sql_command = new NpgsqlCommand(_sql, conn);
                    try
                    {
                        sql_command.ExecuteNonQuery();
                        MessageBox.Show("Tablo basariyla temizlendi", "Tablo Temizle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    conn.Close();
                }
                catch (NpgsqlException ex)
                {
                    Console.WriteLine(ex);
                }
            }
            

        }
    }
}
