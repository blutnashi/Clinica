namespace Clinica
{
    partial class Form_Medico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_backtomenu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Guardar = new DevExpress.XtraEditors.SimpleButton();
            this.te_especialidad = new DevExpress.XtraEditors.TextEdit();
            this.te_Apellido = new DevExpress.XtraEditors.TextEdit();
            this.te_Nombre = new DevExpress.XtraEditors.TextEdit();
            this.te_idcodigo = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xpMedico = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.te_especialidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Apellido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Nombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_idcodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backtomenu
            // 
            this.btn_backtomenu.Location = new System.Drawing.Point(88, 227);
            this.btn_backtomenu.Name = "btn_backtomenu";
            this.btn_backtomenu.Size = new System.Drawing.Size(79, 23);
            this.btn_backtomenu.TabIndex = 19;
            this.btn_backtomenu.Text = "Menú Inicial";
            this.btn_backtomenu.Click += new System.EventHandler(this.btn_backtomenu_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(233, 227);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(84, 23);
            this.btn_Guardar.TabIndex = 18;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // te_especialidad
            // 
            this.te_especialidad.Location = new System.Drawing.Point(176, 162);
            this.te_especialidad.Name = "te_especialidad";
            this.te_especialidad.Properties.MaxLength = 15;
            this.te_especialidad.Size = new System.Drawing.Size(141, 20);
            this.te_especialidad.TabIndex = 17;
            // 
            // te_Apellido
            // 
            this.te_Apellido.Location = new System.Drawing.Point(176, 125);
            this.te_Apellido.Name = "te_Apellido";
            this.te_Apellido.Properties.MaxLength = 20;
            this.te_Apellido.Size = new System.Drawing.Size(141, 20);
            this.te_Apellido.TabIndex = 16;
            // 
            // te_Nombre
            // 
            this.te_Nombre.Location = new System.Drawing.Point(176, 85);
            this.te_Nombre.Name = "te_Nombre";
            this.te_Nombre.Properties.MaxLength = 20;
            this.te_Nombre.Size = new System.Drawing.Size(141, 20);
            this.te_Nombre.TabIndex = 15;
            // 
            // te_idcodigo
            // 
            this.te_idcodigo.Location = new System.Drawing.Point(176, 50);
            this.te_idcodigo.Name = "te_idcodigo";
            this.te_idcodigo.Properties.MaxLength = 4;
            this.te_idcodigo.Size = new System.Drawing.Size(141, 20);
            this.te_idcodigo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Especialidad";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(85, 132);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(44, 13);
            this.Apellido.TabIndex = 12;
            this.Apellido.Text = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(85, 92);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 11;
            this.Nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código";
            // 
            // xpMedico
            // 
            this.xpMedico.ObjectType = typeof(Clinica.Database.Medico);
            this.xpMedico.Session = this.unitOfWork1;
            // 
            // Form_Medico
            // 
            this.AcceptButton = this.btn_Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 337);
            this.ControlBox = false;
            this.Controls.Add(this.btn_backtomenu);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.te_especialidad);
            this.Controls.Add(this.te_Apellido);
            this.Controls.Add(this.te_Nombre);
            this.Controls.Add(this.te_idcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.IconOptions.ShowIcon = false;
            this.Name = "Form_Medico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Nuevo Personal Medico";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form_Medico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.te_especialidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Apellido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Nombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_idcodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_backtomenu;
        private DevExpress.XtraEditors.SimpleButton btn_Guardar;
        private DevExpress.XtraEditors.TextEdit te_especialidad;
        private DevExpress.XtraEditors.TextEdit te_Apellido;
        private DevExpress.XtraEditors.TextEdit te_Nombre;
        private DevExpress.XtraEditors.TextEdit te_idcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label1;
        private DevExpress.Xpo.XPCollection xpMedico;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
    }
}