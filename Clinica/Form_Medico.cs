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
    public partial class Form_Medico : DevExpress.XtraEditors.XtraForm
    {
        ErrorProvider error;
        public Form_Medico()
        {
            InitializeComponent();
        }

        private void btn_backtomenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form_Admin admin = new Form_Admin();
            admin.ShowDialog();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (validar()) {
            Medico med = new Medico(unitOfWork1)
            {
                Id_medi = Convert.ToInt32(te_idcodigo.Text),
                Nombre = te_Nombre.Text,
                Apellido = te_Apellido.Text,
                Especialidad = te_especialidad.Text
            };

            med.Save();

            unitOfWork1.CommitChanges();
            MessageBox.Show("Personal Medico Guardado Correctamente");

            }


        }

        private void Form_Medico_Load(object sender, EventArgs e)
        {
            error = new ErrorProvider();
        }

        bool validar()
        {
            if (te_idcodigo.Text.Length == 0)
            {
                error.SetError(te_idcodigo, "Debe ingresar un número de 4 digitos o menos");
                return false;
            }
            if (te_Nombre.Text.Length == 0)
            {
                error.SetError(te_Nombre, "Ingrese el nombre");
                return false;
            }
            if (te_Apellido.Text.Length == 0)
            {
                error.SetError(te_Apellido, "Ingrese el apellido");
                return false;
            }
            if (te_especialidad.Text.Length == 0)
            {
                error.SetError(te_especialidad, "Ingrese el Especialidad");
                return false;
            }
            return true;
        }
    }
}