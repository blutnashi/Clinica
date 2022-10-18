using Respaldo_Restauracion_Exportar_Excell;
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
    public partial class Form_Admin : DevExpress.XtraEditors.XtraForm
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }


        private void sb_agregarpaciente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Paciente pac = new Form_Paciente();
            pac.ShowDialog();
        }

        private void sb_agregarmedico_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Medico med = new Form_Medico();
            med.ShowDialog();
        }

        private void sb_listapac_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ListaPacientes lp = new Form_ListaPacientes();
            lp.ShowDialog();
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void sb_signosvitales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Signos sv = new Form_Signos();
            sv.ShowDialog();
        }

        private void sb_consulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Consulta con = new Form_Consulta();
            con.ShowDialog();
        }

        private void barStaticItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void te_newuser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_NewUser nu = new Form_NewUser();
            nu.ShowDialog();
        }

        private void barStaticItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Backup.Respaldo();
        }

        private void barStaticItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Backup.Restauracion();
        }


        private void barToolbarsListItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("SB Inc, version 0.1");
        }

        private void bt_listapersonal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ListaPersonal lp = new Form_ListaPersonal();
            lp.ShowDialog();
        }

        private void barStaticItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}

