
namespace DoAn
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.FormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnPhong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDichVu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lbTrangchu = new DevExpress.XtraBars.BarHeaderItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormContainer1
            // 
            this.FormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormContainer1.Location = new System.Drawing.Point(346, 40);
            this.FormContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.FormContainer1.Name = "FormContainer1";
            this.FormContainer1.Size = new System.Drawing.Size(1044, 765);
            this.FormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement3});
            this.accordionControl1.Location = new System.Drawing.Point(0, 40);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(346, 765);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.accordionControlElement1.Appearance.Normal.ForeColor = System.Drawing.Color.Navy;
            this.accordionControlElement1.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement1.Appearance.Normal.Options.UseForeColor = true;
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnPhong,
            this.btnKhachHang,
            this.btnDichVu,
            this.accordionControlElement4,
            this.accordionControlElement5});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Quản Lý";
            // 
            // btnPhong
            // 
            this.btnPhong.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPhong.Appearance.Normal.Options.UseFont = true;
            this.btnPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhong.ImageOptions.Image")));
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.Click += new System.EventHandler(this.accordionControlElement4_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnKhachHang.Appearance.Normal.Options.UseFont = true;
            this.btnKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.Image")));
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnKhachHang.Text = "Khách hàng";
            // 
            // btnDichVu
            // 
            this.btnDichVu.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDichVu.Appearance.Normal.Options.UseFont = true;
            this.btnDichVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDichVu.ImageOptions.Image")));
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.accordionControlElement4.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement4.ImageOptions.Image")));
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Hợp đồng";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.accordionControlElement5.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement5.ImageOptions.Image")));
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "Hóa đơn";
            this.accordionControlElement5.Click += new System.EventHandler(this.accordionControlElement5_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.accordionControlElement2.Appearance.Normal.ForeColor = System.Drawing.Color.Navy;
            this.accordionControlElement2.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement2.Appearance.Normal.Options.UseForeColor = true;
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement6,
            this.accordionControlElement10,
            this.accordionControlElement7,
            this.accordionControlElement8,
            this.accordionControlElement9});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Hệ Thống";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.accordionControlElement6.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement6.ImageOptions.Image = global::DoAn.Properties.Resources.drilldownonarguments_chart_32x32;
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement6.Text = "Đổi mật khẩu";
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement10.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement10.ImageOptions.Image = global::DoAn.Properties.Resources.bouser_32x32;
            this.accordionControlElement10.Name = "accordionControlElement10";
            this.accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement10.Text = "Quản lý";
            this.accordionControlElement10.Click += new System.EventHandler(this.accordionControlElement10_Click);
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.accordionControlElement7.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement7.ImageOptions.Image = global::DoAn.Properties.Resources.refresh2_32x32;
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement7.Text = "Backup";
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.accordionControlElement8.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement8.ImageOptions.Image = global::DoAn.Properties.Resources.refreshpivottable_32x32;
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement8.Text = "Restore";
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.accordionControlElement9.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement9.ImageOptions.Image = global::DoAn.Properties.Resources.outbox_32x32;
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement9.Text = "Đăng xuất";
            this.accordionControlElement9.Click += new System.EventHandler(this.accordionControlElement9_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.accordionControlElement3.Appearance.Normal.ForeColor = System.Drawing.Color.Navy;
            this.accordionControlElement3.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement3.Appearance.Normal.Options.UseForeColor = true;
            this.accordionControlElement3.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.accordionControlElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Thống Kê";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lbTrangchu});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1390, 40);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lbTrangchu);
            this.fluentDesignFormControl1.Click += new System.EventHandler(this.fluentDesignFormControl1_Click);
            // 
            // lbTrangchu
            // 
            this.lbTrangchu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangchu.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.lbTrangchu.Appearance.Options.UseFont = true;
            this.lbTrangchu.Appearance.Options.UseForeColor = true;
            this.lbTrangchu.Caption = "Trang chủ";
            this.lbTrangchu.Id = 0;
            this.lbTrangchu.Name = "lbTrangchu";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lbTrangchu});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // frmMain
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 805);
            this.ControlContainer = this.FormContainer1;
            this.Controls.Add(this.FormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý phòng trọ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer FormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnPhong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.BarHeaderItem lbTrangchu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDichVu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
    }
}