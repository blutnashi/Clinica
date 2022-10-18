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
using Clinica.Database;

namespace Clinica
{
    public partial class Form_NewAdmin : DevExpress.XtraEditors.XtraForm
    {
        ErrorProvider error;
        public Form_NewAdmin()
        {
            InitializeComponent();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Admin f = new Form_Admin();
            f.ShowDialog();
        }

        private void Form_NewAdmin_Load(object sender, EventArgs e)
        {
            error = new ErrorProvider();
        }

        bool validar()
        {
            if (te_user.Text.Length == 0)
                {
                    error.SetError(te_user, "Debe ingresar un número de 4 digitos o menos");
                    return false;
                }
            if(te_pass.Text.Length == 0)
            {
                error.SetError(te_pass, "Ingrese la contraseña");
                return false;
            }
            if(te_compass.Text.Length == 0)
            {
                error.SetError(te_compass, "Ingrese la confirmacion de la contraseña");
                return false;
            }
            return true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validar()) {

            if (te_pass.Text == te_compass.Text)
            {
                User_admin us = new User_admin(unitOfWork1)
                {
                    User = Convert.ToInt32(te_user.Text),
                    Password = te_pass.ToString()
                };
                    us.Save();

                    unitOfWork1.CommitChanges();
                    MessageBox.Show("Nuevo Usuario Guardado Correctamente");
                }
            else
                MessageBox.Show("Las contraseñas son diferentes"); }
        }
    }
}