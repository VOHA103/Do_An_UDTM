using DataAndSupport;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDao
    {

        QL_PhongTroDataContext db = new QL_PhongTroDataContext();
        private static HoaDonDao instances;
        public static HoaDonDao Instances
        {
            get
            {
                if (instances == null)
                    instances = new HoaDonDao();
                return instances;
            }

            set
            {
                instances = value;
            }
        }
        public void getDataGV(GridControl gv)
        {

            var lst = (from kh in db.HOA_DONs select kh).ToList();

            gv.DataSource = Support.ToDataTable<HOA_DON>(lst);

        }
        public int insert(int ID_PHONG, int TONGTIEN, DateTime Thang_TToan)
        {
            try
            {
                db.HOA_DONs.InsertOnSubmit(new HOA_DON()
                {
                    ID_PHONG = ID_PHONG,
                    TONGTIEN = TONGTIEN,
                    Thang_TToan = Thang_TToan,
                  
                });
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public int update(int ID_PHONG, int TONGTIEN, DateTime Thang_TToan,int ID_HOASON)
        {
            var kh = db.HOA_DONs.FirstOrDefault(x => x.ID_HOADON == ID_HOASON);

            try
            {
                if (kh == null)
                    return -1;
                kh.ID_PHONG = ID_PHONG;
                kh.TONGTIEN = TONGTIEN;
                kh.Thang_TToan = Thang_TToan;
               
                kh.PHONG = db.PHONGs.Single(x => x.ID_PHONG == ID_PHONG);
                kh.ID_PHONG = ID_PHONG;
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public int delete(int ID_HOADON)
        {
            try
            {
                var kh = db.HOA_DONs.FirstOrDefault(x => x.ID_HOADON == ID_HOADON);
                if (kh == null)
                    return -1;
                db.HOA_DONs.DeleteOnSubmit(kh);
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
