namespace Clinica
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.btn_ingresar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.te_user = new DevExpress.XtraEditors.TextEdit();
            this.te_password = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.te_user.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.Appearance.Options.UseFont = true;
            this.btn_ingresar.Location = new System.Drawing.Point(273, 182);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_ingresar.TabIndex = 0;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Appearance.Options.UseFont = true;
            this.btn_cancelar.Location = new System.Drawing.Point(169, 182);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(118, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Código de Usuario:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(28, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Contraseña:";
            // 
            // te_user
            // 
            this.te_user.Location = new System.Drawing.Point(169, 75);
            this.te_user.Name = "te_user";
            this.te_user.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.te_user.Properties.Appearance.Options.UseFont = true;
            this.te_user.Properties.Appearance.Options.UseTextOptions = true;
            this.te_user.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.te_user.Size = new System.Drawing.Size(179, 26);
            this.te_user.TabIndex = 4;
            // 
            // te_password
            // 
            this.te_password.Location = new System.Drawing.Point(169, 119);
            this.te_password.Name = "te_password";
            this.te_password.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.te_password.Properties.Appearance.Options.UseFont = true;
            this.te_password.Properties.Appearance.Options.UseTextOptions = true;
            this.te_password.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.te_password.Properties.UseSystemPasswordChar = true;
            this.te_password.Size = new System.Drawing.Size(179, 26);
            this.te_password.TabIndex = 5;
            // 
            // Form_Login
            // 
            this.AcceptButton = this.btn_ingresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(629, 275);
            this.ControlBox = false;
            this.Controls.Add(this.te_password);
            this.Controls.Add(this.te_user);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_ingresar);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.Name = "Form_Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.te_user.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_ingresar;
        private DevExpress.XtraEditors.SimpleButton btn_cancelar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit te_user;
        private DevExpress.XtraEditors.TextEdit te_password;
    }
}