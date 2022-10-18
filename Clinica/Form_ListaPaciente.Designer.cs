namespace Clinica
{
    partial class Form_SignosVitales
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
            this.xpSignosV = new DevExpress.Xpo.XPCollection(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpPaciente = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_sv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTalla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTemperatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpSignosV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpSignosV
            // 
            this.xpSignosV.ObjectType = typeof(Clinica.consulta_externa.Signosvitales);
            this.xpSignosV.Session = this.unitOfWork1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchLookUpEdit1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(573, 432);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.EditValue = "a";
            this.searchLookUpEdit1.Location = new System.Drawing.Point(108, 12);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.xpPaciente;
            this.searchLookUpEdit1.Properties.DisplayMember = "Num_seguro";
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Properties.ValueMember = "Num_seguro";
            this.searchLookUpEdit1.Size = new System.Drawing.Size(453, 20);
            this.searchLookUpEdit1.StyleController = this.layoutControl1;
            this.searchLookUpEdit1.TabIndex = 6;
            this.searchLookUpEdit1.EditValueChanged += new System.EventHandler(this.searchLookUpEdit1_EditValueChanged);
            // 
            // xpPaciente
            // 
            this.xpPaciente.ObjectType = typeof(Clinica.consulta_externa.Paciente);
            this.xpPaciente.Session = this.unitOfWork1;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpPaciente;
            this.gridControl1.Location = new System.Drawing.Point(22, 36);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(529, 374);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_sv,
            this.gridColumn1,
            this.gridColumn2,
            this.colPeso,
            this.colPresion,
            this.colTalla,
            this.colTemperatura,
            this.colObservaciones,
            this.colEstatura});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId_sv
            // 
            this.colId_sv.FieldName = "Id_sv";
            this.colId_sv.Name = "colId_sv";
            this.colId_sv.Visible = true;
            this.colId_sv.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Idpaciente!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Idpaciente!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // colPeso
            // 
            this.colPeso.FieldName = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.Visible = true;
            this.colPeso.VisibleIndex = 3;
            // 
            // colPresion
            // 
            this.colPresion.FieldName = "Presion";
            this.colPresion.Name = "colPresion";
            this.colPresion.Visible = true;
            this.colPresion.VisibleIndex = 4;
            // 
            // colTalla
            // 
            this.colTalla.FieldName = "Talla";
            this.colTalla.Name = "colTalla";
            this.colTalla.Visible = true;
            this.colTalla.VisibleIndex = 5;
            // 
            // colTemperatura
            // 
            this.colTemperatura.FieldName = "Temperatura";
            this.colTemperatura.Name = "colTemperatura";
            this.colTemperatura.Visible = true;
            this.colTemperatura.VisibleIndex = 6;
            // 
            // colObservaciones
            // 
            this.colObservaciones.FieldName = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.Visible = true;
            this.colObservaciones.VisibleIndex = 7;
            // 
            // colEstatura
            // 
            this.colEstatura.FieldName = "Estatura";
            this.colEstatura.Name = "colEstatura";
            this.colEstatura.Visible = true;
            this.colEstatura.VisibleIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.splitterItem1,
            this.emptySpaceItem1,
            this.splitterItem2,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(573, 432);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(10, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(533, 378);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(10, 402);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(533, 10);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 388);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(543, 24);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(10, 388);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.searchLookUpEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(553, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // Form_SignosVitales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 432);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form_SignosVitales";
            this.Text = "Form_SignosVitales";
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpSignosV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPCollection xpSignosV;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId_sv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colPeso;
        private DevExpress.XtraGrid.Columns.GridColumn colPresion;
        private DevExpress.XtraGrid.Columns.GridColumn colTalla;
        private DevExpress.XtraGrid.Columns.GridColumn colTemperatura;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatura;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.Xpo.XPCollection xpPaciente;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}