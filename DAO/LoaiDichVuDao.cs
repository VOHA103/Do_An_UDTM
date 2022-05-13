using DataAndSupport;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
public    class LoaiDichVuDao
    {
        QL_PhongTroDataContext db = new QL_PhongTroDataContext();
        private static LoaiDichVuDao instances;
        public static LoaiDichVuDao Instances
        {
            get
            {
                if (instances == null)
                    instances = new LoaiDichVuDao();
                return instances;
            }

            set
            {
                instances = value;
            }
        }
        public void getDataGV(GridControl gv)
        {
            var lst = (from p in db.LOAI_DICH_VUs select p).ToList();
            gv.DataSource = Support.ToDataTable<LOAI_DICH_VU>(lst);
        }
        public int insert(int ID_LOAIDICHVU, string TENDICHVU, int DONGIA, int _status)
        {
            try
            {
                db.LOAI_DICH_VUs.InsertOnSubmit(new LOAI_DICH_VU()
                {
                    ID_LOAIDICHVU = ID_LOAIDICHVU,
                    TENDICHVU = TENDICHVU,
                    DONGIA = DONGIA,
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
        public int update(int ID_LOAIDICHVU, string TENDICHVU, int DONGIA, int _status)
        {
            var p = db.LOAI_DICH_VUs.FirstOrDefault(x => x.ID_LOAIDICHVU == ID_LOAIDICHVU);

            try
            {
                if (p == null)
                    return -1;
                p.TENDICHVU = TENDICHVU;
                p.DONGIA = DONGIA;
                p._status = _status;
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public int delete(int ID_LOAIDICHVU)
        {
            try
            {
                var p = db.LOAI_DICH_VUs.FirstOrDefault(x => x.ID_LOAIDICHVU == ID_LOAIDICHVU);
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

