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
using DevExpress.Data.Filtering;
using Clinica.Database;

namespace Clinica
{
    public partial class Form_Signos : DevExpress.XtraEditors.XtraForm
    {
        ErrorProvider error;
        private bool _ussignos;
        bool aux;
        public Form_Signos()
        {
            InitializeComponent();
        }

        public bool UsSignos
        {
            set
            {
                _ussignos = value;
                aux = _ussignos;
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Paciente line = (Paciente)searchLookUpEdit1View.GetFocusedRow();
            var criterion = new GroupOperator() { OperatorType = GroupOperatorType.And };

            criterion.Operands.Add(
            new BinaryOperator("Paciente.paciente", line.Num_seguro, BinaryOperatorType.Equal));


            xpPac.Criteria = criterion;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Paciente paci = (Paciente)gridView1.GetFocusedRow();
            if (validar()) {
            Signosvitales sv = new Signosvitales(unitOfWork1)
            {
                Id_sv = Convert.ToInt32(te_id.Text),
                Idpaciente = paci,
                Peso = Convert.ToInt32(te_peso.Text),
                Presion = te_presion.Text,
                Talla = Convert.ToInt32(te_talla.Text),
                Temperatura = te_temperatura.Text,
                Estatura = Convert.ToInt32(te_estatura.Text),
                Observaciones = te_observaciones.Text
            };

            sv.Save();

            unitOfWork1.CommitChanges();
            MessageBox.Show("Datos Guardado Correctamente");
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Admin admin = new Form_Admin();
            admin.ShowDialog();
        }

        bool validar()
        {
            if (te_id.Text.Length == 0)
            {
                error.SetError(te_id, "Debe escribir un numero");
                return false;
            }
            if (te_peso.Text.Length == 0)
            {
                error.SetError(te_peso, "Debe escribir el peso");
                return false;
            }
            if (te_presion.Text.Length == 0)
            {
                error.SetError(te_presion, "Debe ingresar la presion");
                return false;
            }
            if (te_talla.Text.Length == 0)
            {
                error.SetError(te_talla, "Debe ingresar la talla");
                return false;
            }
            if (te_temperatura.Text.Length == 0)
            {
                error.SetError(te_temperatura, "Debe ingresar la temperatura");
                return false;
            }
            if (te_estatura.Text.Length == 0)
            {
                error.SetError(te_estatura, "Debe ingresar la estatura");
                return false;
            }
            return true;
        }

        private void Form_Signos_Load(object sender, EventArgs e)
        {
            error = new ErrorProvider();
            if (aux == true)
                btn_menu.Dispose();
            else
                bt_cerrar.Dispose();
            
        }

        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}