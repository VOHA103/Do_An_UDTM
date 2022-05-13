using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAndSupport;
using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;

namespace DAO
{
    public class PhongDAO
    {
        QL_PhongTroDataContext db = new QL_PhongTroDataContext();
        private static PhongDAO instances;
        public static PhongDAO Instances
        {
            get
            {
                if (instances == null)
                    instances = new PhongDAO();
                return instances;
            }

            set
            {
                instances = value;
            }
        }
        public void getDataGV(GridControl gv)
        {
          var lst = (from p in db.PHONGs select p).ToList();
           gv.DataSource = Support.ToDataTable<PHONG>(lst);
        }
        public int insert(int ID_LOAIPHONG, string TENPHONG, string DIACHI, int _status)
        {
            try
            {
                db.PHONGs.InsertOnSubmit(new PHONG()
                {
                    ID_LOAIPHONG=ID_LOAIPHONG,
                    TENPHONG=TENPHONG,
                    DIACHI=DIACHI,
                    _status=_status,
                }) ;
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public int update(int ID_PHONG, int ID_LOAIPHONG, string TENPHONG, string DIACHI, int _status)
        {
            var p = db.PHONGs.FirstOrDefault(x => x.ID_PHONG == ID_PHONG);

            try
            {
                if (p == null)
                    return -1;
                p.TENPHONG = TENPHONG;
                p.DIACHI = DIACHI;
                p._status = _status;
                p.LOAI_PHONG = db.LOAI_PHONGs.Single(x => x.ID_LOAIPHONG == ID_LOAIPHONG);
                p.ID_LOAIPHONG = ID_LOAIPHONG;
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public int delete(int ID_PHONG)
        {
            try
            {
                var p = db.PHONGs.FirstOrDefault(x => x.ID_PHONG == ID_PHONG);
                if (p == null)
                    return -1;
                //db.PHONGs.DeleteOnSubmit(kh);
                p._status = 0;
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
