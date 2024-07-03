using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class HoaDonBUS
    {
        //Kiểm tra chuỗi id nhập vào
        public bool checkId(string id)
        {
            if (id.Length == 7)
                return true;
            return false;
        }
        //kiểm tra
        public bool checkHoaDon(string mahd)
        {

            HoaDonDAL nv = new HoaDonDAL();
            List<HOADON> list = new List<HOADON>();
            list = nv.getHoaDon();
            foreach (var i in list)
            {
                if (i.MAHOADON == mahd)
                    return true;
            }
            return false;
        }

        //Lấy đẩy lên DGV
        public DataTable LayHoaDon()
        {
            HoaDonConnection hoadon = new HoaDonConnection();
            var hds = from n in hoadon.HOADONs select n;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hóa đơn");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Ngày lập");
            foreach (var i in hds)
            {
                dt.Rows.Add(i.MAHOADON,i.TENKHACHHANG,i.NGAYLAP);
            }
            return dt;
        }

        //Thêm hóa đơn
        public bool ThemHoaDon(string mahd, string ten,string ngaytt, 
             ref string err)
        {
            HoaDonConnection hoadon = new HoaDonConnection();
            HOADON hd = new HOADON();
            hd.MAHOADON = mahd;
            hd.TENKHACHHANG = ten;
            hd.NGAYLAP = Convert.ToDateTime(ngaytt);
            hoadon.HOADONs.Add(hd);
            hoadon.SaveChanges();
            return true;
        }

        //Sửa hóa đơn
        public bool SuaHoaDon(string mahd, string ten, 
            string ngaytt, ref string err)
        {
            HoaDonConnection hoadon = new HoaDonConnection();
            var hdQuery = (from hd in hoadon.HOADONs
                           where hd.MAHOADON == mahd
                           select hd).SingleOrDefault();
            if(hdQuery!=null)
            {
                hdQuery.TENKHACHHANG = ten;
                hdQuery.NGAYLAP = Convert.ToDateTime(ngaytt);
                hoadon.SaveChanges();
            }
            return true;
        }

        //Xóa hóa đơn
        public bool XoaHoaDon(string mahd, ref string err)
        {
            HoaDonConnection hoadon = new HoaDonConnection();
            HOADON hd = new HOADON();
            hd.MAHOADON = mahd;
            hoadon.HOADONs.Attach(hd);
            hoadon.HOADONs.Remove(hd);
            hoadon.SaveChanges();
            return true;
        }
    }
}
