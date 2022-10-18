namespace Clinica
{
    partial class Form_NewAdmin
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
            this.btn_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_menu = new DevExpress.XtraEditors.SimpleButton();
            this.te_compass = new DevExpress.XtraEditors.TextEdit();
            this.te_pass = new DevExpress.XtraEditors.TextEdit();
            this.te_user = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.user = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator5 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator6 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator7 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator4 = new DevExpress.XtraLayout.SimpleSeparator();
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_compass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_user.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btn_guardar);
            this.layoutControl1.Controls.Add(this.btn_menu);
            this.layoutControl1.Controls.Add(this.te_compass);
            this.layoutControl1.Controls.Add(this.te_pass);
            this.layoutControl1.Controls.Add(this.te_user);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(374, 152);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(190, 117);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(172, 22);
            this.btn_guardar.StyleController = this.layoutControl1;
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(12, 117);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(173, 22);
            this.btn_menu.StyleController = this.layoutControl1;
            this.btn_menu.TabIndex = 7;
            this.btn_menu.Text = "Regraser al menú";
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // te_compass
            // 
            this.te_compass.Location = new System.Drawing.Point(125, 63);
            this.te_compass.Name = "te_compass";
            this.te_compass.Properties.UseSystemPasswordChar = true;
            this.te_compass.Size = new System.Drawing.Size(237, 20);
            this.te_compass.StyleController = this.layoutControl1;
            this.te_compass.TabIndex = 6;
            // 
            // te_pass
            // 
            this.te_pass.Location = new System.Drawing.Point(125, 38);
            this.te_pass.Name = "te_pass";
            this.te_pass.Properties.UseSystemPasswordChar = true;
            this.te_pass.Size = new System.Drawing.Size(237, 20);
            this.te_pass.StyleController = this.layoutControl1;
            this.te_pass.TabIndex = 5;
            // 
            // te_user
            // 
            this.te_user.Location = new System.Drawing.Point(125, 13);
            this.te_user.Name = "te_user";
            this.te_user.Properties.MaxLength = 4;
            this.te_user.Size = new System.Drawing.Size(237, 20);
            this.te_user.StyleController = this.layoutControl1;
            this.te_user.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.user,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.simpleSeparator1,
            this.emptySpaceItem1,
            this.simpleSeparator2,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.simpleSeparator5,
            this.simpleSeparator3,
            this.simpleSeparator6,
            this.simpleSeparator7,
            this.simpleSeparator4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(374, 152);
            this.Root.TextVisible = false;
            // 
            // user
            // 
            this.user.Control = this.te_user;
            this.user.Location = new System.Drawing.Point(0, 1);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(354, 24);
            this.user.Text = "Nuevo Usuario:";
            this.user.TextSize = new System.Drawing.Size(110, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_menu;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 105);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(177, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btn_guardar;
            this.layoutControlItem5.Location = new System.Drawing.Point(178, 105);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(176, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 131);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(354, 1);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 75);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(354, 28);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 104);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(354, 1);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.te_pass;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(354, 24);
            this.layoutControlItem2.Text = "Nuevo Contraseña:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(110, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.te_compass;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 51);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(354, 24);
            this.layoutControlItem3.Text = "Confirmar Contraseña:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(110, 13);
            // 
            // simpleSeparator5
            // 
            this.simpleSeparator5.AllowHotTrack = false;
            this.simpleSeparator5.Location = new System.Drawing.Point(0, 25);
            this.simpleSeparator5.Name = "simpleSeparator5";
            this.simpleSeparator5.Size = new System.Drawing.Size(354, 1);
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.Location = new System.Drawing.Point(0, 50);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(354, 1);
            // 
            // simpleSeparator6
            // 
            this.simpleSeparator6.AllowHotTrack = false;
            this.simpleSeparator6.Location = new System.Drawing.Point(177, 105);
            this.simpleSeparator6.Name = "simpleSeparator6";
            this.simpleSeparator6.Size = new System.Drawing.Size(1, 26);
            // 
            // simpleSeparator7
            // 
            this.simpleSeparator7.AllowHotTrack = false;
            this.simpleSeparator7.Location = new System.Drawing.Point(0, 103);
            this.simpleSeparator7.Name = "simpleSeparator7";
            this.simpleSeparator7.Size = new System.Drawing.Size(354, 1);
            // 
            // simpleSeparator4
            // 
            this.simpleSeparator4.AllowHotTrack = false;
            this.simpleSeparator4.Location = new System.Drawing.Point(0, 0);
            this.simpleSeparator4.Name = "simpleSeparator4";
            this.simpleSeparator4.Size = new System.Drawing.Size(354, 1);
            // 
            // Form_NewAdmin
            // 
            this.AcceptButton = this.btn_guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 152);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_NewAdmin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Usuario Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form_NewAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.te_compass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_user.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btn_guardar;
        private DevExpress.XtraEditors.SimpleButton btn_menu;
        private DevExpress.XtraEditors.TextEdit te_compass;
        private DevExpress.XtraEditors.TextEdit te_pass;
        private DevExpress.XtraEditors.TextEdit te_user;
        private DevExpress.XtraLayout.LayoutControlItem user;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator5;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator6;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator7;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator4;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
    }
}