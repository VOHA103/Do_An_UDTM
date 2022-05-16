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
    public partial class uc_Admin : DevExpress.XtraEditors.XtraUserControl
    {
        frmMain frm;

        public uc_Admin(frmMain frm)
        {
            InitializeComponent();
            this.frm = frm;
            loadData();
        }
        public void loadData()
        {
           

            AdminDao.Instances.getData(gc_Admin);
            gv_admin_.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
        }
        private void gcAdmin_Click(object sender, EventArgs e)
        {

        }

        private void ucAdmin_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm.Close();
        }

        private void btnXuatPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Pdf Files (*.pdf)|*.pdf";
            sf.Title = "Xuất ra file pdf";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                string str = "Admin";
                gv_admin_.ExportToPdf(sf.FileName);
               
               
                XtraMessageBox.Show("Xuất file pdf " + str + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                gv_admin_.ExportToDocx(sf.FileName);
               
               
                XtraMessageBox.Show("Xuất file word " + str + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                gv_admin_.ExportToXls(sf.FileName);
                
                
                XtraMessageBox.Show("Xuất file excel " + str + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
                DataRow dr = gv_admin_.GetFocusedDataRow();
                if (dr != null)
                {
                    if (XtraMessageBox.Show("Bạn có muốn ngưng xử dụng tai khoan " + dr["TAIKHOAN"].ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        AdminDao.Instances.delete(dr["TAIKHOAN"].ToString());
                        XtraMessageBox.Show("Đã ngưng sử dụng", "Thông báo");
                        AdminDao.Instances.getData(gcAdmin);
                    }
                }
           
                
            }

        private void ucAdmin_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gvAdmin.State != GridState.Editing)
            {
                DataRow dr = gvAdmin.GetFocusedDataRow();
                if (dr != null)
                {
                    if (XtraMessageBox.Show("Bạn có muốn xoá loại tai khoan " + dr["TAIKHOAN"].ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        AdminDao.Instances.delete(dr["TAIKHOAN"].ToString());
                        XtraMessageBox.Show("Đã ngưng sử dụng", "Thông báo");
                        AdminDao.Instances.getData(gcAdmin);
                    }
                }
            }
        }

        private void gv_admin__ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string sErr = "";
            bool bVali = true;
            if (gv_admin_.GetRowCellValue(e.RowHandle, "TAIKHOAN").ToString().Trim() == "")
            {
                bVali = false;
                sErr = "Vui lòng điền tên tai khoan.\n";
            }
           

            if (gv_admin_.GetRowCellValue(e.RowHandle, "MATKHAU").ToString().Trim() == "")
            {
                bVali = false;
                sErr += "Vui lòng điền mat khau.\n";
            }
           
            if (bVali)
            {
                //thêm mới
                if (e.RowHandle < 0)
                {
                    try
                    {
                        AdminDao.Instances.insert(gv_admin_.GetRowCellValue(e.RowHandle, "TAIKHOAN").ToString().Trim()
                            , gv_admin_.GetRowCellValue(e.RowHandle, "MATKHAU").ToString()
                            , bool.Parse(gv_admin_.GetRowCellValue(e.RowHandle, "PHANQUYEN").ToString().Trim()));
                        XtraMessageBox.Show("Thêm thành công", "Thông báo", DevExpress.Utils.DefaultBoolean.True);
                        AdminDao.Instances.getData(gcAdmin);

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
                        AdminDao.Instances.update(gv_admin_.GetRowCellValue(e.RowHandle, "TAIKHOAN").ToString().Trim()
                            , gv_admin_.GetRowCellValue(e.RowHandle, "MATKHAU").ToString().Trim()
                            , bool.Parse(gv_admin_.GetRowCellValue(e.RowHandle, "PHANQUYEN").ToString().Trim()));
                        XtraMessageBox.Show("Sửa thành công", "Thông báo", DevExpress.Utils.DefaultBoolean.True);
                        AdminDao.Instances.getData(gcAdmin);
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

