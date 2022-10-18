namespace Clinica
{
    partial class Form_User
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
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.bt_lista = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.bt_signos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.te_campass = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.label3 = new System.Windows.Forms.Label();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.log_out = new DevExpress.XtraBars.BarListItem();
            this.bt_logout = new DevExpress.XtraBars.BarButtonItem();
            this.btn_cerrar = new DevExpress.XtraBars.BarButtonItem();
            this.te_cerrar = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.fluentDesignFormControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(48, 31);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(643, 442);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.bt_lista,
            this.bt_signos,
            this.accordionControlElement1,
            this.te_campass});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(250, 442);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // bt_lista
            // 
            this.bt_lista.Name = "bt_lista";
            this.bt_lista.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.bt_lista.Text = "Lista Paciente";
            this.bt_lista.Click += new System.EventHandler(this.bt_lista_Click);
            // 
            // bt_signos
            // 
            this.bt_signos.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.bt_signos.Name = "bt_signos";
            this.bt_signos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.bt_signos.Text = "Signos Vitales";
            this.bt_signos.Click += new System.EventHandler(this.bt_signos_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Consulta";
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // te_campass
            // 
            this.te_campass.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.te_campass.Name = "te_campass";
            this.te_campass.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.te_campass.Text = "Cambiar Contraseña";
            this.te_campass.Click += new System.EventHandler(this.bt_cambiarpass_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Controls.Add(this.label3);
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.log_out,
            this.bt_logout,
            this.btn_cerrar,
            this.te_cerrar,
            this.barStaticItem2});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(691, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.btn_cerrar);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // log_out
            // 
            this.log_out.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.log_out.Caption = "Cerrar Sesión";
            this.log_out.Id = 1;
            this.log_out.Name = "log_out";
            // 
            // bt_logout
            // 
            this.bt_logout.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bt_logout.Caption = "barButtonItem1";
            this.bt_logout.Id = 2;
            this.bt_logout.Name = "bt_logout";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_cerrar.Border = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_cerrar.Caption = "Cerrar Sesión";
            this.btn_cerrar.Id = 3;
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_cerrar_ItemClick);
            // 
            // te_cerrar
            // 
            this.te_cerrar.Caption = "barStaticItem2";
            this.te_cerrar.Id = 4;
            this.te_cerrar.Name = "te_cerrar";
            this.te_cerrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Cerrar";
            this.barStaticItem2.Id = 5;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.log_out,
            this.bt_logout,
            this.btn_cerrar,
            this.te_cerrar,
            this.barStaticItem2});
            this.fluentFormDefaultManager1.MaxItemId = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label1,
            this.label2});
            this.statusStrip1.Location = new System.Drawing.Point(250, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(441, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.Text = "toolStripStatusLabel1";
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.Text = "toolStripStatusLabel3";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabbedMdiManager1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.xtraTabbedMdiManager1.Appearance.Options.UseFont = true;
            this.xtraTabbedMdiManager1.Appearance.Options.UseForeColor = true;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form_User
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 473);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "Form_User";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Usuario";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.fluentDesignFormControl1.ResumeLayout(false);
            this.fluentDesignFormControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement bt_lista;
        private DevExpress.XtraBars.Navigation.AccordionControlElement bt_signos;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarListItem log_out;
        private DevExpress.XtraBars.BarButtonItem bt_logout;
        private DevExpress.XtraBars.BarButtonItem btn_cerrar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.BarStaticItem te_cerrar;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement te_campass;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label1;
        private System.Windows.Forms.ToolStripStatusLabel label2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.Label label3;
    }
}