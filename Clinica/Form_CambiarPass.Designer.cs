namespace Clinica
{
    partial class Form_CambiarPass
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.bt_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.bt_menu = new DevExpress.XtraEditors.SimpleButton();
            this.te_conpass = new DevExpress.XtraEditors.TextEdit();
            this.te_pass = new DevExpress.XtraEditors.TextEdit();
            this.te_usuarioe = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator4 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator5 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator6 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator7 = new DevExpress.XtraLayout.SimpleSeparator();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_conpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_usuarioe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.bt_guardar);
            this.layoutControl1.Controls.Add(this.bt_menu);
            this.layoutControl1.Controls.Add(this.te_conpass);
            this.layoutControl1.Controls.Add(this.te_pass);
            this.layoutControl1.Controls.Add(this.te_usuarioe);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(510, 127);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(243, 98);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(238, 22);
            this.bt_guardar.StyleController = this.layoutControl1;
            this.bt_guardar.TabIndex = 7;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // bt_menu
            // 
            this.bt_menu.Location = new System.Drawing.Point(12, 98);
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.Size = new System.Drawing.Size(226, 22);
            this.bt_menu.StyleController = this.layoutControl1;
            this.bt_menu.TabIndex = 6;
            this.bt_menu.Text = "Menú";
            this.bt_menu.Click += new System.EventHandler(this.bt_menu_Click);
            // 
            // te_conpass
            // 
            this.te_conpass.Location = new System.Drawing.Point(121, 72);
            this.te_conpass.Name = "te_conpass";
            this.te_conpass.Size = new System.Drawing.Size(360, 20);
            this.te_conpass.StyleController = this.layoutControl1;
            this.te_conpass.TabIndex = 5;
            // 
            // te_pass
            // 
            this.te_pass.Location = new System.Drawing.Point(121, 38);
            this.te_pass.Name = "te_pass";
            this.te_pass.Size = new System.Drawing.Size(360, 20);
            this.te_pass.StyleController = this.layoutControl1;
            this.te_pass.TabIndex = 4;
            // 
            // te_usuarioe
            // 
            this.te_usuarioe.Enabled = false;
            this.te_usuarioe.Location = new System.Drawing.Point(121, 12);
            this.te_usuarioe.Name = "te_usuarioe";
            this.te_usuarioe.Properties.Mask.EditMask = "n";
            this.te_usuarioe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.te_usuarioe.Size = new System.Drawing.Size(360, 20);
            this.te_usuarioe.StyleController = this.layoutControl1;
            this.te_usuarioe.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.simpleSeparator1,
            this.emptySpaceItem1,
            this.simpleSeparator2,
            this.simpleSeparator3,
            this.simpleSeparator4,
            this.simpleSeparator5,
            this.simpleSeparator6,
            this.layoutControlItem5,
            this.simpleSeparator7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(493, 134);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.te_pass;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(473, 24);
            this.layoutControlItem1.Text = "Nueva Contraseña:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.te_conpass;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(473, 24);
            this.layoutControlItem2.Text = "Confirmar Contraseña";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.bt_menu;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 86);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(230, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.bt_guardar;
            this.layoutControlItem4.Location = new System.Drawing.Point(231, 86);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(242, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 112);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(473, 1);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 50);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(473, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 84);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(473, 1);
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.Location = new System.Drawing.Point(230, 86);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(1, 26);
            // 
            // simpleSeparator4
            // 
            this.simpleSeparator4.AllowHotTrack = false;
            this.simpleSeparator4.Location = new System.Drawing.Point(0, 85);
            this.simpleSeparator4.Name = "simpleSeparator4";
            this.simpleSeparator4.Size = new System.Drawing.Size(473, 1);
            // 
            // simpleSeparator5
            // 
            this.simpleSeparator5.AllowHotTrack = false;
            this.simpleSeparator5.Location = new System.Drawing.Point(0, 113);
            this.simpleSeparator5.Name = "simpleSeparator5";
            this.simpleSeparator5.Size = new System.Drawing.Size(473, 1);
            // 
            // simpleSeparator6
            // 
            this.simpleSeparator6.AllowHotTrack = false;
            this.simpleSeparator6.Location = new System.Drawing.Point(0, 25);
            this.simpleSeparator6.Name = "simpleSeparator6";
            this.simpleSeparator6.Size = new System.Drawing.Size(473, 1);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.te_usuarioe;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(473, 24);
            this.layoutControlItem5.Text = "Usuario:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(106, 13);
            // 
            // simpleSeparator7
            // 
            this.simpleSeparator7.AllowHotTrack = false;
            this.simpleSeparator7.Location = new System.Drawing.Point(0, 24);
            this.simpleSeparator7.Name = "simpleSeparator7";
            this.simpleSeparator7.Size = new System.Drawing.Size(473, 1);
            // 
            // Form_CambiarPass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(510, 127);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form_CambiarPass";
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.Form_CambiarPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.te_conpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_usuarioe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton bt_guardar;
        private DevExpress.XtraEditors.SimpleButton bt_menu;
        private DevExpress.XtraEditors.TextEdit te_conpass;
        private DevExpress.XtraEditors.TextEdit te_pass;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator4;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraEditors.TextEdit te_usuarioe;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator5;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator7;
    }
}