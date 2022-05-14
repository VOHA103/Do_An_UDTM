using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class DichVuDienNuocDao
    {
        QL_PhongTroDataContext db = new QL_PhongTroDataContext();
        private static DichVuDienNuocDao instances;
        public static DichVuDienNuocDao Instances
        {
            get
            {
                if (instances == null)
                    instances = new DichVuDienNuocDao();
                return instances;
            }

            set
            {
                instances = value;
            }
        }
        public void getDataGV(GridControl gv)
        {
            var lst = (from p in db.DV_Dien_Nuocs select p).ToList();
            gv.DataSource = Support.ToDataTable<DV_Dien_Nuoc>(lst);
        }
        public int insert(int ID_PHONG, DateTime Thang_TT, int CSM, int CSC, int DONGIA)
        {
            try
            {
                db.DV_Dien_Nuocs.InsertOnSubmit(new DV_Dien_Nuoc()
                {
                    ID_PHONG = ID_PHONG,
                    Thang_TT = Thang_TT,
                    CSM = CSM,
                    CSC = CSC,
                    DonGia = DONGIA,
                });
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public int update(int ID_DNuoc, int ID_PHONG, DateTime Thang_TT, int CSM, int CSC, int DONGIA)
        {
            var p = db.DV_Dien_Nuocs.FirstOrDefault(x => x.ID_DNuoc == ID_DNuoc);

            try
            {
                if (p == null)
                    return -1;
                p.Thang_TT = Thang_TT;
                p.CSM = CSM;
                p.CSC = CSC;
                p.DonGia = DONGIA;
                p.LOAI_PHONG = db.LOAI_PHONGs.Single(x => x.ID_LOAIPHONG == ID_PHONG);
                p.ID_PHONG = ID_PHONG;
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public int delete(int ID_DNuoc)
        {
            try
            {
                var p = db.DV_Dien_Nuocs.FirstOrDefault(x => x.ID_DNuoc == ID_DNuoc);
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
