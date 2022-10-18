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
using Respaldo_Restauracion_Exportar_Excell;

namespace Clinica
{
    public partial class Form_ListaPacientes : DevExpress.XtraEditors.XtraForm
    {
        private bool _usuarioconfig;
        bool aux;
        public Form_ListaPacientes()
        {
            InitializeComponent();
        }

        public bool UsuarioConfig
        {
            set
            {
                _usuarioconfig = value;
                aux = _usuarioconfig;
            }
        }

        private void Form_ListaPacientes_Load(object sender, EventArgs e)
        {
            if (aux == true)
            {
                te_menu.Dispose();
                bt_exportar.Dispose();
            }else
                bt_close.Dispose();
               
        }
    
        private void searchLookUpEdit1_EditValueChanged_1(object sender, EventArgs e)
        {
            Paciente line = (Paciente)searchLookUpEdit1View.GetFocusedRow();
            var criterion = new GroupOperator() { OperatorType = GroupOperatorType.And };

            criterion.Operands.Add(
            new BinaryOperator("Paciente.paciente", line.Num_seguro, BinaryOperatorType.Equal));


            xpPa.Criteria = criterion;
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            if(aux == true)
            {
                this.Hide();
                Form_Paciente pac = new Form_Paciente();
                pac.UsConfNew = true;
                pac.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                Form_Paciente pac = new Form_Paciente();
                pac.ShowDialog();
                this.Close();
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        { 
                //Obtener el Objeto
                Paciente paci = (Paciente)gridView1.GetFocusedRow();

                Form_EditarPaciente formpac = new Form_EditarPaciente();
                formpac.paciente = paci;
                formpac.ShowDialog();

                xpPac.Reload();
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            //obtener el objeto seleccionado
            Paciente paci = (Paciente)gridView1.GetFocusedRow();

            //Confirmar el eliminar
            DialogResult d = MessageBox.Show("Esta seguro que desea eliminar este paciente?",
                "Eliminando Paciente",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );

            if (d == DialogResult.Cancel) return;

            //Eliminar el Objeto Seleccionado
            unitOfWork1.Delete(paci);

            //Guardando Cambios en la base de datos
            unitOfWork1.CommitChanges();

            //Actualizar Tabla
            xpPac.Reload();

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

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

            exportar.imprimirGridView("Lista de Pacientes", DateTime.Today.ToShortDateString(), gridView1);

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}