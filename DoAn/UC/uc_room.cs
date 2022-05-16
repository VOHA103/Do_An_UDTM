using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;

namespace DoAn.UC
{
    public partial class uc_room : UserControl
    {
        frmMain frm;
        public uc_room(frmMain frm)
        {
            InitializeComponent();
            this.frm = frm;
            loadData();
        }
        public void loadData()
        {
            PhongDAO.Instances.getDataGV(gcRoom);
            LoaiPhongDAO.Instances.getDataTypeRoom(lstRoomType);
            gvRoom.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;



            LoaiPhongDAO.Instances.getData(gcTypeRoom);
            gvTypeRoom.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
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
                string str = "Phòng";
                if (xtraTabControl1.SelectedTabPageIndex == 0)
                    gvRoom.ExportToPdf(sf.FileName);
                else
                {
                    gvTypeRoom.ExportToPdf(sf.FileName);
                    str = "Loại Phòng";
                }
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
                string str = "Phòng";
                if (xtraTabControl1.SelectedTabPageIndex == 0)
                    gvRoom.ExportToDocx(sf.FileName);
                else
                {
                    gvTypeRoom.ExportToDocx(sf.FileName);
                    str = "Loại Phòng";
                }
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
                string str = "Phòng";
                if (xtraTabControl1.SelectedTabPageIndex == 0)
                    gvRoom.ExportToXls(sf.FileName);
                else
                {
                    gvTypeRoom.ExportToXls(sf.FileName);
                    str = "Loại Phòng";
                }
                XtraMessageBox.Show("Xuất file excel " + str + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex == 0)
            {
                DataRow dr = gvRoom.GetFocusedDataRow();
                if (dr != null)
                {
                    if (XtraMessageBox.Show("Bạn có muốn ngưng xử dụng phòng " + dr["TENPHONG"].ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        PhongDAO.Instances.delete(int.Parse(dr["ID_PHONG"].ToString()));
                        XtraMessageBox.Show("Đã ngưng sử dụng", "Thông báo");
                        PhongDAO.Instances.getDataGV(gcRoom);
                    }
                }
            }
            else
            {
                DataRow dr = gvTypeRoom.GetFocusedDataRow();
                if (dr != null)
                {
                    if (XtraMessageBox.Show("Bạn có muốn ngưng xử dụng loại phòng " + dr["TENLOAI"].ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        LoaiPhongDAO.Instances.delete(int.Parse(dr["ID_LOAIPHONG"].ToString()));
                        XtraMessageBox.Show("Đã ngưng sử dụng", "Thông báo");
                        LoaiPhongDAO.Instances.getData(gcTypeRoom);

                    }
                }
            }
        }

        private void gvRoom_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string sErr = "";
            bool bVali = true;
            if (gvRoom.GetRowCellValue(e.RowHandle, "TENPHONG").ToString().Trim() == "")
            {
                bVali = false;
                sErr = "Vui lòng điền tên phòng.\n";
            }
            if (gvRoom.GetRowCellValue(e.RowHandle, "DIACHI").ToString().Trim() == "")
            {
                bVali = false;
                sErr += "Vui lòng điền địa chỉ.\n";
            }
            if (gvRoom.GetRowCellValue(e.RowHandle, "ID_LOAIPHONG").ToString().Trim() == "")
            {
                bVali = false;
                sErr += "Vui lòng chọn loại phòng.\n";
            }
            if (gvRoom.GetRowCellValue(e.RowHandle, "_status").ToString().Trim() == "")
            {
                bVali = false;
                sErr += "Vui lòng chọn nhập trạng thái.\n";
            }
            if (bVali)
            {
                //thêm mới
                if (e.RowHandle < 0)
                {
                    try
                    {
                        //int ID_PHONG, int ID_LOAIPHONG, string TENPHONG, string DIACHI, int _status
                        PhongDAO.Instances.insert(int.Parse(gvRoom.GetRowCellValue(e.RowHandle, "ID_LOAIPHONG").ToString().Trim())
                            , gvRoom.GetRowCellValue(e.RowHandle, "TENPHONG").ToString().Trim()
                            , gvRoom.GetRowCellValue(e.RowHandle, "DIACHI").ToString()
                            , bool.Parse(gvRoom.GetRowCellValue(e.RowHandle, "_status").ToString().Trim()));
                        XtraMessageBox.Show("Thêm thành công", "Thông báo", DevExpress.Utils.DefaultBoolean.True);
                        PhongDAO.Instances.getDataGV(gcRoom);

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
                        PhongDAO.Instances.update(int.Parse(gvRoom.GetRowCellValue(e.RowHandle, "ID_PHONG").ToString().Trim())
                            , int.Parse(gvRoom.GetRowCellValue(e.RowHandle, "ID_LOAIPHONG").ToString().Trim())
                            , gvRoom.GetRowCellValue(e.RowHandle, "TENPHONG").ToString().Trim()
                            , gvRoom.GetRowCellValue(e.RowHandle, "DIACHI").ToString()
                            , bool.Parse(gvRoom.GetRowCellValue(e.RowHandle, "_status").ToString().Trim()));
                        XtraMessageBox.Show("Sửa thành công", "Thông báo", DevExpress.Utils.DefaultBoolean.True);
                        PhongDAO.Instances.getDataGV(gcRoom);
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

        private void gcRoom_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gvRoom.State != GridState.Editing)
            {
                DataRow dr = gvRoom.GetFocusedDataRow();
                if (dr != null)
                {
                    if (XtraMessageBox.Show("Bạn có muốn xoá phòng " + dr["TENPHONG"].ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        PhongDAO.Instances.delete(int.Parse(dr["ID_PHONG"].ToString()));
                        XtraMessageBox.Show("Đã ngưng sử dụng", "Thông báo");
                        PhongDAO.Instances.getDataGV(gcRoom);
                    }
                }
            }
        }

        private void gvRoom_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gvTypeRoom_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string sErr = "";
            bool bVali = true;
            if (gvTypeRoom.GetRowCellValue(e.RowHandle, "TENLOAI").ToString().Trim() == "")
            {
                bVali = false;
                sErr = "Vui lòng điền tên loại phòng.\n";
            }
            if (gvTypeRoom.GetRowCellValue(e.RowHandle, "GIAPHONG").ToString().Trim() == "")
            {
                bVali = false;
                sErr += "Vui lòng điền giá phòng.\n";
            }
            if (gvTypeRoom.GetRowCellValue(e.RowHandle, "_status").ToString().Trim() == "")
            {
                bVali = false;
                sErr += "Vui lòng chọn nhập trạng thái.\n";
            }
            if (bVali)
            {
                //thêm mới
                if (e.RowHandle < 0)
                {
                    try
                    {
                        //int ID_PHONG, int ID_LOAIPHONG, string TENPHONG, string DIACHI, int _status
                        LoaiPhongDAO.Instances.insert(gvTypeRoom.GetRowCellValue(e.RowHandle, "TENLOAI").ToString().Trim()
                            , double.Parse(gvTypeRoom.GetRowCellValue(e.RowHandle, "GIAPHONG").ToString())
                            , bool.Parse(gvTypeRoom.GetRowCellValue(e.RowHandle, "_status").ToString().Trim()));
                        XtraMessageBox.Show("Thêm thành công", "Thông báo", DevExpress.Utils.DefaultBoolean.True);
                        LoaiPhongDAO.Instances.getData(gcTypeRoom);

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
                        LoaiPhongDAO.Instances.update(int.Parse(gvTypeRoom.GetRowCellValue(e.RowHandle, "ID_LOAIPHONG").ToString().Trim())
                            , gvTypeRoom.GetRowCellValue(e.RowHandle, "TENLOAI").ToString().Trim()
                            , double.Parse(gvTypeRoom.GetRowCellValue(e.RowHandle, "GIAPHONG").ToString().Trim())
                            , bool.Parse(gvTypeRoom.GetRowCellValue(e.RowHandle, "_status").ToString().Trim()));
                        XtraMessageBox.Show("Sửa thành công", "Thông báo", DevExpress.Utils.DefaultBoolean.True);
                        LoaiPhongDAO.Instances.getData(gcTypeRoom);
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

        private void gvTypeRoom_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gcTypeRoom_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gvRoom.State != GridState.Editing)
            {
                DataRow dr = gvTypeRoom.GetFocusedDataRow();
                if (dr != null)
                {
                    if (XtraMessageBox.Show("Bạn có muốn xoá loại phòng " + dr["TENLOAI"].ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        LoaiPhongDAO.Instances.delete(int.Parse(dr["ID_LOAIPHONG"].ToString()));
                        XtraMessageBox.Show("Đã ngưng sử dụng", "Thông báo");
                        LoaiPhongDAO.Instances.getData(gcTypeRoom);
                    }
                }
            }
        }

        private void gcRoom_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void gcTypeRoom_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlTop_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlBottom_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlLeft_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlRight_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
