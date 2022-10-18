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
using DevExpress.Data.Filtering;
using Respaldo_Restauracion_Exportar_Excell;

namespace Clinica
{
    public partial class Form_ListaPersonal : DevExpress.XtraEditors.XtraForm
    {
        public Form_ListaPersonal()
        {
            InitializeComponent();
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Medico line = (Medico)searchLookUpEdit1View.GetFocusedRow();
            var criterion = new GroupOperator() { OperatorType = GroupOperatorType.And };

            criterion.Operands.Add(
            new BinaryOperator("Paciente.paciente", line.Id_medi, BinaryOperatorType.Equal));


            xpPer.Criteria = criterion;
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Medico medi = new Form_Medico();
            medi.ShowDialog();
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {

        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            //obtener el objeto seleccionado
            Medico medi = (Medico)gridView1.GetFocusedRow();

            //Confirmar el eliminar
            DialogResult d = MessageBox.Show("Esta seguro que desea eliminar este personal medico?",
                "Eliminando Personal Medico",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );

            if (d == DialogResult.Cancel) return;

            //Eliminar el Objeto Seleccionado
            unitOfWork1.Delete(xpPersonal);

            //Guardando Cambios en la base de datos
            unitOfWork1.CommitChanges();

            //Actualizar Tabla
            xpPersonal.Reload();
        }

        private void te_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Admin admin = new Form_Admin();
            admin.ShowDialog();
        }

        private void bt_exportar_Click(object sender, EventArgs e)
        {
            //exportar
            csimprimirgridview exportar = new csimprimirgridview();

            exportar.imprimirGridView("Lista del Personal Medico", DateTime.Today.ToShortDateString(), gridView1);

        }
    }
}