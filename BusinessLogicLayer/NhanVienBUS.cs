using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class NhanVienBUS
    {
        //Kiểm tra chuỗi id nhập vào
        public bool checkId(string id)
        {
            if (id.Length == 7)
                return true;
            return false;
        }
        //Kiểm tra sdt
        public bool checkPhone(string phone)
        {
            if (phone.Length == 10 || phone.Length == 12)
                return true;
            return false;
        }
        //Kiểm tra nhân viên này đã có trong db chưa
        public bool checkNhanVien(string manv)
        {
            NhanVienDAL nv = new NhanVienDAL();
            List<NHANVIEN> list = new List<NHANVIEN>();
            list = nv.getNhanVien();
            foreach (var i in list)
            {
                if (i.MANHANVIEN == manv)
                    return true;
            }
            return false;
        }
        public DataTable LayNhanVien()
        {
            NhanVienConnection nhanvien = new NhanVienConnection();
            var nvs = from n in nhanvien.NHANVIENs select n;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Tên nhân viên");
            dt.Columns.Add("Ngày vào làm");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Số điện thoại");
            foreach (var i in nvs)
            {
                dt.Rows.Add(i.MANHANVIEN, i.TENNHANVIEN, i.NGAYVAOLAM, i.DIACHI, i.SDT);
            }
            return dt;
        }

        public bool ThemNhanVien(string manv, string hoten, bool gioitinh, string ngaysinh,
            string ngayvaolam, string diachi, string sdt, ref string err)
        {
            NhanVienConnection nhanvien = new NhanVienConnection();
            NHANVIEN nv = new NHANVIEN();
            nv.MANHANVIEN = manv;
            nv.TENNHANVIEN = hoten;
            nv.GIOITINH = gioitinh;
            nv.NGAYSINH = Convert.ToDateTime(ngaysinh);
            nv.NGAYVAOLAM = Convert.ToDateTime(ngayvaolam);
            nv.DIACHI = diachi;
            nv.SDT = sdt;
            nhanvien.NHANVIENs.Add(nv);
            nhanvien.SaveChanges();
            return true;

        }

        public bool SuaNhanVien(string manv,string hoten, bool gioitinh, string ngaysinh,
            string ngayvaolam, string diachi, string sdt, ref string err)
        {
            NhanVienConnection nhanvien = new NhanVienConnection();
            var nvQuery = (from tp in nhanvien.NHANVIENs
                           where tp.MANHANVIEN == manv
                           select tp).SingleOrDefault();
            if (nvQuery != null)
            {
                nvQuery.TENNHANVIEN = hoten;
                nvQuery.GIOITINH = gioitinh;
                nvQuery.NGAYSINH = Convert.ToDateTime(ngaysinh);
                nvQuery.NGAYVAOLAM = Convert.ToDateTime(ngayvaolam);
                nvQuery.DIACHI = diachi;
                nvQuery.SDT = sdt;
                nhanvien.SaveChanges();
            }
            return true;
        }

        public bool XoaNhanVien(string manv, ref string errr)
        {
            NhanVienConnection nhanvien = new NhanVienConnection();
            NHANVIEN nv = new NHANVIEN();
            nv.MANHANVIEN = manv;
            nhanvien.NHANVIENs.Attach(nv);
            nhanvien.NHANVIENs.Remove(nv);
            nhanvien.SaveChanges();
            return true;
        }
    }
}
