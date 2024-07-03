using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class SachBUS
    {
        //Kiểm tra
        public bool checkSach(string mas)
        {
            SachDAL s = new SachDAL();
            List<SACH> list = new List<SACH>();
            list = s.getSach();
            foreach (var i in list)
            {
                if (i.MASACH== mas)
                    return true;
            }
            return false;
        }
        //Kiểm tra chuỗi id nhập vào
        public bool checkId(string id)
        {
            if (id.Length == 7)
                return true;
            return false;
        }
        //Lấy
        public DataTable getSachToDGV(string lv)
        {
            SachConnection db = new SachConnection();
            var dsS = (from sach in db.SACHes
                       where sach.TENLINHVUC == lv
                       select sach);

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sách");
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Mã tác giả");
            dt.Columns.Add("Lĩnh vực");
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Giá mua");
            dt.Columns.Add("Giá bìa");
            dt.Columns.Add("Nhà xuất bản");
            dt.Columns.Add("Lần tái bản");
            dt.Columns.Add("Năm xuất bản");

            foreach (var s in dsS)
            {
                dt.Rows.Add(s.MASACH, s.TENSACH, s.MATG, s.TENLINHVUC, s.TENLOAISACH, s.GIAMUA, s.GIABIA, s.TENNHAXUATBAN, s.LANTAIBAN, s.NAMXUATBAN);
            }
            return dt;
        }
        public DataTable getSachToDGV1(string tens)
        {
            SachConnection db = new SachConnection();
            var dsS = (from sach in db.SACHes
                       where sach.TENSACH == tens
                       select sach);

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sách");
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Mã tác giả");
            dt.Columns.Add("Lĩnh vực");
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Giá mua");
            dt.Columns.Add("Giá bìa");
            dt.Columns.Add("Nhà xuất bản");
            dt.Columns.Add("Lần tái bản");
            dt.Columns.Add("Năm xuất bản");

            foreach (var s in dsS)
            {
                dt.Rows.Add(s.MASACH, s.TENSACH, s.MATG, s.TENLINHVUC, s.TENLOAISACH, s.GIAMUA, s.GIABIA, s.TENNHAXUATBAN, s.LANTAIBAN, s.NAMXUATBAN);
            }
            return dt;
        }

        public DataTable getSachToDGV2(string nxb)
        {
            SachConnection db = new SachConnection();
            var dsS = (from sach in db.SACHes
                       where sach.TENNHAXUATBAN == nxb
                       select sach);

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sách");
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Mã tác giả");
            dt.Columns.Add("Lĩnh vực");
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Giá mua");
            dt.Columns.Add("Giá bìa");
            dt.Columns.Add("Nhà xuất bản");
            dt.Columns.Add("Lần tái bản");
            dt.Columns.Add("Năm xuất bản");

            foreach (var s in dsS)
            {
                dt.Rows.Add(s.MASACH, s.TENSACH, s.MATG, s.TENLINHVUC, s.TENLOAISACH, s.GIAMUA, s.GIABIA, s.TENNHAXUATBAN, s.LANTAIBAN, s.NAMXUATBAN);
            }
            return dt;
        }

        //Thêm
        public bool ThemSach(string maS, string tenS, string maTG, string linh_vuc, string the_loai, int gia_mua, int gia_bia, string nxb, int lan_tb, DateTime nam_xb)
        {
            SachConnection dsS = new SachConnection();

            SACH sach = new SACH();
            sach.MASACH = maS;
            sach.TENSACH = tenS;
            sach.MATG = maTG;
            sach.TENLINHVUC = linh_vuc;
            sach.TENLOAISACH = the_loai;
            sach.GIAMUA = gia_mua;
            sach.GIABIA = gia_bia;
            sach.TENNHAXUATBAN = nxb;
            sach.LANTAIBAN = lan_tb;
            sach.NAMXUATBAN = nam_xb;

            dsS.SACHes.Add(sach);
            dsS.SaveChanges();
            return true;
        }
        //Xóa
        public bool XoaSach(ref string err, string maSach)
        {
            SachConnection dsS = new SachConnection();
            SACH s = new SACH();
            s.MASACH = maSach;

            dsS.SACHes.Attach(s);
            dsS.SACHes.Remove(s);

            dsS.SaveChanges();
            return true;
        }

        //Sửa - cho sửa giá mua, giá bìa, lần tái bản và năm xb
        public bool SuaSach(string maS, int gia_mua, int gia_bia, int lan_tb, DateTime nam_xb, ref string err)
        {
            SachConnection dsS = new SachConnection();
            var sach_query = (from s in dsS.SACHes
                              where s.MASACH == maS
                              select s).SingleOrDefault();
            if (sach_query != null)
            {
                sach_query.GIAMUA = gia_mua;
                sach_query.GIABIA = gia_bia;
                sach_query.LANTAIBAN = lan_tb;
                sach_query.NAMXUATBAN = nam_xb;

                dsS.SaveChanges();
            }
            return true;
        }
    }
}
