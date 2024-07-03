using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class KhoBUS
    {

        //Kiểm tra sách có trong kho không
        public bool checkSachKho(string mas)
        {
            KhoDAL dsS = new KhoDAL();
            List<KHO> list = new List<KHO>();
            list = dsS.getKho();
            foreach (var i in list)
            {
                if (i.MASACH==mas)
                {
                    return true;
                }
            }
            return false;
        }
        //Kiểm tra xem còn sách không.
        public bool checkKho(int soluong)
        {
            KhoDAL dsS = new KhoDAL();
            List<KHO> list = new List<KHO>();
            list = dsS.getKho();
            foreach (var i in list)
            {
                if (soluong>0 && i.SOLUONG == soluong)
                {
                    return true;
                }
            }
            return false;
        }
        //Lấy 
        public DataTable LaySachTrongKho()
        {
            KhoConnection hoadon = new KhoConnection();
            var hds = from n in hoadon.KHOes select n;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Số lượng");
            foreach (var i in hds)
            {
                dt.Rows.Add(i.MASACH, i.SOLUONG);
            }
            return dt;
        }

        //Thêm sách mới vào kho
        public bool ThemSachVaoKho(string mas, string soluong, ref string err)
        {
            KhoConnection SACH = new KhoConnection();
            KHO hd = new KHO();
            hd.MASACH = mas;
            hd.SOLUONG =Convert.ToInt32( soluong);
            SACH.KHOes.Add(hd);
            SACH.SaveChanges();
            return true;
        }

        //Xóa sách ra khỏi kho
        public bool XoaSach(string mas, ref string err)
        {
            KhoConnection Sach = new KhoConnection();
            KHO hd = new KHO();
            hd.MASACH = mas;
            Sach.KHOes.Attach(hd);
            Sach.KHOes.Remove(hd);
            Sach.SaveChanges();
            return true;
        }

        //Chỉnh sửa số lượng sách còn lại trong kho
        public bool SuaSoLuong(string mas,string soluong, ref string err)
        {
            KhoConnection sach = new KhoConnection();
            var hdQuery = (from hd in sach.KHOes
                           where hd.MASACH == mas
                           select hd).SingleOrDefault();
            if (hdQuery != null)
            {
                hdQuery.SOLUONG =Convert.ToInt32( soluong);
                sach.SaveChanges();
            }
            return true;
        }
    }
}
