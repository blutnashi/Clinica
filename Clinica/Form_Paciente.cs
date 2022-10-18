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
    public partial class Form_Paciente : DevExpress.XtraEditors.XtraForm
    {
        ErrorProvider error;
        private bool _usconfnew;
        bool aux;
        public Form_Paciente()
        {
            InitializeComponent();
        }

        public bool UsConfNew
        {
            set
            {
                _usconfnew = value;
                aux = _usconfnew;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar()) {
            Paciente pac = new Paciente(unitOfWork1)
            {
                Num_seguro = Convert.ToInt32(teNumSeguro.Text),
                Nombre = teNombres.Text,
                Apellido = teApellidos.Text,
                Cedula = teCedula.Text,
                Fcha_nac = Convert.ToDateTime(teFchaNac.Text),
                Telefono = teCelular.Text,
                Numero_emergencia = teNumeroEmergencia.Text
            };


            pac.Save();

            unitOfWork1.CommitChanges();
            MessageBox.Show("Paciente Guardado Correctamente"); }
        }

        private void menuprincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Admin admin = new Form_Admin();
            admin.ShowDialog();
            this.Close();
            
        }

        private void teNumSeguro_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_Paciente_Load(object sender, EventArgs e)
        {
            error = new ErrorProvider();
            if (aux == true)
                menuprincipal.Dispose();
            else
                bt_menuusuario.Dispose();
        }

        bool validar()
        {
            if (teNumSeguro.Text.Length == 0)
            {
                error.SetError(teNumSeguro, "Debe ingresar numero de seguro");
                teNumSeguro.Focus();
                return false;
            }
            if (teNombres.Text.Length == 0)
            {
                error.SetError(teNombres, "Ingrese el nombre");
                teNombres.Focus();
                return false;
            }
            if (teApellidos.Text.Length == 0)
            {
                error.SetError(teApellidos, "Ingrese los Apellidos");
                teApellidos.Focus();
                return false;
            }
            if (teCedula.Text.Length == 0)
            {
                error.SetError(teNumSeguro, "Debe ingresar la cedula");
                teCedula.Focus();
                return false;
            }
            if (teFchaNac.Text.Length == 0)
            {
                error.SetError(teFchaNac, "Seleccione la fecha");
                teFchaNac.Focus();
                return false;
            }
            if (teCelular.Text.Length == 0)
            {
                error.SetError(teCelular, "Ingrese su numero de telefono");
                teCelular.Focus();
                return false;
            }
            if (teNumeroEmergencia.Text.Length == 0)
            {
                error.SetError(teNumeroEmergencia, "Ingrese el numero de emergencia");
                teNumeroEmergencia.Focus();
                return false;
            }
            return true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bt_menuusuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_User fu = new Form_User();
            fu.ShowDialog();
            this.Close();
        }
    }
}