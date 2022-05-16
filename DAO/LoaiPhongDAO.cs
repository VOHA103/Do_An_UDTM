using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAndSupport;
using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace DAO
{
   public class LoaiPhongDAO
    {
        QL_PhongTroDataContext db = new QL_PhongTroDataContext();
        private static LoaiPhongDAO instances;
        public static LoaiPhongDAO Instances
        {
            get
            {
                if (instances == null)
                    instances = new LoaiPhongDAO();
                return instances;
            }

            set
            {
                instances = value;
            }
        }
        public void getDataTypeRoom(RepositoryItemLookUpEdit lk)
        {
            lk.DataSource = from lkh in db.LOAI_PHONGs select lkh;
            lk.DisplayMember = "TENLOAI";
            lk.ValueMember = "ID_LOAIPHONG";
        }
        public void getData(GridControl gv)
        {
            var lst = (from p in db.LOAI_PHONGs select p).ToList();
            gv.DataSource = Support.ToDataTable<LOAI_PHONG>(lst);
        }
        public int insert( string TENLOAI, double GIAPHONG, bool _status)
        {
            try
            {
                db.LOAI_PHONGs.InsertOnSubmit(new LOAI_PHONG()
                {
                    TENLOAI = TENLOAI,
                    GIAPHONG = GIAPHONG,
                    _status = _status,
                });
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public int update(int ID_LOAIPHONG, string TENLOAI, double GIAPHONG, bool _status)
        {
            var p = db.LOAI_PHONGs.FirstOrDefault(x => x.ID_LOAIPHONG == ID_LOAIPHONG);

            try
            {
                if (p == null)
                    return -1;
                p.TENLOAI = TENLOAI;
                p.GIAPHONG = GIAPHONG;
                p._status = _status;
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public int delete(int ID_LOAIPHONG)
        {
            try
            {
                var p = db.LOAI_PHONGs.FirstOrDefault(x => x.ID_LOAIPHONG == ID_LOAIPHONG);
                if (p == null)
                    return -1;
                //db.PHONGs.DeleteOnSubmit(kh);
                p._status = false;
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
    }
}
