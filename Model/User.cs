using quanlichannuoi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace quanlichannuoi.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
    public class nhom
    {
        [Key]
        public string Idnhom { get; set; }
        public string tennhom { get; set; }
        public int Idtruongnhom { get; set; }
        public string quyenhan { get; set; }
        public int soluongthanhvien { get; set; }
        public DateTime ngaytaonhom { get; set; }
        [ForeignKey("Idtruongnhom")]
        public dsnguoidung dsnguoidung { get; set; }
    }
      

    public class dsnguoidung
    {
        [Key]
        
        public int ID { get; set; }
        public string hoten { get; set; }
        public string tendangnhap { get; set; }
        public string email { get; set; }
        public string sodienthoai { get; set; }
        public string quyenhan { get; set; }
        [ForeignKey("ID")]
        public User User { get; set; }
        public nhom nhom { get; set; }
    }
    public class Huyen
    {
        [Key]
        public string MaHuyen { get; set; }
        public string TenHuyen { get; set; }
        public string Tinh { get; set; }
        public ICollection<Xa> Xas { get; set; }
        public ICollection<cosochannuoi> cosochannuois { get; set; }
        public ICollection<cosochebien> cosochebiens { get; set; }
        public ICollection<chicucthuy> chicucthuys { get; set; }
    }
    public class Xa
    {
        [Key]
        public string MaXa { get; set; }
        public string TenXa { get; set; }
        [ForeignKey("MaHuyen")]
        public string MaHuyen { get; set; }

        public Huyen Huyen { get; set; }
        public ICollection<Cososanxuat> cososanxuats { get; set; }
        public ICollection <cosokhaonghiem> cosokhaonghiems { get; set; }
    }
    public class dongvat
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string tendongvat { get; set; }
        public float cannang {  get; set; }
        public string suckhoe {  get; set; }

    }
    public class Cososanxuat
    {
        [Key]
        [Required]
        public string ID { get; set; }
        public string Ten { get; set; }
        public string Diachi {  get; set; }
        public double Luongchatthai { get; set; } // double trong VScode phù hợp với float trong SQL Server
        [Required]
        public string IdXa { get; set; }
        [ForeignKey("IdXa")]
        public Xa Xa { get; set; }
    }
    public class cosokhaonghiem
    {
        public string ID { set; get; }
        public string Ten { get; set; }
        public string Diachi { set; get; }
        public string Congnghexuli { set; get; }
        public string Tinhtrang { set; get; }
        [Required]
        public string Idxa { set; get; }
        [ForeignKey("Idxa")]
        public Xa Xa { get; set; }
    }

    public class cosochannuoi
    {
        [Required]
        public string ID { set; get; }
        public string Ten { set; get; }
        public string Loaihinh { set; get; }
        public string Nguoidaidien { set; get; }
        public string Tinhtrang { get; set; }
        public string Diachi {  set; get; }
        [Required]
        public string IDhuyen { set; get; }
        [ForeignKey("IDhuyen")]
        public Huyen Huyen { get; set; }
        public virtual dieukienchannuoi dieukienchannuoi {  set; get; }
        public virtual giaychungnhancoso giaychungnhancoso { set; get; }
        public virtual vitri Vitri { set; get; }
    }

    public class dieukienchannuoi
    {
        [Key]
        [ForeignKey("cosochannuoi")]
        public string Idcoso {  get; set; }
        public double dientichchuongtrai { get; set; }
        public int soluongkhuvuc { get; set; }
        public string trangthietbi { get; set; }
        public string chatluongnguonnuoc { get; set; }
        public string loaithucan { get; set; }
        public virtual cosochannuoi cosochannuoi { get; set; }
    }
    public class giaychungnhancoso
    {
        [Key]
      
        public string Idcoso { get; set; }
        [Required]
        public string sohieu {  set; get; }
        public DateTime ngaycap { get; set; }
        [Required]
        public DateTime ngayhethan { get; set; }
        [Required]
        public string matochuccapphep { get; set; }
        public string tinhtrang { get; set; }
        [ForeignKey("Idcoso")]
        public virtual cosochannuoi Cosochannuoi { get; set; }
        public virtual tochuccapphep tochuccapphep { get; set; }
    }
    public class tochuccapphep
    {
        [Key]
        public string IDtochuc {  get; set; }
        public string Tentochuc {  get; set; }
        public string loaitochuc { get; set; }
        public string linhvucchungnhan {  get; set; }
        [ForeignKey("IDtochuc")]
        public virtual giaychungnhancoso giaychungnhancoso { get; set; }
    }
    public class cosochebien
    {
        [Key]
        public string Idcscb { get; set; }
        public string Tencscb { get; set; }
        public string diachicscb {  get; set; }
        public string nguyenlieu { get; set; }
        public string congsuatchebien { get; set; }
        public string soluongnhanvien { get; set; }
        public string mhuyen {  get; set; }
        [ForeignKey("mhuyen")]
        public virtual Huyen huyen {  get; set; }
    }
    public class vungchannuoi
    {
        [Key]
        public string mavung { get; set; }
        public string vitri { get; set; }
        public double dientich { get; set; }
        public int soluong { get; set; }
        public string loaihinh { get; set; }
    }
    public class vitri
    {
        [Key]
        public string ID { get; set; }
        public double kinhdo { get; set; }
        public double vido { get; set; }
        [ForeignKey("ID")]
        public virtual cosochannuoi Cosochannuoi { get; set; }
    }
    public class chicucthuy
    {
        [Key]
        public string IDchicuc { get; set; }
        public string tenchicuc { get; set; }
        public string tenquanli { get; set; }
        public string diachi { get; set; }
        public int soluongdongvat { get; set; }
        public string Idhuyen { get; set; }
        [ForeignKey("Idhuyen")]
        public Huyen huyen { get; set; }
        ICollection<cosogietmo> cosogietmos { get; set; }
    }
    public class dailybanthuoc
    {
        [Key]
        public string Iddaily { get; set; }
        public string tendaily { get; set; }
        public string nguoiquanly { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
        public string idhuyen { get; set; }
        [ForeignKey("idhuyen")]
        public Huyen huyen { get; set; }
    }
}
public class khutamgiu
{
    [Key]
    public string Idkhu { get; set; }
    public string Tenkhu { get; set; }
    public string diachi { get; set; }
    public string Loaikhu { get; set; }
    public string nguoiquanli { get; set; }
    public double dientich { get; set; }
    public int soluongdongvat { get; set; }
    public string tinhtrang { get; set; }
}
public class cosogietmo
{
    [Key]
    public string idcoso { get; set; }
    public string tencoso { get; set; }
    public string nguoiquanly { get; set; }
    public string sodienthoai { get; set; }
    public string congsuat { get; set; }
    public string tinhtrang { get; set; }
    public string macoquanquanly { get; set; }
    [ForeignKey("macoquanquanly")]
    public chicucthuy chicucthuy { get; set; }
}