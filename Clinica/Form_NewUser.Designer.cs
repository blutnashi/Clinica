namespace Clinica
{
    partial class Form_NewUser
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
            this.te_confirmar = new DevExpress.XtraEditors.TextEdit();
            this.btn_menu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.te_contraseña = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpPersonal = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_medi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEspecialidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bt_Contraseña = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xpPer = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_confirmar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_contraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Contraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPer)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.te_confirmar);
            this.layoutControl1.Controls.Add(this.btn_menu);
            this.layoutControl1.Controls.Add(this.btn_guardar);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.te_contraseña);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.searchLookUpEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(635, 337);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // te_confirmar
            // 
            this.te_confirmar.Location = new System.Drawing.Point(127, 276);
            this.te_confirmar.Name = "te_confirmar";
            this.te_confirmar.Properties.UseSystemPasswordChar = true;
            this.te_confirmar.Size = new System.Drawing.Size(496, 20);
            this.te_confirmar.StyleController = this.layoutControl1;
            this.te_confirmar.TabIndex = 12;
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(392, 301);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(231, 22);
            this.btn_menu.StyleController = this.layoutControl1;
            this.btn_menu.TabIndex = 11;
            this.btn_menu.Text = "Regresar al Menú";
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(12, 301);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(282, 22);
            this.btn_guardar.StyleController = this.layoutControl1;
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(276, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Seleccionar el personal médico que tendrá nuevo usuario.";
            // 
            // te_contraseña
            // 
            this.te_contraseña.Location = new System.Drawing.Point(127, 252);
            this.te_contraseña.Name = "te_contraseña";
            this.te_contraseña.Properties.UseSystemPasswordChar = true;
            this.te_contraseña.Size = new System.Drawing.Size(496, 20);
            this.te_contraseña.StyleController = this.layoutControl1;
            this.te_contraseña.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpPersonal;
            this.gridControl1.Location = new System.Drawing.Point(12, 53);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(611, 195);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpPersonal
            // 
            this.xpPersonal.ObjectType = typeof(Clinica.Database.Medico);
            this.xpPersonal.Session = this.unitOfWork1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_medi,
            this.colNombre,
            this.colApellido,
            this.colEspecialidad});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId_medi
            // 
            this.colId_medi.FieldName = "Id_medi";
            this.colId_medi.Name = "colId_medi";
            this.colId_medi.Visible = true;
            this.colId_medi.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colApellido
            // 
            this.colApellido.FieldName = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 2;
            // 
            // colEspecialidad
            // 
            this.colEspecialidad.FieldName = "Especialidad";
            this.colEspecialidad.Name = "colEspecialidad";
            this.colEspecialidad.Visible = true;
            this.colEspecialidad.VisibleIndex = 3;
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(127, 12);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.xpPersonal;
            this.searchLookUpEdit1.Properties.DisplayMember = "Id_medi";
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Properties.ValueMember = "Id_medi";
            this.searchLookUpEdit1.Size = new System.Drawing.Size(496, 20);
            this.searchLookUpEdit1.StyleController = this.layoutControl1;
            this.searchLookUpEdit1.TabIndex = 4;
            this.searchLookUpEdit1.EditValueChanged += new System.EventHandler(this.searchLookUpEdit1_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.bt_Contraseña,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.simpleSeparator1,
            this.emptySpaceItem1,
            this.simpleSeparator2,
            this.simpleSeparator3,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(635, 337);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.searchLookUpEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(615, 24);
            this.layoutControlItem1.Text = "Buscar Personal Médico";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(112, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(615, 199);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // bt_Contraseña
            // 
            this.bt_Contraseña.Control = this.te_contraseña;
            this.bt_Contraseña.Location = new System.Drawing.Point(0, 240);
            this.bt_Contraseña.Name = "bt_Contraseña";
            this.bt_Contraseña.Size = new System.Drawing.Size(615, 24);
            this.bt_Contraseña.Text = "Nueva Contraseña:";
            this.bt_Contraseña.TextSize = new System.Drawing.Size(112, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.labelControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(615, 17);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_guardar;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 289);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(286, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btn_menu;
            this.layoutControlItem6.Location = new System.Drawing.Point(380, 289);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(235, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 315);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(615, 1);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(286, 289);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(94, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 316);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(615, 1);
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.Location = new System.Drawing.Point(0, 288);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(615, 1);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.te_confirmar;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 264);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(615, 24);
            this.layoutControlItem3.Text = "Confirmar Contraseña:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(112, 13);
            // 
            // xpPer
            // 
            this.xpPer.ObjectType = typeof(Clinica.Database.Medico);
            this.xpPer.Session = this.unitOfWork1;
            // 
            // Form_NewUser
            // 
            this.AcceptButton = this.btn_guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 337);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "Form_NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de nuevo Usuario";
            this.Load += new System.EventHandler(this.Form_NewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.te_confirmar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_contraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Contraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Xpo.XPCollection xpPersonal;
        private DevExpress.Xpo.XPCollection xpPer;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.XtraEditors.SimpleButton btn_menu;
        private DevExpress.XtraEditors.SimpleButton btn_guardar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit te_contraseña;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId_medi;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colEspecialidad;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem bt_Contraseña;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
        private DevExpress.XtraEditors.TextEdit te_confirmar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}