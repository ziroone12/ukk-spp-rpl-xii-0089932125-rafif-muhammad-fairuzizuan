using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace desktop_csharp.konfig
{
    internal class Koneksi
    {
        static string konfigurasi = "server=localhost;port=3306;username=root;database=db_sekolah_xii;";

        public static MySqlConnection koneksi()
        {
            MySqlConnection koneksi = new MySqlConnection(konfigurasi);
            try
            {
                koneksi.Open();
                return koneksi;
            }catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        

    }
}
