using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NhanVienDAL
    {
        public List<NHANVIEN> getNhanVien()
        {
            List<NHANVIEN> dsNV = new List<NHANVIEN>();
            using (NhanVienConnection db = new NhanVienConnection())
            {
                var dsnv = from nv in db.NHANVIENs
                            select nv;
                foreach (var i in dsnv)
                {
                    NHANVIEN nv = new NHANVIEN();
                    nv.MANHANVIEN = i.MANHANVIEN;
                    nv.TENNHANVIEN = i.TENNHANVIEN;
                    nv.GIOITINH = i.GIOITINH;
                    nv.NGAYSINH = i.NGAYSINH;
                    nv.NGAYVAOLAM = nv.NGAYVAOLAM;
                    nv.DIACHI = i.DIACHI;
                    nv.SDT = i.SDT;

                    dsNV.Add(nv);
                }
            }
            return dsNV;
        }
    }
}
