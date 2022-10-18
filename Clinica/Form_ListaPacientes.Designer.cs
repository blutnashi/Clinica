namespace Clinica
{
    partial class Form_ListaPacientes
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
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.xpPac = new DevExpress.Xpo.XPCollection(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNum_seguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFcha_nac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumero_emergencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bt_nuevo = new DevExpress.XtraEditors.SimpleButton();
            this.bt_eliminar = new DevExpress.XtraEditors.SimpleButton();
            this.bt_editar = new DevExpress.XtraEditors.SimpleButton();
            this.te_menu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_exportar = new DevExpress.XtraEditors.SimpleButton();
            this.bt_close = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem3 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xpPa = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPa)).BeginInit();
            this.SuspendLayout();
            // 
            // xpPac
            // 
            this.xpPac.ObjectType = typeof(Clinica.Database.Paciente);
            this.xpPac.Session = this.unitOfWork1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.searchLookUpEdit1);
            this.layoutControl1.Controls.Add(this.bt_nuevo);
            this.layoutControl1.Controls.Add(this.bt_eliminar);
            this.layoutControl1.Controls.Add(this.bt_editar);
            this.layoutControl1.Controls.Add(this.te_menu);
            this.layoutControl1.Controls.Add(this.bt_exportar);
            this.layoutControl1.Controls.Add(this.bt_close);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(636, 427);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpPac;
            this.gridControl1.Location = new System.Drawing.Point(12, 37);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(517, 378);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNum_seguro,
            this.colNombre,
            this.colApellido,
            this.colCedula,
            this.colFcha_nac,
            this.colTelefono,
            this.colNumero_emergencia});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNum_seguro
            // 
            this.colNum_seguro.FieldName = "Num_seguro";
            this.colNum_seguro.Name = "colNum_seguro";
            this.colNum_seguro.Visible = true;
            this.colNum_seguro.VisibleIndex = 0;
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
            // colCedula
            // 
            this.colCedula.FieldName = "Cedula";
            this.colCedula.Name = "colCedula";
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 3;
            // 
            // colFcha_nac
            // 
            this.colFcha_nac.FieldName = "Fcha_nac";
            this.colFcha_nac.Name = "colFcha_nac";
            this.colFcha_nac.Visible = true;
            this.colFcha_nac.VisibleIndex = 4;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 5;
            // 
            // colNumero_emergencia
            // 
            this.colNumero_emergencia.FieldName = "Numero_emergencia";
            this.colNumero_emergencia.Name = "colNumero_emergencia";
            this.colNumero_emergencia.Visible = true;
            this.colNumero_emergencia.VisibleIndex = 6;
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(57, 12);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.xpPac;
            this.searchLookUpEdit1.Properties.DisplayMember = "Num_seguro";
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Properties.ValueMember = "Num_seguro";
            this.searchLookUpEdit1.Size = new System.Drawing.Size(472, 20);
            this.searchLookUpEdit1.StyleController = this.layoutControl1;
            this.searchLookUpEdit1.TabIndex = 6;
            this.searchLookUpEdit1.EditValueChanged += new System.EventHandler(this.searchLookUpEdit1_EditValueChanged_1);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // bt_nuevo
            // 
            this.bt_nuevo.Location = new System.Drawing.Point(533, 12);
            this.bt_nuevo.Name = "bt_nuevo";
            this.bt_nuevo.Size = new System.Drawing.Size(91, 22);
            this.bt_nuevo.StyleController = this.layoutControl1;
            this.bt_nuevo.TabIndex = 8;
            this.bt_nuevo.Text = "Nuevo";
            this.bt_nuevo.Click += new System.EventHandler(this.bt_nuevo_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(533, 74);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(91, 22);
            this.bt_eliminar.StyleController = this.layoutControl1;
            this.bt_eliminar.TabIndex = 9;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(533, 38);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(91, 22);
            this.bt_editar.StyleController = this.layoutControl1;
            this.bt_editar.TabIndex = 10;
            this.bt_editar.Text = "Editar";
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // te_menu
            // 
            this.te_menu.Location = new System.Drawing.Point(533, 110);
            this.te_menu.Name = "te_menu";
            this.te_menu.Size = new System.Drawing.Size(91, 22);
            this.te_menu.StyleController = this.layoutControl1;
            this.te_menu.TabIndex = 12;
            this.te_menu.Text = "Regresar al Menú";
            this.te_menu.Click += new System.EventHandler(this.te_menu_Click);
            // 
            // bt_exportar
            // 
            this.bt_exportar.Location = new System.Drawing.Point(533, 138);
            this.bt_exportar.Name = "bt_exportar";
            this.bt_exportar.Size = new System.Drawing.Size(91, 22);
            this.bt_exportar.StyleController = this.layoutControl1;
            this.bt_exportar.TabIndex = 13;
            this.bt_exportar.Text = "Exportar";
            this.bt_exportar.Click += new System.EventHandler(this.bt_exportar_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(533, 164);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(91, 22);
            this.bt_close.StyleController = this.layoutControl1;
            this.bt_close.TabIndex = 14;
            this.bt_close.Text = "Cerrar";
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.simpleSeparator1,
            this.splitterItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.splitterItem3,
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.splitterItem2,
            this.layoutControlItem7,
            this.simpleSeparator3,
            this.simpleSeparator2,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(636, 427);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.searchLookUpEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(10, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(511, 24);
            this.layoutControlItem2.Text = "Buscar";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(32, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(10, 24);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(511, 1);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(10, 25);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.bt_nuevo;
            this.layoutControlItem3.Location = new System.Drawing.Point(521, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(95, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.bt_eliminar;
            this.layoutControlItem4.Location = new System.Drawing.Point(521, 62);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(95, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.bt_editar;
            this.layoutControlItem5.Location = new System.Drawing.Point(521, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(95, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // splitterItem3
            // 
            this.splitterItem3.AllowHotTrack = true;
            this.splitterItem3.Location = new System.Drawing.Point(521, 52);
            this.splitterItem3.Name = "splitterItem3";
            this.splitterItem3.Size = new System.Drawing.Size(95, 10);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(521, 382);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.te_menu;
            this.layoutControlItem6.Location = new System.Drawing.Point(521, 98);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(95, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(521, 88);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(95, 10);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.bt_exportar;
            this.layoutControlItem7.Location = new System.Drawing.Point(521, 126);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(95, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.Location = new System.Drawing.Point(521, 125);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(95, 1);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(521, 124);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(95, 1);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.bt_close;
            this.layoutControlItem8.Location = new System.Drawing.Point(521, 152);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(95, 255);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // xpPa
            // 
            this.xpPa.Session = this.unitOfWork1;
            // 
            // Form_ListaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 427);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "Form_ListaPacientes";
            this.Text = "Lista de Pacientes";
            this.Load += new System.EventHandler(this.Form_ListaPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPCollection xpPac;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton bt_nuevo;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton bt_eliminar;
        private DevExpress.XtraEditors.SimpleButton bt_editar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.SplitterItem splitterItem3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_seguro;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colFcha_nac;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero_emergencia;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Xpo.XPCollection xpPa;
        private DevExpress.XtraEditors.SimpleButton te_menu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.XtraEditors.SimpleButton bt_exportar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
        private DevExpress.XtraEditors.SimpleButton bt_close;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}