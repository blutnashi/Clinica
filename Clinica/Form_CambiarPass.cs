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
    public partial class Form_CambiarPass : DevExpress.XtraEditors.XtraForm
    {
        ErrorProvider error;
        public User use;
        public Medico med;
        private string _un;
        

        public Form_CambiarPass()
        {
            InitializeComponent();
        }
        private void Form_CambiarPass_Load(object sender, EventArgs e)
        {
            error = new ErrorProvider();
            
            
        }
        public string Un
        {
            set
            {
                _un = value;
                te_usuarioe.Text = _un;
            }
        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form_User nu = new Form_User();
            nu.ShowDialog();
        }

        private void bt_guardar_Click(object sender, EventArgs e)   
        {
            if (validar())
            {
                if (te_pass.Text == te_conpass.Text)
                {
                    use.Id = Convert.ToInt32(te_usuarioe.Text);
                    use.Password = te_pass.Text;


                    use.Save();

                    unitOfWork1.CommitChanges();
                    MessageBox.Show("Guardado Correctamente");
                }
                else
                    MessageBox.Show("Las contraseñas son diferentes");
            }
        }

        bool validar()
        {
            if (te_pass.Text.Length == 0)
            {
                error.SetError(te_pass, "Debe escribir la contraseña nueva");
                return false;
            }
            if (te_conpass.Text.Length == 0)
            {
                error.SetError(te_conpass, "Debe la confirmacion de la contraseña");
                return false;
            }
            return true;
        }
    }
}