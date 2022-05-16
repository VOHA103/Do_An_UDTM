using DAO;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class uc_Bill : DevExpress.XtraEditors.XtraUserControl
    {
        frmMain frm;

        public uc_Bill(frmMain frm)
        {
            InitializeComponent();
            this.frm = frm;
            loadData();
        }
        public void loadData()
        {
            HoaDonDao.Instances.getDataGV(gcHoDon);
            PhongDAO.Instances.getDataRoom(lstRoom);
            gvHoaDon.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;

         }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DataRow dr = gvHoaDon.GetFocusedDataRow();
            if (dr != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn ngưng xử dụng  " + dr["ID_HOADON"].ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    AdminDao.Instances.delete(dr["ID_HOADON"].ToString());
                    XtraMessageBox.Show("Đã ngưng sử dụng", "Thông báo");
                    AdminDao.Instances.getData(gcHoDon);
                }
            }

        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Excel Files (*.xlsx)|*.xls";
            sf.Title = "Xuất ra file excel";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                string str = "Admin";
                gvHoaDon.ExportToXls(sf.FileName);


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
                string str = "Admin";
                gvHoaDon.ExportToDocx(sf.FileName);


                XtraMessageBox.Show("Xuất file word " + str + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnXuatPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Pdf Files (*.pdf)|*.pdf";
            sf.Title = "Xuất ra file pdf";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                string str = "Admin";
                gvHoaDon.ExportToPdf(sf.FileName);


                XtraMessageBox.Show("Xuất file pdf " + str + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm.Close();
        }

        private void uc_Bill_Load(object sender, EventArgs e)
        {

        }

        private void gcHoDon_Click(object sender, EventArgs e)
        {

        }

        private void uc_Bill_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gcRoom_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gvHoaDon.State != GridState.Editing)
            {
                DataRow dr = gvHoaDon.GetFocusedDataRow();
                if (dr != null)
                {
                    if (XtraMessageBox.Show("Bạn có muốn xoá  Hoa don " + dr["ID_HOADON"].ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        AdminDao.Instances.delete(dr["ID_HOADON"].ToString());
                        XtraMessageBox.Show("Đã ngưng sử dụng", "Thông báo");
                        AdminDao.Instances.getData(gcHoDon);
                    }
                }
            }
        }

        private void gvHoaDon_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

            string sErr = "";
            bool bVali = true;
            //if (gvHoaDon.GetRowCellValue(e.RowHandle, "ID_PHONG ").ToString().Trim() == "")
            //{
            //    bVali = false;
            //    sErr = "Vui lòng chon phong.\n";
            //}
            if (gvHoaDon.GetRowCellValue(e.RowHandle, "TONGTIEN").ToString().Trim() == "")
            {
                bVali = false;
                sErr += "Vui lòng điền tong tien.\n";
            }
            if (gvHoaDon.GetRowCellValue(e.RowHandle, "Thang_TToan").ToString().Trim() == "")
            {
                bVali = false;
                sErr += "Vui lòng chon thang thanh toan.\n";
            }
            
            if (bVali)
            {

                //thêm mới
                if (e.RowHandle < 0)
                {
                    try
                    {
                        HoaDonDao.Instances.insert(int.Parse(gvHoaDon.GetRowCellValue(e.RowHandle, "ID_PHONG").ToString().Trim())
                            , int.Parse(gvHoaDon.GetRowCellValue(e.RowHandle, "TONGTIEN").ToString().Trim().Trim())
                            , DateTime.Parse(gvHoaDon.GetRowCellValue(e.RowHandle, "Thang_TToan").ToString().Trim()));
                        XtraMessageBox.Show("Thêm thành công", "Thông báo", DevExpress.Utils.DefaultBoolean.True);
                        HoaDonDao.Instances.getDataGV(gcHoDon);

                    }
                    catch (Exception ex)
                    {

                    }
                }
                //sửa 
                else
                {
                    try
                    {
                        HoaDonDao.Instances.update(int.Parse(gvHoaDon.GetRowCellValue(e.RowHandle, "ID_PHONG").ToString().Trim())
                            , int.Parse(gvHoaDon.GetRowCellValue(e.RowHandle, "TONGTIEN").ToString().Trim().Trim())
                            , DateTime.Parse(gvHoaDon.GetRowCellValue(e.RowHandle, "Thang_TToan").ToString().Trim())
                            , int.Parse(gvHoaDon.GetRowCellValue(e.RowHandle, "ID_HOADON").ToString().Trim()));
                        HoaDonDao.Instances.getDataGV(gcHoDon);

                    }
                    catch (Exception)
                    {

                    }

                }
            }
            else
            {
                e.Valid = false;
                XtraMessageBox.Show(sErr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gv_admin__InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
    }
    
}
