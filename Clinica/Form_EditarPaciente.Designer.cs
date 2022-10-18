namespace Clinica
{
    partial class Form_EditarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditarPaciente));
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Número de Emergencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Nombres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Número telefónico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Número de Seguro";
            // 
            // teNumeroEmergencia
            // 
            this.teNumeroEmergencia.Location = new System.Drawing.Point(252, 291);
            this.teNumeroEmergencia.Name = "teNumeroEmergencia";
            this.teNumeroEmergencia.Properties.Mask.BeepOnError = true;
            this.teNumeroEmergencia.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d\\d-\\d\\d\\d\\d";
            this.teNumeroEmergencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.teNumeroEmergencia.Size = new System.Drawing.Size(135, 20);
            this.teNumeroEmergencia.TabIndex = 48;
            // 
            // teNombres
            // 
            this.teNombres.Location = new System.Drawing.Point(252, 75);
            this.teNombres.Name = "teNombres";
            this.teNombres.Properties.Mask.EditMask = "c";
            this.teNombres.Size = new System.Drawing.Size(135, 20);
            this.teNombres.TabIndex = 47;
            // 
            // teApellidos
            // 
            this.teApellidos.Location = new System.Drawing.Point(252, 115);
            this.teApellidos.Name = "teApellidos";
            this.teApellidos.Size = new System.Drawing.Size(135, 20);
            this.teApellidos.TabIndex = 46;
            // 
            // teCedula
            // 
            this.teCedula.Location = new System.Drawing.Point(252, 154);
            this.teCedula.Name = "teCedula";
            this.teCedula.Properties.MaxLength = 14;
            this.teCedula.Size = new System.Drawing.Size(135, 20);
            this.teCedula.TabIndex = 45;
            // 
            // teFchaNac
            // 
            this.teFchaNac.Location = new System.Drawing.Point(252, 200);
            this.teFchaNac.Name = "teFchaNac";
            this.teFchaNac.Properties.Mask.BeepOnError = true;
            this.teFchaNac.Properties.Mask.EditMask = "d";
            this.teFchaNac.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.teFchaNac.Size = new System.Drawing.Size(135, 20);
            this.teFchaNac.TabIndex = 44;
            // 
            // teCelular
            // 
            this.teCelular.Location = new System.Drawing.Point(252, 244);
            this.teCelular.Name = "teCelular";
            this.teCelular.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d\\d-\\d\\d\\d\\d";
            this.teCelular.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.teCelular.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.teCelular.Size = new System.Drawing.Size(135, 20);
            this.teCelular.TabIndex = 43;
            // 
            // teNumSeguro
            // 
            this.teNumSeguro.Location = new System.Drawing.Point(252, 42);
            this.teNumSeguro.Name = "teNumSeguro";
            this.teNumSeguro.Properties.Mask.EditMask = "d";
            this.teNumSeguro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teNumSeguro.Size = new System.Drawing.Size(135, 20);
            this.teNumSeguro.TabIndex = 42;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(445, 35);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 23);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // xpPaciente
            // 
            this.xpPaciente.Session = this.unitOfWork1;
            // 
            // Form_EditarPaciente
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 371);
            this.ControlBox = false;
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
            this.Name = "Form_EditarPaciente";
            this.Text = "Editar Paciente";
            this.Load += new System.EventHandler(this.Form_EditarPaciente_Load);
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
    }
}