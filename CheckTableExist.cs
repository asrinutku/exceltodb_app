using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nc_excel
{
    class CheckTableExist
    {
        public bool CheckTable(string hedef_tablo_adi, string _connString, bool isControlButton)
        {
            bool exists;

            string sql = "SELECT * FROM information_schema.tables WHERE table_name = '" + hedef_tablo_adi + "'";
            using (var con = new NpgsqlConnection(_connString))
            {
                using (var cmd = new NpgsqlCommand(sql))
                {
                    if (cmd.Connection == null)
                        cmd.Connection = con;

                    if (cmd.Connection.State != ConnectionState.Open)
                        cmd.Connection.Open();

                    lock (cmd)
                    {
                        using (NpgsqlDataReader rdr = cmd.ExecuteReader())
                        {
                            try
                            {
                                if (rdr != null && rdr.HasRows)
                                    exists = true;
                                else exists = false; ;
                            }
                            catch (Exception)
                            {
                                exists = false;
                            }
                        }
                    }
                    cmd.Dispose();
                }
                con.Close();
            }

            // sadece control butonu ile çağrılmışsa messagebox geri bildirimi ver
            if (exists && isControlButton)
            {
                MessageBox.Show("Tablo var", "Tablo Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!exists && isControlButton)
            {
                MessageBox.Show("Tablo yok", "Tablo Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exists;
        }
        
    }
}
