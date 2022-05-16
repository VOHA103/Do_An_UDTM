using DataAndSupport;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
  public  class AdminDao
    {
        QL_PhongTroDataContext db = new QL_PhongTroDataContext();
        private static AdminDao instances;
        public static AdminDao Instances
        {
            get
            {
                if (instances == null)
                    instances = new AdminDao();
                return instances;
            }

            set
            {
                instances = value;
            }
        }
       
        public void getData(GridControl gv)
        {
            var lst = (from p in db.QUAN_Lies select p).ToList();
            gv.DataSource = Support.ToDataTable<QUAN_LY>(lst);
        }
        public int insert(string TAIKHOAN, string MATKHAU, bool PHANQUYEN)
        {
            try
            {
                db.QUAN_Lies.InsertOnSubmit(new QUAN_LY()
                {
                    TAIKHOAN = TAIKHOAN,
                    MATKHAU = MATKHAU,
                    PHANQUYEN = PHANQUYEN,
                });
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public int update(string TAIKHOAN, string MATKHAU, bool PHANQUYEN)
        {
            var p = db.QUAN_Lies.FirstOrDefault(x => x.TAIKHOAN == TAIKHOAN);

            try
            {
                if (p == null)
                    return -1;
                p.TAIKHOAN = TAIKHOAN;
                p.MATKHAU = MATKHAU;
                p.PHANQUYEN = false;
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public int delete(string TAIKHOAN)
        {
            try
            {
                var p = db.QUAN_Lies.FirstOrDefault(x => x.TAIKHOAN == TAIKHOAN);
                if (p == null)
                    return -1;
                //db.PHONGs.DeleteOnSubmit(kh);
                p.PHANQUYEN = false;
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
