
namespace DoAn.UC
{
    partial class uc_room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_room));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatWord = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatPDF = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcRoom = new DevExpress.XtraGrid.GridControl();
            this.gvRoom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lstRoomType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gcTypeRoom = new DevExpress.XtraGrid.GridControl();
            this.gvTypeRoom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_phong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ten_phong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lstTypeRoom = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.lstTypeRoomCbb = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTypeRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTypeRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTypeRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTypeRoomCbb)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(456, 146);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.btnXoa,
            this.btnXuatExcel,
            this.btnXuatWord,
            this.btnXuatPDF,
            this.btnClose});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuatExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuatWord),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuatPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 5;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Navy;
            this.btnXoa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnXoa.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Caption = "Xuất Excel";
            this.btnXuatExcel.Id = 6;
            this.btnXuatExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXuatExcel.ImageOptions.SvgImage")));
            this.btnXuatExcel.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Navy;
            this.btnXuatExcel.ItemAppearance.Normal.Options.UseFont = true;
            this.btnXuatExcel.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXuatExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatExcel_ItemClick);
            // 
            // btnXuatWord
            // 
            this.btnXuatWord.Caption = "Xuất word";
            this.btnXuatWord.Id = 7;
            this.btnXuatWord.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXuatWord.ImageOptions.SvgImage")));
            this.btnXuatWord.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatWord.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Navy;
            this.btnXuatWord.ItemAppearance.Normal.Options.UseFont = true;
            this.btnXuatWord.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnXuatWord.Name = "btnXuatWord";
            this.btnXuatWord.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXuatWord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatWord_ItemClick);
            // 
            // btnXuatPDF
            // 
            this.btnXuatPDF.Caption = "Xuất pdf";
            this.btnXuatPDF.Id = 8;
            this.btnXuatPDF.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXuatPDF.ImageOptions.SvgImage")));
            this.btnXuatPDF.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnClose.Id = 9;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Navy;
            this.btnClose.ItemAppearance.Normal.Options.UseFont = true;
            this.btnClose.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.barDockControlTop.Appearance.Options.UseBackColor = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1020, 40);
            this.barDockControlTop.Click += new System.EventHandler(this.barDockControlTop_Click);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 657);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1020, 24);
            this.barDockControlBottom.Click += new System.EventHandler(this.barDockControlBottom_Click);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 617);
            this.barDockControlLeft.Click += new System.EventHandler(this.barDockControlLeft_Click);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1020, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 617);
            this.barDockControlRight.Click += new System.EventHandler(this.barDockControlRight_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xoá";
            this.barButtonItem1.Hint = "Xoá";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.Size = new System.Drawing.Size(70, 50);
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Xuất Excel";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xuất Word";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xuất PDF";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Đóng";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabControl1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.xtraTabControl1.Appearance.Options.UseFont = true;
            this.xtraTabControl1.Appearance.Options.UseForeColor = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 40);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1020, 617);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcRoom);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1013, 581);
            this.xtraTabPage1.Text = "Phòng";
            this.xtraTabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage1_Paint);
            // 
            // gcRoom
            // 
            this.gcRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoom.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcRoom.Location = new System.Drawing.Point(0, 0);
            this.gcRoom.MainView = this.gvRoom;
            this.gcRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcRoom.MenuManager = this.barManager1;
            this.gcRoom.Name = "gcRoom";
            this.gcRoom.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lstRoomType,
            this.repositoryItemCheckEdit1,
            this.repositoryItemRadioGroup1});
            this.gcRoom.Size = new System.Drawing.Size(1013, 581);
            this.gcRoom.TabIndex = 0;
            this.gcRoom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRoom});
            this.gcRoom.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gcRoom_ProcessGridKey);
            this.gcRoom.Click += new System.EventHandler(this.gcRoom_Click);
            // 
            // gvRoom
            // 
            this.gvRoom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvRoom.DetailHeight = 437;
            this.gvRoom.GridControl = this.gcRoom;
            this.gvRoom.Name = "gvRoom";
            this.gvRoom.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvRoom_InvalidRowException);
            this.gvRoom.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvRoom_ValidateRow);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã Phòng";
            this.gridColumn2.FieldName = "ID_PHONG";
            this.gridColumn2.MinWidth = 28;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 106;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Loại Phòng";
            this.gridColumn3.ColumnEdit = this.lstRoomType;
            this.gridColumn3.FieldName = "ID_LOAIPHONG";
            this.gridColumn3.MinWidth = 28;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 106;
            // 
            // lstRoomType
            // 
            this.lstRoomType.AutoHeight = false;
            this.lstRoomType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lstRoomType.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lstRoomType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_LOAIPHONG", "Mã Loại"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENLOAI", "Tên Loại")});
            this.lstRoomType.Name = "lstRoomType";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên Phòng";
            this.gridColumn5.FieldName = "TENPHONG";
            this.gridColumn5.MinWidth = 28;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 106;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Địa Chỉ";
            this.gridColumn6.FieldName = "DIACHI";
            this.gridColumn6.MinWidth = 28;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 106;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Trạng Thái";
            this.gridColumn7.FieldName = "_status";
            this.gridColumn7.MinWidth = 28;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 106;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gcTypeRoom);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1013, 581);
            this.xtraTabPage2.Text = "Loại Phòng";
            this.xtraTabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage2_Paint);
            // 
            // gcTypeRoom
            // 
            this.gcTypeRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTypeRoom.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcTypeRoom.Location = new System.Drawing.Point(0, 0);
            this.gcTypeRoom.MainView = this.gvTypeRoom;
            this.gcTypeRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcTypeRoom.MenuManager = this.barManager1;
            this.gcTypeRoom.Name = "gcTypeRoom";
            this.gcTypeRoom.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lstTypeRoom,
            this.lstTypeRoomCbb});
            this.gcTypeRoom.Size = new System.Drawing.Size(1013, 581);
            this.gcTypeRoom.TabIndex = 0;
            this.gcTypeRoom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTypeRoom});
            this.gcTypeRoom.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gcTypeRoom_ProcessGridKey);
            this.gcTypeRoom.Click += new System.EventHandler(this.gcTypeRoom_Click);
            // 
            // gvTypeRoom
            // 
            this.gvTypeRoom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_phong,
            this.ten_phong,
            this.gridColumn4,
            this.gridColumn1});
            this.gvTypeRoom.DetailHeight = 437;
            this.gvTypeRoom.GridControl = this.gcTypeRoom;
            this.gvTypeRoom.Name = "gvTypeRoom";
            this.gvTypeRoom.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvTypeRoom_InvalidRowException);
            this.gvTypeRoom.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvTypeRoom_ValidateRow);
            // 
            // id_phong
            // 
            this.id_phong.Caption = "Mã Phòng";
            this.id_phong.FieldName = "ID_LOAIPHONG";
            this.id_phong.MinWidth = 28;
            this.id_phong.Name = "id_phong";
            this.id_phong.OptionsColumn.ReadOnly = true;
            this.id_phong.Visible = true;
            this.id_phong.VisibleIndex = 0;
            this.id_phong.Width = 106;
            // 
            // ten_phong
            // 
            this.ten_phong.Caption = "Tên Phòng";
            this.ten_phong.FieldName = "TENLOAI";
            this.ten_phong.MinWidth = 28;
            this.ten_phong.Name = "ten_phong";
            this.ten_phong.Visible = true;
            this.ten_phong.VisibleIndex = 1;
            this.ten_phong.Width = 106;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Giá Phòng";
            this.gridColumn4.FieldName = "GIAPHONG";
            this.gridColumn4.MinWidth = 28;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 106;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Trạng Thái";
            this.gridColumn1.FieldName = "_status";
            this.gridColumn1.MinWidth = 28;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 106;
            // 
            // lstTypeRoom
            // 
            this.lstTypeRoom.AutoHeight = false;
            this.lstTypeRoom.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lstTypeRoom.Name = "lstTypeRoom";
            // 
            // lstTypeRoomCbb
            // 
            this.lstTypeRoomCbb.AutoHeight = false;
            this.lstTypeRoomCbb.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lstTypeRoomCbb.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_LOAIPHONG", "ID_LOAIPHONG"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENLOAI", "TenLoai")});
            this.lstTypeRoomCbb.Name = "lstTypeRoomCbb";
            // 
            // uc_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_room";
            this.Size = new System.Drawing.Size(1020, 681);
            this.Tag = "Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstRoomType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTypeRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTypeRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTypeRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTypeRoomCbb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnXuatExcel;
        private DevExpress.XtraBars.BarButtonItem btnXuatWord;
        private DevExpress.XtraBars.BarButtonItem btnXuatPDF;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gcTypeRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTypeRoom;
        private DevExpress.XtraGrid.GridControl gcRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRoom;
        private DevExpress.XtraGrid.Columns.GridColumn id_phong;
        private DevExpress.XtraGrid.Columns.GridColumn ten_phong;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox lstTypeRoom;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lstTypeRoomCbb;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lstRoomType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}
