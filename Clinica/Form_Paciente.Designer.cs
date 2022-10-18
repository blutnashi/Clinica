namespace Clinica
{
    partial class Form_Paciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Paciente));
            this.menuprincipal = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teNumeroEmergencia = new DevExpress.XtraEditors.TextEdit();
            this.teNombres = new DevExpress.XtraEditors.TextEdit();
            this.teApellidos = new DevExpress.XtraEditors.TextEdit();
            this.teCedula = new DevExpress.XtraEditors.TextEdit();
            this.teFchaNac = new DevExpress.XtraEditors.TextEdit();
            this.teCelular = new DevExpress.XtraEditors.TextEdit();
            this.teNumSeguro = new DevExpress.XtraEditors.TextEdit();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.xpPaciente = new DevExpress.Xpo.XPCollection(this.components);
            this.bt_menuusuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teNumeroEmergencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNombres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teApellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFchaNac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCelular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumSeguro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // menuprincipal
            // 
            this.menuprincipal.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuprincipal.Appearance.Options.UseForeColor = true;
            this.menuprincipal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuprincipal.ImageOptions.Image")));
            this.menuprincipal.Location = new System.Drawing.Point(134, 344);
            this.menuprincipal.Name = "menuprincipal";
            this.menuprincipal.Size = new System.Drawing.Size(124, 23);
            this.menuprincipal.TabIndex = 40;
            this.menuprincipal.Text = "Menú Principal";
            this.menuprincipal.Click += new System.EventHandler(this.menuprincipal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(131, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Número de Emergencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(131, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Nombres";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(131, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(131, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(131, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(131, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Número telefónico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(131, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Número de Seguro";
            // 
            // teNumeroEmergencia
            // 
            this.teNumeroEmergencia.Location = new System.Drawing.Point(261, 284);
            this.teNumeroEmergencia.Name = "teNumeroEmergencia";
            this.teNumeroEmergencia.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teNumeroEmergencia.Properties.Appearance.Options.UseForeColor = true;
            this.teNumeroEmergencia.Properties.Mask.BeepOnError = true;
            this.teNumeroEmergencia.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d\\d-\\d\\d\\d\\d";
            this.teNumeroEmergencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.teNumeroEmergencia.Properties.MaxLength = 15;
            this.teNumeroEmergencia.Size = new System.Drawing.Size(135, 20);
            this.teNumeroEmergencia.TabIndex = 32;
            // 
            // teNombres
            // 
            this.teNombres.Location = new System.Drawing.Point(261, 64);
            this.teNombres.Name = "teNombres";
            this.teNombres.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teNombres.Properties.Appearance.Options.UseForeColor = true;
            this.teNombres.Properties.Mask.EditMask = "c";
            this.teNombres.Properties.MaxLength = 20;
            this.teNombres.Size = new System.Drawing.Size(135, 20);
            this.teNombres.TabIndex = 31;
            // 
            // teApellidos
            // 
            this.teApellidos.Location = new System.Drawing.Point(261, 104);
            this.teApellidos.Name = "teApellidos";
            this.teApellidos.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teApellidos.Properties.Appearance.Options.UseForeColor = true;
            this.teApellidos.Properties.MaxLength = 20;
            this.teApellidos.Size = new System.Drawing.Size(135, 20);
            this.teApellidos.TabIndex = 30;
            // 
            // teCedula
            // 
            this.teCedula.Location = new System.Drawing.Point(261, 147);
            this.teCedula.Name = "teCedula";
            this.teCedula.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teCedula.Properties.Appearance.Options.UseForeColor = true;
            this.teCedula.Properties.MaxLength = 14;
            this.teCedula.Size = new System.Drawing.Size(135, 20);
            this.teCedula.TabIndex = 29;
            // 
            // teFchaNac
            // 
            this.teFchaNac.Location = new System.Drawing.Point(261, 193);
            this.teFchaNac.Name = "teFchaNac";
            this.teFchaNac.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teFchaNac.Properties.Appearance.Options.UseForeColor = true;
            this.teFchaNac.Properties.Mask.BeepOnError = true;
            this.teFchaNac.Properties.Mask.EditMask = "d";
            this.teFchaNac.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.teFchaNac.Size = new System.Drawing.Size(135, 20);
            this.teFchaNac.TabIndex = 28;
            // 
            // teCelular
            // 
            this.teCelular.Location = new System.Drawing.Point(261, 237);
            this.teCelular.Name = "teCelular";
            this.teCelular.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teCelular.Properties.Appearance.Options.UseForeColor = true;
            this.teCelular.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d\\d-\\d\\d\\d\\d";
            this.teCelular.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.teCelular.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.teCelular.Properties.MaxLength = 15;
            this.teCelular.Size = new System.Drawing.Size(135, 20);
            this.teCelular.TabIndex = 27;
            // 
            // teNumSeguro
            // 
            this.teNumSeguro.Location = new System.Drawing.Point(261, 31);
            this.teNumSeguro.Name = "teNumSeguro";
            this.teNumSeguro.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teNumSeguro.Properties.Appearance.Options.UseForeColor = true;
            this.teNumSeguro.Properties.Mask.EditMask = "d";
            this.teNumSeguro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teNumSeguro.Properties.MaxLength = 11;
            this.teNumSeguro.Size = new System.Drawing.Size(135, 20);
            this.teNumSeguro.TabIndex = 26;
            this.teNumSeguro.EditValueChanged += new System.EventHandler(this.teNumSeguro_EditValueChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Appearance.Options.UseForeColor = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(300, 344);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 23);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // xpPaciente
            // 
            this.xpPaciente.Session = this.unitOfWork1;
            // 
            // bt_menuusuario
            // 
            this.bt_menuusuario.ForeColor = System.Drawing.Color.Black;
            this.bt_menuusuario.Location = new System.Drawing.Point(458, 2);
            this.bt_menuusuario.Name = "bt_menuusuario";
            this.bt_menuusuario.Size = new System.Drawing.Size(75, 23);
            this.bt_menuusuario.TabIndex = 41;
            this.bt_menuusuario.Text = "Menú";
            this.bt_menuusuario.UseVisualStyleBackColor = true;
            this.bt_menuusuario.Click += new System.EventHandler(this.bt_menuusuario_Click);
            // 
            // Form_Paciente
            // 
            this.AcceptButton = this.btnGuardar;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 445);
            this.ControlBox = false;
            this.Controls.Add(this.bt_menuusuario);
            this.Controls.Add(this.menuprincipal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teNumeroEmergencia);
            this.Controls.Add(this.teNombres);
            this.Controls.Add(this.teApellidos);
            this.Controls.Add(this.teCedula);
            this.Controls.Add(this.teFchaNac);
            this.Controls.Add(this.teCelular);
            this.Controls.Add(this.teNumSeguro);
            this.Controls.Add(this.btnGuardar);
            this.IconOptions.ShowIcon = false;
            this.Name = "Form_Paciente";
            this.Text = "Formulario de Nuevo Paciente";
            this.Load += new System.EventHandler(this.Form_Paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teNumeroEmergencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNombres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teApellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFchaNac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCelular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNumSeguro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton menuprincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit teNumeroEmergencia;
        private DevExpress.XtraEditors.TextEdit teNombres;
        private DevExpress.XtraEditors.TextEdit teApellidos;
        private DevExpress.XtraEditors.TextEdit teCedula;
        private DevExpress.XtraEditors.TextEdit teFchaNac;
        private DevExpress.XtraEditors.TextEdit teCelular;
        private DevExpress.XtraEditors.TextEdit teNumSeguro;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPCollection xpPaciente;
        private System.Windows.Forms.Button bt_menuusuario;
    }
}