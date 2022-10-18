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
    public partial class Form_EditarPaciente : DevExpress.XtraEditors.XtraForm
    {
        ErrorProvider error;
        public Paciente paciente;
        public Form_EditarPaciente()
        {
            InitializeComponent();
        }

        private void Form_EditarPaciente_Load(object sender, EventArgs e)
        {
            error = new ErrorProvider();
            teNumSeguro.Text = paciente.Num_seguro.ToString();
            teNombres.Text = paciente.Nombre;
            teApellidos.Text = paciente.Apellido;
            teCedula.Text = paciente.Cedula;
            teFchaNac.Text = paciente.Fcha_nac.ToString();
            teCelular.Text = paciente.Telefono;
            teNumeroEmergencia.Text = paciente.Numero_emergencia;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            paciente.Num_seguro = Convert.ToInt32(teNumSeguro.Text);
            paciente.Nombre = teNombres.Text;
            paciente.Apellido = teApellidos.Text;
            paciente.Cedula = teCedula.Text;
            paciente.Fcha_nac = Convert.ToDateTime(teFchaNac.Text);
            paciente.Telefono = teCelular.Text;
            paciente.Numero_emergencia = teNumeroEmergencia.Text;

            paciente.Save();

            unitOfWork1.CommitChanges();
            MessageBox.Show("Paciente Guardado Correctamente");
            this.Close();
        }
    }
}