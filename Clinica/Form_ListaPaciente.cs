using Clinica.consulta_externa;
using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Form_SignosVitales : DevExpress.XtraEditors.XtraForm
    {
        public Form_SignosVitales()
        {
            InitializeComponent();
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Paciente line = (Paciente)searchLookUpEdit1View.GetFocusedRow();
            var criterion = new GroupOperator() { OperatorType = GroupOperatorType.And };

            criterion.Operands.Add(
            new BinaryOperator("ProductLine.ProductLine", line.Num_seguro, BinaryOperatorType.Equal));


            xpSignosV.Criteria = criterion;
        } 

       
    }
}