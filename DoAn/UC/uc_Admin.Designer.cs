
namespace DoAn.UC
{
    partial class uc_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Admin));
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
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.gcAdmin = new DevExpress.XtraGrid.GridControl();
            this.gvAdmin = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucAdmin = new DevExpress.XtraGrid.GridControl();
            this.gv_Admin = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Admin = new DevExpress.XtraGrid.GridControl();
            this.gv_admin_ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_admin_)).BeginInit();
            this.SuspendLayout();
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
            this.barDockControlTop.Size = new System.Drawing.Size(1212, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 594);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1212, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 554);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1212, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 554);
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
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Xuất Excel";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xuất Word";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xuất PDF";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Đóng";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
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
            // gcAdmin
            // 
            this.gcAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAdmin.Location = new System.Drawing.Point(1, 1);
            this.gcAdmin.MainView = this.gvAdmin;
            this.gcAdmin.MenuManager = this.barManager1;
            this.gcAdmin.Name = "gcAdmin";
            this.gcAdmin.Size = new System.Drawing.Size(1205, 547);
            this.gcAdmin.TabIndex = 0;
            this.gcAdmin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAdmin});
            this.gcAdmin.Click += new System.EventHandler(this.gcAdmin_Click);
            // 
            // gvAdmin
            // 
            this.gvAdmin.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvAdmin.GridControl = this.gcAdmin;
            this.gvAdmin.Name = "gvAdmin";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tài Khoản";
            this.gridColumn1.FieldName = "TAIKHOAN";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mật Khẩu";
            this.gridColumn2.FieldName = "MATKHAU";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 112;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Phân Quyền";
            this.gridColumn3.FieldName = "PHANQUYEN";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 112;
            // 
            // ucAdmin
            // 
            this.ucAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAdmin.Location = new System.Drawing.Point(1, 1);
            this.ucAdmin.MainView = this.gv_Admin;
            this.ucAdmin.MenuManager = this.barManager1;
            this.ucAdmin.Name = "ucAdmin";
            this.ucAdmin.Size = new System.Drawing.Size(1205, 547);
            this.ucAdmin.TabIndex = 0;
            this.ucAdmin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Admin});
            this.ucAdmin.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.ucAdmin_ProcessGridKey);
            this.ucAdmin.Click += new System.EventHandler(this.ucAdmin_Click);
            // 
            // gv_Admin
            // 
            this.gv_Admin.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gv_Admin.GridControl = this.ucAdmin;
            this.gv_Admin.Name = "gv_Admin";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tài khoản";
            this.gridColumn4.FieldName = "TAIKHOAN";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 112;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mật khẩu";
            this.gridColumn5.FieldName = "MATKHAU";
            this.gridColumn5.MinWidth = 30;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 112;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Phân quyền";
            this.gridColumn6.FieldName = "PHANQUYEN";
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Width = 112;
            // 
            // gc_Admin
            // 
            this.gc_Admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Admin.Location = new System.Drawing.Point(0, 40);
            this.gc_Admin.MainView = this.gv_admin_;
            this.gc_Admin.MenuManager = this.barManager1;
            this.gc_Admin.Name = "gc_Admin";
            this.gc_Admin.Size = new System.Drawing.Size(1212, 554);
            this.gc_Admin.TabIndex = 12;
            this.gc_Admin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_admin_});
            this.gc_Admin.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gv_admin_
            // 
            this.gv_admin_.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gv_admin_.GridControl = this.gc_Admin;
            this.gv_admin_.Name = "gv_admin_";
            this.gv_admin_.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gv_admin__InvalidRowException);
            this.gv_admin_.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gv_admin__ValidateRow);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tài Khoản";
            this.gridColumn7.FieldName = "TAIKHOAN";
            this.gridColumn7.MinWidth = 30;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 112;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Mật Khẩu";
            this.gridColumn8.FieldName = "MATKHAU";
            this.gridColumn8.MinWidth = 30;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 112;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Phân Quyền";
            this.gridColumn9.FieldName = "PHANQUYEN";
            this.gridColumn9.MinWidth = 30;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 112;
            // 
            // uc_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gc_Admin);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uc_Admin";
            this.Size = new System.Drawing.Size(1212, 618);
            this.Tag = "Quản Lý";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_admin_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraGrid.GridControl gcAdmin;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.GridControl ucAdmin;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Admin;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.GridControl gc_Admin;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_admin_;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}
