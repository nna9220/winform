using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class ChiTietHoaDonBUS
    {
        //Check hóa đơn
        public bool checkHoaDon(string mact, string mahd)
        {
            ChiTietHoaDonDAL cthd = new ChiTietHoaDonDAL();
            List<CHITIETHOADON> list = new List<CHITIETHOADON>();
            list = cthd.getCTHD();
            foreach (var i in list)
            {
                if (i.MAHOADON == mahd && i.MACHITIETHD == mact)
                    return true;
            }
            return false;
        }

        //Lấy đẩy lên DGV
        public DataTable LayCTHD()
        {
            ChiTietHDConnection hoadon = new ChiTietHDConnection();
            var hds = from n in hoadon.CHITIETHOADONs select n;
            DataTable dt = new DataTable();
            dt.Columns.Add("Max CTHD");
            dt.Columns.Add("Mã hóa đơn");
            dt.Columns.Add("ID sách");
            dt.Columns.Add("Nhân viên");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Giá tiền");
            dt.Columns.Add("Tổng tiền");
            foreach (var i in hds)
            {
                dt.Rows.Add(i.MACHITIETHD,i.MAHOADON, i.MASACH, i.NHANVIEN, i.SOLUONG,i.GIATIEN,i.THANHTIEN);
            }
            return dt;
        }

        //Thêm 
        public bool ThemCTHoaDon(string mact, string mahd, string idsach, string nhanvien,
            string soluong, string giatien, ref string err)
        {
            ChiTietHDConnection hoadon = new ChiTietHDConnection();
            CHITIETHOADON hd = new CHITIETHOADON();
            hd.MACHITIETHD = mact;
            hd.MAHOADON = mahd;
            hd.MASACH = idsach;
            hd.NHANVIEN = nhanvien;
            hd.SOLUONG =Convert.ToInt32( soluong);
            hd.GIATIEN = Convert.ToInt32(giatien);
            hd.THANHTIEN = Convert.ToInt32(soluong)* Convert.ToInt32(giatien); 

            hoadon.CHITIETHOADONs.Add(hd);
            hoadon.SaveChanges();
            return true;
        }

        

    }
}
