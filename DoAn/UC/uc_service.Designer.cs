
namespace DoAn.UC
{
    partial class uc_service
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_service));
            DevExpress.Utils.Drawing.StubGlyphOptions stubGlyphOptions3 = new DevExpress.Utils.Drawing.StubGlyphOptions();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatWord = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatPDF = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcLoaiDichVu = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maLoaiDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenLoaiDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.donGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gcDichVu = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDVDienNuec = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDVDienNuec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnXoa,
            this.btnXuatWord,
            this.btnXuatExcel,
            this.btnXuatPDF,
            this.btnClose});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuatWord),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuatExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuatPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 0;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Navy;
            this.btnXoa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnXoa.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnXuatWord
            // 
            this.btnXuatWord.Caption = "Xuất word";
            this.btnXuatWord.Id = 1;
            this.btnXuatWord.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXuatWord.ImageOptions.SvgImage")));
            this.btnXuatWord.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatWord.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Navy;
            this.btnXuatWord.ItemAppearance.Normal.Options.UseFont = true;
            this.btnXuatWord.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnXuatWord.Name = "btnXuatWord";
            this.btnXuatWord.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXuatWord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatWord_ItemClick);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Caption = "Xuất Excel";
            this.btnXuatExcel.Id = 2;
            this.btnXuatExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXuatExcel.ImageOptions.SvgImage")));
            this.btnXuatExcel.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Navy;
            this.btnXuatExcel.ItemAppearance.Normal.Options.UseFont = true;
            this.btnXuatExcel.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXuatExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatExcel_ItemClick);
            // 
            // btnXuatPDF
            // 
            this.btnXuatPDF.Caption = "Xuất PDF";
            this.btnXuatPDF.Id = 3;
            this.btnXuatPDF.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXuatPDF.ImageOptions.SvgImage")));
            this.btnXuatPDF.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatPDF.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Navy;
            this.btnXuatPDF.ItemAppearance.Normal.Options.UseFont = true;
            this.btnXuatPDF.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnXuatPDF.Name = "btnXuatPDF";
            this.btnXuatPDF.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXuatPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatPDF_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 4;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Navy;
            this.btnClose.ItemAppearance.Normal.Options.UseFont = true;
            this.btnClose.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1095, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 697);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1095, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 657);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1095, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 657);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 40);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1095, 657);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            this.xtraTabControl1.Tag = "Dịch vụ";
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage1.Appearance.Header.ForeColor = System.Drawing.Color.Navy;
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Appearance.Header.Options.UseForeColor = true;
            this.xtraTabPage1.Controls.Add(this.gcLoaiDichVu);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1088, 613);
            this.xtraTabPage1.Text = "Loại dịch vụ";
            this.xtraTabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage1_Paint);
            // 
            // gcLoaiDichVu
            // 
            this.gcLoaiDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLoaiDichVu.Location = new System.Drawing.Point(0, 0);
            this.gcLoaiDichVu.MainView = this.gridView2;
            this.gcLoaiDichVu.MenuManager = this.barManager1;
            this.gcLoaiDichVu.Name = "gcLoaiDichVu";
            this.gcLoaiDichVu.Size = new System.Drawing.Size(1088, 613);
            this.gcLoaiDichVu.TabIndex = 0;
            this.gcLoaiDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gcLoaiDichVu.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gcLoaiDichVu_ProcessGridKey);
            this.gcLoaiDichVu.Click += new System.EventHandler(this.gridControl2_Click);
            this.gcLoaiDichVu.Validated += new System.EventHandler(this.gcLoaiDichVu_Validated);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maLoaiDV,
            this.tenLoaiDV,
            this.donGia,
            this.Status});
            this.gridView2.GridControl = this.gcLoaiDichVu;
            this.gridView2.Name = "gridView2";
            // 
            // maLoaiDV
            // 
            this.behaviorManager1.SetBehaviors(this.maLoaiDV, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(typeof(DevExpress.XtraGrid.Views.Grid.BehaviorSource.StubGlyphBehaviorSourceForGridColumn), stubGlyphOptions3, new System.Drawing.Size(16, 16))))});
            this.maLoaiDV.Caption = "Mã loại dịch vụ";
            this.maLoaiDV.FieldName = "ID_LOAIDICHVU";
            this.maLoaiDV.MinWidth = 30;
            this.maLoaiDV.Name = "maLoaiDV";
            this.maLoaiDV.Visible = true;
            this.maLoaiDV.VisibleIndex = 0;
            this.maLoaiDV.Width = 112;
            // 
            // tenLoaiDV
            // 
            this.tenLoaiDV.Caption = "Tên loại dịch vụ";
            this.tenLoaiDV.FieldName = "TENDICHVU";
            this.tenLoaiDV.MinWidth = 30;
            this.tenLoaiDV.Name = "tenLoaiDV";
            this.tenLoaiDV.Visible = true;
            this.tenLoaiDV.VisibleIndex = 1;
            this.tenLoaiDV.Width = 112;
            // 
            // donGia
            // 
            this.donGia.Caption = "Đơn giá";
            this.donGia.FieldName = "DONGIA";
            this.donGia.MinWidth = 30;
            this.donGia.Name = "donGia";
            this.donGia.Visible = true;
            this.donGia.VisibleIndex = 2;
            this.donGia.Width = 112;
            // 
            // Status
            // 
            this.Status.Caption = "Status";
            this.Status.FieldName = "_status";
            this.Status.MinWidth = 30;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 3;
            this.Status.Width = 112;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage2.Appearance.Header.ForeColor = System.Drawing.Color.Navy;
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Appearance.Header.Options.UseForeColor = true;
            this.xtraTabPage2.Controls.Add(this.gcDichVu);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1088, 613);
            this.xtraTabPage2.Text = "Dịch vụ";
            // 
            // gcDichVu
            // 
            this.gcDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDichVu.Location = new System.Drawing.Point(0, 0);
            this.gcDichVu.MainView = this.gridView3;
            this.gcDichVu.MenuManager = this.barManager1;
            this.gcDichVu.Name = "gcDichVu";
            this.gcDichVu.Size = new System.Drawing.Size(1088, 613);
            this.gcDichVu.TabIndex = 0;
            this.gcDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.gcDichVu.Click += new System.EventHandler(this.gcDichVu_Click);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maDichVu,
            this.LoaiDV,
            this.Phong,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridView3.GridControl = this.gcDichVu;
            this.gridView3.Name = "gridView3";
            // 
            // maDichVu
            // 
            this.maDichVu.Caption = "Mã dịch vụ";
            this.maDichVu.FieldName = "ID_DICHVU";
            this.maDichVu.MinWidth = 30;
            this.maDichVu.Name = "maDichVu";
            this.maDichVu.Visible = true;
            this.maDichVu.VisibleIndex = 0;
            this.maDichVu.Width = 112;
            // 
            // LoaiDV
            // 
            this.LoaiDV.Caption = "Loại dịch vụ";
            this.LoaiDV.FieldName = "ID_LOAIDICHVU";
            this.LoaiDV.MinWidth = 30;
            this.LoaiDV.Name = "LoaiDV";
            this.LoaiDV.Visible = true;
            this.LoaiDV.VisibleIndex = 1;
            this.LoaiDV.Width = 112;
            // 
            // Phong
            // 
            this.Phong.Caption = "Phòng";
            this.Phong.FieldName = "ID_PHONG";
            this.Phong.MinWidth = 30;
            this.Phong.Name = "Phong";
            this.Phong.Visible = true;
            this.Phong.VisibleIndex = 2;
            this.Phong.Width = 112;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Từ ngày";
            this.gridColumn7.FieldName = "TU_NGAY";
            this.gridColumn7.MinWidth = 30;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 112;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Đến ngày";
            this.gridColumn8.FieldName = "DEN_NGAY";
            this.gridColumn8.MinWidth = 30;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 112;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tổng tiền";
            this.gridColumn9.FieldName = "TONGTIEN";
            this.gridColumn9.MinWidth = 30;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            this.gridColumn9.Width = 112;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage3.Appearance.Header.ForeColor = System.Drawing.Color.Navy;
            this.xtraTabPage3.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage3.Appearance.Header.Options.UseForeColor = true;
            this.xtraTabPage3.Controls.Add(this.gridLookUpEdit1);
            this.xtraTabPage3.Controls.Add(this.gcDVDienNuec);
            this.xtraTabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1088, 613);
            this.xtraTabPage3.Text = "Dịch vụ điện nước";
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(3, 15);
            this.gridLookUpEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridLookUpEdit1.MenuManager = this.barManager1;
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(395, 29);
            this.gridLookUpEdit1.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.DetailHeight = 437;
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gcDVDienNuec
            // 
            this.gcDVDienNuec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDVDienNuec.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDVDienNuec.Location = new System.Drawing.Point(0, 0);
            this.gcDVDienNuec.MainView = this.gridView1;
            this.gcDVDienNuec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDVDienNuec.MenuManager = this.barManager1;
            this.gcDVDienNuec.Name = "gcDVDienNuec";
            this.gcDVDienNuec.Size = new System.Drawing.Size(1088, 613);
            this.gcDVDienNuec.TabIndex = 0;
            this.gcDVDienNuec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcDVDienNuec;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Mã điện nước";
            this.gridColumn10.FieldName = "ID_DNUOC";
            this.gridColumn10.MinWidth = 30;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            this.gridColumn10.Width = 112;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Phòng";
            this.gridColumn11.FieldName = "ID_PHONG";
            this.gridColumn11.MinWidth = 30;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 112;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Tháng tt";
            this.gridColumn12.FieldName = "Thang_TT";
            this.gridColumn12.MinWidth = 30;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            this.gridColumn12.Width = 112;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Chỉ số củ";
            this.gridColumn13.FieldName = "CSC";
            this.gridColumn13.MinWidth = 30;
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 3;
            this.gridColumn13.Width = 112;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Chỉ số mới";
            this.gridColumn14.FieldName = "CSM";
            this.gridColumn14.MinWidth = 30;
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 4;
            this.gridColumn14.Width = 112;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Đơn giá";
            this.gridColumn15.FieldName = "DonGia";
            this.gridColumn15.MinWidth = 30;
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 5;
            this.gridColumn15.Width = 112;
            // 
            // uc_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_service";
            this.Size = new System.Drawing.Size(1095, 721);
            this.Tag = "Dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDVDienNuec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnXuatWord;
        private DevExpress.XtraBars.BarButtonItem btnXuatExcel;
        private DevExpress.XtraBars.BarButtonItem btnXuatPDF;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.GridControl gcDVDienNuec;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcLoaiDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn maLoaiDV;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn tenLoaiDV;
        private DevExpress.XtraGrid.Columns.GridColumn donGia;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.GridControl gcDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn maDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiDV;
        private DevExpress.XtraGrid.Columns.GridColumn Phong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
    }
}
