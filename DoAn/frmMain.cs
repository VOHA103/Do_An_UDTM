using DevExpress.XtraBars;
using DoAn.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        UserControl uc;
        public void _close()
        {
            FormContainer1.Controls.Remove(uc);
            FormContainer1.BringToFront();
            lbTrangchu.Caption = "Trang chủ";

        }
        void openUC(Type typeUC)
        {


            bool check = false;
            foreach (UserControl _uc in FormContainer1.Controls)
            {

                if (_uc.GetType() == typeUC)
                {
                    _uc.BringToFront();
                    lbTrangchu.Caption = _uc.Tag.ToString();
                    check = true;
                    continue;
                }
                FormContainer1.Controls.Remove(_uc);

            }
            if (check)
                return;
            uc = (UserControl)Activator.CreateInstance(typeUC, this);
            uc.Dock = DockStyle.Fill;
            FormContainer1.Controls.Add(uc);
            uc.BringToFront();
            lbTrangchu.Caption = uc.Tag.ToString();

        }
        public frmMain()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            openUC(typeof(uc_room));
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            //openUC(typeof(uc_service));

        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            openUC(typeof(uc_Admin));

        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            openUC(typeof(uc_Bill));

        }
    }
}
