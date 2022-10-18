using System;
using System.Windows.Forms;
using Clinica.Database;
using DevExpress.Data.Filtering;
using DevExpress.XtraReports.UI;

namespace Clinica
{
    public partial class Form_Consulta : DevExpress.XtraEditors.XtraForm
    {
        ErrorProvider error;
        private bool _usconsulta;
        bool aux;
        public Form_Consulta()
        {
            InitializeComponent();
        }
        public bool UsConsulta
        {
            set
            {
                _usconsulta = value;
                aux = _usconsulta;
            }
        }
        

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Signosvitales sv = (Signosvitales)searchLookUpEdit1View.GetFocusedRow();
            var criterion = new GroupOperator() { OperatorType = GroupOperatorType.And };

            criterion.Operands.Add(
            new BinaryOperator("Paciente.paciente", sv.Id_sv, BinaryOperatorType.Equal));


            xp2.Criteria = criterion;
        }

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            Paciente line = (Paciente)searchLookUpEdit2View.GetFocusedRow();
            var criterion = new GroupOperator() { OperatorType = GroupOperatorType.And };

            criterion.Operands.Add(
            new BinaryOperator("Paciente.paciente", line.Num_seguro, BinaryOperatorType.Equal));


            xp1.Criteria = criterion;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Paciente paciente = (Paciente)gridView3.GetFocusedRow();
            Signosvitales vitales = (Signosvitales)gridView1.GetFocusedRow();


            if (validar()){
            Consulta con = new Consulta(unitOfWork1)
            {
                Id = Convert.ToInt32(te_id.Text),
                Paciente = paciente,
                Signosvitales = vitales,
                Fechahora = Convert.ToDateTime(te_fecha.Text),
                Observacion = te_observaciones.Text,
                Diagnostico = te_diagnostico.Text,
                Receta = te_recetas.Text
            };

            con.Save();

            unitOfWork1.CommitChanges();
            MessageBox.Show("Datos Guardado Correctamente");
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form_Admin menu = new Form_Admin();
            menu.ShowDialog();
        }

        private void Form_Consulta_Load(object sender, EventArgs e)
        {
            error = new ErrorProvider();
            if (aux == true)
                btn_menu.Dispose();
            else
                btn_cerrar.Dispose();
        }

        bool validar()
        {
            if (textEdit4.Text.Length == 0)
            {
                error.SetError(textEdit4, "Debe escribir un numero");
                textEdit4.Focus();
                return false;
            }
            if (dateEdit1.Text.Length == 0)
            {
                error.SetError(dateEdit1, "Debe seleccionar una fecha");
                dateEdit1.Focus();
                return false;
            }
            if (te_recetas.Text.Length == 0)
            {
                error.SetError(te_recetas, "Ingresar la receta");
                te_recetas.Focus();
                return false;
            }
            if (te_diagnostico.Text.Length == 0)
            {
                error.SetError(te_diagnostico, "Ingresar Diagnostico");
                te_diagnostico.Focus();
                return false;
            }
            return true;
        }
        
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            Report1 reportFactura = new Report1();
            
           // reportFactura.Parameters["Id"].Value = con;
            
            ReportPrintTool printTool = new ReportPrintTool(reportFactura);
            printTool.ShowPreview();

        }
        
    }
}