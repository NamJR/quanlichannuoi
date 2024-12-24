using Microsoft.Identity.Client;
using quanlichannuoi.Model;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace quanlichannuoi.Controller
{
    public class quanlichannuoicontroller
    {
        public readonly AppDbcontextdvhc _context;
        public readonly AppDbcontext _dbcontext;
        public quanlichannuoicontroller(AppDbcontextdvhc context)
        {
            _context = context;
        }
        public quanlichannuoicontroller(AppDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public List<dsnguoidung> LoadDatadsnguoidung()
        {
            var dsuser = _dbcontext.dsnguoidung.Select(x => new dsnguoidung
            {
                ID = x.ID,
                hoten = x.hoten,
                tendangnhap = x.tendangnhap,
                email = x.email,
                sodienthoai = x.sodienthoai,
                quyenhan = x.quyenhan
            }).ToList();
            return dsuser;
        }
        public List<nhom> LoadDatanhom()
        {
            var nhom = _dbcontext.nhom.Select(x=> new nhom
            {
                Idnhom = x.Idnhom,
                tennhom = x.tennhom,
                Idtruongnhom = x.Idtruongnhom,
                quyenhan = x.quyenhan,
                soluongthanhvien = x.soluongthanhvien,
                ngaytaonhom = x.ngaytaonhom
            }).ToList();
            return nhom;
        }
        public List<Xa> LoadDataXa()
        {
            var donvicapxalist = _context.Xas.Select(x => new Xa
            {
                MaXa = x.MaXa,
                TenXa = x.TenXa,
                MaHuyen = x.MaHuyen
            }).ToList();
            return donvicapxalist;
        }
        public List<Huyen> LoadDataHuyen()
        {
            var donvicaphuyen = _context.Huyens.Select(x => new Huyen
            {
                MaHuyen = x.MaHuyen,
                TenHuyen = x.TenHuyen,
                Tinh = x.Tinh
            }).ToList();
            return donvicaphuyen;
        }
        public List<Cososanxuat> LoadDataCososanxuat()
        {
            var cososanxuat = _context.Cososanxuats.Select(x => new Cososanxuat
            {
                ID = x.ID,
                Ten = x.Ten,
                Diachi = x.Diachi,
                Luongchatthai = x.Luongchatthai,
                IdXa = x.IdXa
            }).ToList();
            return cososanxuat;
        }
        public List<cosokhaonghiem> LoadDataCosokhaonghiem()
        {
            var cosokhaonghiem = _context.cosokhaonghiem.Select(x => new cosokhaonghiem
            {
                ID = x.ID,
                Ten = x.Ten,
                Diachi = x.Diachi,
                Congnghexuli = x.Congnghexuli,
                Tinhtrang = x.Tinhtrang,
                Idxa = x.Idxa,
            }).ToList();
            return cosokhaonghiem;
        }
        public List<cosochannuoi> LoadDataCosochannuoi()
        {
            var cosochannuoi = _context.cosochannuoi.Select(x => new cosochannuoi
            {
                ID = x.ID,
                Ten = x.Ten,
                Loaihinh = x.Loaihinh,
                Nguoidaidien = x.Nguoidaidien,
                Tinhtrang = x.Tinhtrang,
                Diachi = x.Diachi,
                IDhuyen = x.IDhuyen,
            }).ToList();
            return cosochannuoi;
        }
        public List<dieukienchannuoi> LoadDatadieukienchannuoi()
        {
            var dieukienchannuoi = _context.dieukienchannuoi.Select(x => new dieukienchannuoi
            {
                Idcoso = x.Idcoso,
                dientichchuongtrai = x.dientichchuongtrai,
                soluongkhuvuc = x.soluongkhuvuc,
                trangthietbi = x.trangthietbi,
                chatluongnguonnuoc = x.chatluongnguonnuoc,
                loaithucan = x.loaithucan
            }).ToList();
            return dieukienchannuoi;
        }
        public List<giaychungnhancoso> LoadDatagiaychungnhancoso()
        {
            var giaychungnhancoso = _context.giaychungnhancoso.Select(x => new giaychungnhancoso
            {
                Idcoso = x.Idcoso,
                sohieu = x.sohieu,
                ngaycap = x.ngaycap,
                ngayhethan = x.ngayhethan,
                matochuccapphep = x.matochuccapphep,
                tinhtrang = x. tinhtrang
            }).ToList();
            return giaychungnhancoso;
        }
        public List<tochuccapphep> LoadDatatochuccapphep()
        {
            var tochuccapphep = _context.tochuccapphep.Select(x => new tochuccapphep
            {
                IDtochuc = x.IDtochuc,
                Tentochuc = x.Tentochuc,
                loaitochuc = x.loaitochuc,
                linhvucchungnhan = x.linhvucchungnhan
            }).ToList();
            return tochuccapphep;   
        }
        public List<cosochebien> LoadDatacosochebien()
        {
            var cosochebien = _context.cosochebien.Select(x => new cosochebien
            {
                Idcscb = x.Idcscb,
                Tencscb = x.Tencscb,
                diachicscb = x.diachicscb,
                nguyenlieu = x.nguyenlieu,
                congsuatchebien = x.congsuatchebien,
                soluongnhanvien = x.soluongnhanvien,
                mhuyen = x.mhuyen
            }).ToList();
            return cosochebien;
        }
        public List<vitri> LoadDatavitri()
        {
            var vitri = _context.vitri.Select(x => new vitri
            {
                ID = x.ID,
                kinhdo = x.kinhdo,
                vido = x.vido
            }).ToList();
            return vitri;
        }
        public List<chicucthuy> LoadDatachicucthuy()
        {
            var chicuc = _context.chicucthuy.Select(x => new chicucthuy
            {
                IDchicuc = x.IDchicuc,
                tenchicuc = x.tenchicuc,
                tenquanli = x.tenquanli,
                diachi = x.diachi,
                soluongdongvat = x.soluongdongvat,
                Idhuyen = x.Idhuyen
            }).ToList();
            return chicuc;
        }
        public List<dailybanthuoc> LoadDatadailybanthuoc()
        {
            var daily = _context.dailybanthuoc.Select(x => new dailybanthuoc
            {
                Iddaily = x.Iddaily,
                tendaily = x.tendaily,
                nguoiquanly = x.nguoiquanly,
                sdt = x.sdt,
                diachi = x.diachi,
                idhuyen = x.idhuyen
            }).ToList();
            return daily;
        }
        public List<khutamgiu> LoadDatakhutamgiu()
        {
            var khutamgiu = _context.khutamgiu.Select(x => new khutamgiu
            {
                Idkhu = x.Idkhu,
                Tenkhu = x.Tenkhu,
                diachi = x.diachi,
                Loaikhu = x.Loaikhu,
                nguoiquanli = x.nguoiquanli,
                dientich = x.dientich,
                soluongdongvat = x.soluongdongvat,
                tinhtrang = x.tinhtrang
            }).ToList();
            return khutamgiu;
        }
        public List<cosogietmo> LoadDatacosogietmo()
        {
            var cosogietmo = _context.cosogietmo.Select(x => new cosogietmo
            {
                idcoso = x.idcoso,
                tencoso = x.tencoso,
                nguoiquanly = x.nguoiquanly,
                sodienthoai = x.sodienthoai,
                congsuat = x.congsuat,
                tinhtrang = x.tinhtrang,
                macoquanquanly = x.macoquanquanly
            }).ToList();
            return cosogietmo;
        }
        public void addcososanxuat(string ID, string ten, string diachi, double luongchatthai, string idxa)
        {
            var coso = new Cososanxuat
            {
                ID = ID,
                Ten = ten,
                Diachi = diachi,
                Luongchatthai = luongchatthai,
                IdXa = idxa
            };
            _context.Add(coso);
            _context.SaveChanges();
        }
        public void xoacososanxuat(string id)
        {
           var coso = _context.Cososanxuats.FirstOrDefault(x => x.ID == id);
           _context.Remove(coso);
            _context.SaveChanges();
        }
        public void suacososanxuat(string id, double luongchatthaimoi)
        {
            var coso = _context.Cososanxuats.FirstOrDefault(x => x.ID == id);
            coso.Luongchatthai = luongchatthaimoi;
            _context.SaveChanges();
        }
    }
}
