using ShopDienThoaiTCnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnGiuaKy.Models.BUS
{
    public class LoaiSPBUS
    {
        public static IEnumerable<LoaiSanPham> DanhSach()
        {
            var db = new ShopDienThoaiTCntDB();
            return db.Query<LoaiSanPham>("SELECT * FROM LoaiSanPham WHERE TinhTrang = 0");
        }
        public static IEnumerable<SanPham> ChiTietLoai(String id)
        {
            var db = new ShopDienThoaiTCntDB();
            return db.Query<SanPham>("SELECT * FROM SanPham WHERE MaLoaiSanPham = '"+id+ "'");
        }
    }
}