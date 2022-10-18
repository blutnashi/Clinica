using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Form_User : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {


        public Form_User()
        {
            InitializeComponent();
        }
        private string _u;
        public string U
        {
            set
            {
                _u = value;
                label1.Text = "Usuario: " + _u + " accedio exitosamente";
                label3.Text = _u;
            }
        }

        private void btn_cerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Restart();
        }


        public void ViewChildrenForm(Form _form)
        {
            if (!IsFormActived(_form))
            {
                _form.MdiParent = this;
                _form.Show();
            }
        }
        private void Form_User_Load(object sender, EventArgs e)
        {
            string tiempo = DateTime.Now.ToString("hh:mm:ss tt");
            label2.Text = "         Hora: " + tiempo;
        }

        private bool IsFormActived(Form form)
        {
            bool IsOpenend = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        IsOpenend = true;
                    }
                }
            }
            return IsOpenend;
        }
        private void bt_lista_Click(object sender, EventArgs e)
        {
            Form_ListaPacientes lp = new Form_ListaPacientes();
            lp.UsuarioConfig = true;
            ViewChildrenForm(lp);
        }
        private void bt_cambiarpass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_CambiarPass ca = new Form_CambiarPass();
            ca.Un = label3.Text;
            ca.ShowDialog();
        }

        private void bt_signos_Click(object sender, EventArgs e)
        {
            Form_Signos fsv = new Form_Signos();
            fsv.UsSignos = true;
            ViewChildrenForm(fsv);
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            Form_Consulta cu = new Form_Consulta();
            cu.UsConsulta = true;
            ViewChildrenForm(cu);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
