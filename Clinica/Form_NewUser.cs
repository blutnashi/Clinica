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

namespace Clinica
{
    public partial class Form_NewUser : DevExpress.XtraEditors.XtraForm
    {
        ErrorProvider error;
        public Form_NewUser()
        {
            InitializeComponent();
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Medico line = (Medico)searchLookUpEdit1View.GetFocusedRow();
            var criterion = new GroupOperator() { OperatorType = GroupOperatorType.And };

            criterion.Operands.Add(
            new BinaryOperator("Paciente.paciente", line.Id_medi, BinaryOperatorType.Equal));


            xpPersonal.Criteria = criterion;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Medico med = (Medico)gridView1.GetFocusedRow();
            if (validar()) {

            if (te_contraseña == te_confirmar) {
                User us = new User(unitOfWork1)
                {
                    Id = med.Id_medi,
                    Password = te_contraseña.ToString(),
                    Id_medi = med
                };
                    us.Save();

                    unitOfWork1.CommitChanges();
                    MessageBox.Show("Guardado Correctamente");
                } else
                MessageBox.Show("Las contraseñas son diferentes");
            }
            
        }

        private void Form_NewUser_Load(object sender, EventArgs e)
        {
            error = new ErrorProvider();
        }

        bool validar()
        {
            if (te_confirmar.Text.Length == 0)
            {
                error.SetError(te_confirmar, "Debe escribir un numero");
                return false;
            }
            if (te_contraseña.Text.Length == 0)
            {
                error.SetError(te_contraseña, "Debe escribir un numero");
                return false;
            }
            return true;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Admin fa = new Form_Admin();
            fa.ShowDialog();
        }
    }
}