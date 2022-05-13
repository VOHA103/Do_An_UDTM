using DAO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.UC
{
    public partial class uc_service : UserControl
    {
        frmMain frm;
        public uc_service(frmMain frm)
        {
            InitializeComponent();
            this.frm = frm;
            loadData();
        }
        public void loadData()
        {
            LoaiDichVuDao.Instances.getDataGV(gcLoaiDichVu);
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;

            //DichVuDao.Instances.getDataGV(gcDichVu);
            //LoaiDichVuDao.Instances.getDataGV(listLDV);
            //gridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;



        
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm.Close();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex == 0)
            {
                DataRow dr = gridView1.GetFocusedDataRow();
                if (dr != null)
                {
                    if (XtraMessageBox.Show("Bạn có muốn ngưng xử dụng loại dich vu " + dr["TENDICHVU"].ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        LoaiDichVuDao.Instances.delete(int.Parse(dr["ID_PHONG"].ToString()));
                        XtraMessageBox.Show("Đã ngưng sử dụng", "Thông báo");
                        LoaiDichVuDao.Instances.getDataGV(gcLoaiDichVu);
                    }
                }
            }else
            if (xtraTabControl1.SelectedTabPageIndex == 1)
            {
                DataRow dr = gridView2.GetFocusedDataRow();
                if (dr != null)
                {
                //    if (XtraMessageBox.Show("Bạn có muốn ngưng xử dụng dich vu " + dr["TENDICHVU"].ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                //    {
                //        LoaiDichVuDao.Instances.delete(int.Parse(dr["ID_PHONG"].ToString()));
                //        XtraMessageBox.Show("Đã ngưng sử dụng", "Thông báo");
                //        LoaiDichVuDao.Instances.getDataGV(gcDichVu);
                //    }
                }
            }
            else
            {
                DataRow dr = gridView3.GetFocusedDataRow();
                if (dr != null)
                {
                    //if (XtraMessageBox.Show("Bạn có muốn ngưng xử dụng dịch vụ điện nước " + dr["TENLOAI"].ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    //{
                    //    LoaiPhongDAO.Instances.delete(int.Parse(dr["ID_LOAIPHONG"].ToString()));
                    //    XtraMessageBox.Show("Đã ngưng sử dụng", "Thông báo");
                    //    LoaiPhongDAO.Instances.getData(gcDVDienNuec);

                    //}
                }
            }
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Pdf Files (*.pdf)|*.pdf";
            sf.Title = "Xuất ra file pdf";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                string str = "Loại Dịch VỤ";
                if (xtraTabControl1.SelectedTabPageIndex == 0)
                    gridView1.ExportToPdf(sf.FileName);
                else  if (xtraTabControl1.SelectedTabPageIndex == 1)
                {
                    gridView2.ExportToPdf(sf.FileName);
                    str = "Dịch Vụ ";
                }else
                {
                    gridView3.ExportToPdf(sf.FileName);
                    str = "Dịch Vụ Điện Nước";
                }
                XtraMessageBox.Show("Xuất file pdf " + str + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Excel Files (*.xlsx)|*.xls";
            sf.Title = "Xuất ra file excel";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                string str = "Loại Dịch Vụ";
                if (xtraTabControl1.SelectedTabPageIndex == 0)
                    gridView1.ExportToXls(sf.FileName);
                else
                 if (xtraTabControl1.SelectedTabPageIndex == 0)
                {
                    gridView2.ExportToXls(sf.FileName);
                    str = "Dịch Vụ";
                }
                else
                {

                    gridView3.ExportToXls(sf.FileName);
                    str = "Dịch Vụ Điện Nước";
                }
                XtraMessageBox.Show("Xuất file excel " + str + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnXuatWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Word Files (*.docx)|*.docx";
            sf.Title = "Xuất ra file word";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                string str = "Loại Dịch Vụ";
                if (xtraTabControl1.SelectedTabPageIndex == 0)
                    gridView1.ExportToDocx(sf.FileName);
                else
                if (xtraTabControl1.SelectedTabPageIndex == 1)
                {
                    gridView2.ExportToDocx(sf.FileName);
                    str = "Dịch Vụ";
                }
                else
                {
                    gridView3.ExportToDocx(sf.FileName);
                    str = "Dịch Vụ Điện Nước";
                }
                XtraMessageBox.Show("Xuất file word " + str + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void gcDichVu_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void gcLoaiDichVu_Validated(object sender, EventArgs e)
        {

        }

        private void gcLoaiDichVu_ProcessGridKey(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Delete && gvRoom.State != GridState.Editing)
            //{
            //    DataRow dr = gvTypeRoom.GetFocusedDataRow();
            //    if (dr != null)
            //    {
            //        if (XtraMessageBox.Show("Bạn có muốn xoá loại phòng " + dr["TENLOAI"].ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //        {
            //            LoaiPhongDAO.Instances.delete(int.Parse(dr["ID_LOAIPHONG"].ToString()));
            //            XtraMessageBox.Show("Đã ngưng sử dụng", "Thông báo");
            //            LoaiPhongDAO.Instances.getData(gcTypeRoom);
            //        }
            //    }
            //}
        }
    }
}
