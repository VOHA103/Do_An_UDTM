using DataAndSupport;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DichVuDao
    {
        QL_PhongTroDataContext db = new QL_PhongTroDataContext();
        private static DichVuDao instances;
        public static DichVuDao Instances
        {
            get
            {
                if (instances == null)
                    instances = new DichVuDao();
                return instances;
            }

            set
            {
                instances = value;
            }
        }
        public void getDataGV(GridControl gv)
        {
            var lst = (from p in db.DICHVU_THEMs select p).ToList();
            gv.DataSource = Support.ToDataTable<DICHVU_THEM>(lst);
        }
        public int insert(int ID_LOAIDICHVU,int ID_PHONG, DateTime TU_NGAY,DateTime DEN_NGAY,double TONGTIEN)
        {
            try
            {
                db.DICHVU_THEMs.InsertOnSubmit(new DICHVU_THEM()
                {
                    ID_LOAIDICHVU=ID_LOAIDICHVU,
                    ID_PHONG=ID_PHONG,
                    TU_NGAY=TU_NGAY,
                    DEN_NGAY=DEN_NGAY,
                    TONGTIEN=TONGTIEN,
                });
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public int update(int ID_DVT, int ID_LOAIDICHVU, int ID_PHONG, DateTime TU_NGAY, DateTime DEN_NGAY, double TONGTIEN)
        {
            var p = db.DICHVU_THEMs.FirstOrDefault(x => x.ID_DVT == ID_DVT && x.ID_PHONG == ID_PHONG && x.ID_LOAIDICHVU == ID_LOAIDICHVU);

            try
            {
                if (p == null)
                    return -1;
                    p.TU_NGAY = TU_NGAY;
                    p.DEN_NGAY = DEN_NGAY;
                    p.TONGTIEN = TONGTIEN;
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public int delete(int ID_DVT)
        {
            try
            {
                var p = db.DICHVU_THEMs.FirstOrDefault(x => x.ID_DVT == ID_DVT);
                if (p == null)
                    return -1;
                //db.PHONGs.DeleteOnSubmit(kh);

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
