using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace Clinica
{
    public partial class Form_Login : DevExpress.XtraEditors.XtraForm
    {
        
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            MySqlConnection Conexion = new MySqlConnection("server=localhost; database=consulta_externa; user id=root; password=");
            Conexion.Open();
            MySqlCommand coma = new MySqlCommand();
            coma.Connection = Conexion;
            coma.CommandText = ("select *from user_admin where user = '" + te_user.Text + "' and password = '" + te_password.Text + "' ");

            MySqlDataReader leer = coma.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    this.Hide();
                    leer.Read();
                    Form_Admin f = new Form_Admin();
                    f.Show();
                }
            }
            Conexion.Close();

            MySqlConnection Cone = new MySqlConnection("server=localhost; database=consulta_externa; user id=root; password=");
            Cone.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = Cone;
            com.CommandText = ("select * from user where id = '" + te_user.Text + "' and password = '" + te_password.Text + "' ");

            MySqlDataReader read = com.ExecuteReader();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    this.Hide();
                    read.Read();
                    Form_User fu = new Form_User();
                    fu.U = te_user.Text;
                    fu.Show();
                }
            }
            if(!read.HasRows && !leer.HasRows)
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
            }
            
            Conexion.Close();
            
        }
        
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}