using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ChiTietHoaDonDAL
    {
        public List<CHITIETHOADON> getCTHD()
        {
            List<CHITIETHOADON> dsCTHD = new List<CHITIETHOADON>();
            using (ChiTietHDConnection db = new ChiTietHDConnection())
            {
                var dslv = from lv in db.CHITIETHOADONs
                           select lv;
                foreach (var i in dslv)
                {
                    CHITIETHOADON lv = new CHITIETHOADON();
                    lv.MAHOADON = i.MAHOADON;
                    lv.MASACH = i.MASACH;
                    lv.NHANVIEN = i.NHANVIEN;
                    lv.GIATIEN = i.GIATIEN;
                    lv.SOLUONG = i.SOLUONG;
                    lv.THANHTIEN = i.THANHTIEN;

                    dsCTHD.Add(lv);
                }
            }
            return dsCTHD;
        }
    }
}
