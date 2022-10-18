using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Respaldo_Restauracion_Exportar_Excell
{
    public static class Backup
    {
        public static void Respaldo()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Realizando respaldo de Base de datos ";
            save.Filter = "Respaldo SQL|*.sql";
            save.FileName = "Respaldo-" + DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();

            if (save.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            CrearRespaldo(save.FileName);
            MessageBox.Show("Respaldo realizado correctamente");

        }
        private static void CrearRespaldo(string ruta)
        {
            string constring = "server=localhost;user=root;pwd=;database=consulta_externa;";
            string file = ruta;
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
        }

        public static void Restauracion()
        {
            string constring = "server=localhost;user=root;pwd=;database=consulta_externa;";

            // Important Additional Connection Options
            constring += "charset=utf8;convertzerodatetime=true;";
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Restauracion de base de datos";
            // open.Filter = "Respaldo SQL|*.sql";
            if (open.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            //  MessageBox.Show(open.FileName);
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(open.FileName);
                        conn.Close();
                        MessageBox.Show("Restauracion  realizada correctamente");
                    }
                }
            }
        }
    }

}
