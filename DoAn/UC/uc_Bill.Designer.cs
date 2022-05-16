
namespace DoAn.UC
{
    partial class uc_Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Bill));
            this.lstRoomType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gvRoom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRoom = new DevExpress.XtraGrid.GridControl();
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
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcHoDon = new DevExpress.XtraGrid.GridControl();
            this.gvHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lstRoom = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lstRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstRoom)).BeginInit();
            this.SuspendLayout();
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
            // gcRoom
            // 
            this.gcRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRoom.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcRoom.Location = new System.Drawing.Point(0, 0);
            this.gcRoom.MainView = this.gvRoom;
            this.gcRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcRoom.MenuManager = this.barManager1;
            this.gcRoom.Name = "gcRoom";
            this.gcRoom.Size = new System.Drawing.Size(400, 200);
            this.gcRoom.TabIndex = 0;
            this.gcRoom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRoom});
            this.gcRoom.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gcRoom_ProcessGridKey);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnXoa,
            this.btnXuatExcel,
            this.btnXuatWord,
            this.btnXuatPDF,
            this.btnClose});
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
            this.barDockControlTop.Size = new System.Drawing.Size(1134, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 577);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1134, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 541);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1134, 36);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 541);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1134, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 541);
            // 
            // gcHoDon
            // 
            this.gcHoDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHoDon.Location = new System.Drawing.Point(0, 36);
            this.gcHoDon.MainView = this.gvHoaDon;
            this.gcHoDon.MenuManager = this.barManager1;
            this.gcHoDon.Name = "gcHoDon";
            this.gcHoDon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lstRoom});
            this.gcHoDon.Size = new System.Drawing.Size(1134, 541);
            this.gcHoDon.TabIndex = 5;
            this.gcHoDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHoaDon});
            this.gcHoDon.Click += new System.EventHandler(this.gcHoDon_Click);
            // 
            // gvHoaDon
            // 
            this.gvHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn8,
            this.gridColumn9});
            this.gvHoaDon.GridControl = this.gcHoDon;
            this.gvHoaDon.Name = "gvHoaDon";
            this.gvHoaDon.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvHoaDon_ValidateRow);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Hóa Đơn";
            this.gridColumn1.FieldName = "ID_HOADON";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã Phòng";
            this.gridColumn4.ColumnEdit = this.lstRoom;
            this.gridColumn4.FieldName = "ID_PHONG";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 112;
            // 
            // lstRoom
            // 
            this.lstRoom.AutoHeight = false;
            this.lstRoom.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lstRoom.Name = "lstRoom";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tổng tiền";
            this.gridColumn8.FieldName = "TONGTIEN";
            this.gridColumn8.MinWidth = 30;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 112;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tháng TT";
            this.gridColumn9.FieldName = "Thang_TToan";
            this.gridColumn9.MinWidth = 30;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 112;
            // 
            // uc_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcHoDon);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uc_Bill";
            this.Size = new System.Drawing.Size(1134, 601);
            this.Tag = "Hóa Đơn";
            this.Load += new System.EventHandler(this.uc_Bill_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uc_Bill_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.lstRoomType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvRoom;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.GridControl gcRoom;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnXuatExcel;
        private DevExpress.XtraBars.BarButtonItem btnXuatWord;
        private DevExpress.XtraBars.BarButtonItem btnXuatPDF;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lstRoomType;
        private DevExpress.XtraGrid.GridControl gcHoDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lstRoom;
    }
}
