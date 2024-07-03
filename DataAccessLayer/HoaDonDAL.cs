using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace DataAccessLayer
{
    public class HoaDonDAL
    {
        public List<HOADON> getHoaDon()
        {
            List<HOADON> dsHD = new List<HOADON>();
            using (HoaDonConnection db = new HoaDonConnection())
            {
                var dshd = from acc in db.HOADONs
                            select acc;
                foreach (var i in dshd)
                {
                    HOADON acc = new HOADON();
                    acc.MAHOADON = i.MAHOADON;
                    acc.TENKHACHHANG = i.TENKHACHHANG;
                    acc.NGAYLAP = i.NGAYLAP;
                    acc.TONGTIEN = i.TONGTIEN;

                    dsHD.Add(acc);
                }
            }
            return dsHD;
        }
    }
}
