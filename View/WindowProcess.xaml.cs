using quanlichannuoi.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace quanlichannuoi.View
{
    /// <summary>
    /// Interaction logic for WindowProcess.xaml
    /// </summary>
    public partial class WindowProcess : Window
    {
        private quanlichannuoicontroller _quanlichannuoicontroller;
        private readonly AppDbcontextdvhc _dbcontextdvhc;
        public WindowProcess()
        {
            InitializeComponent();
            AppDbcontextdvhc _context = new AppDbcontextdvhc();
            _quanlichannuoicontroller = new quanlichannuoicontroller(_context);
            _dbcontextdvhc = new AppDbcontextdvhc();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listViewCosokhaonghiem.Visibility = Visibility.Collapsed;
            Suachatthai.Visibility = Visibility.Collapsed;
            Xoachatthai.Visibility = Visibility.Collapsed;
            themchathai.Visibility = Visibility.Collapsed;
           ListViewcososanxuat.Visibility = Visibility.Visible;
            var cssx = _quanlichannuoicontroller.LoadDataCososanxuat();
            ListViewcososanxuat.ItemsSource = cssx;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
         
        }

        private void Button_Quanli(object sender, RoutedEventArgs e)
        {
            ListViewcosochebien.Visibility = Visibility.Collapsed;
            lvGiayChungNhan.Visibility = Visibility.Collapsed;
            listViewDieukienChannuoi.Visibility = Visibility.Collapsed;
            listViewCosochannuoi.Visibility = Visibility.Visible;
            var channuoiList = _quanlichannuoicontroller.LoadDataCosochannuoi();
            listViewCosochannuoi.ItemsSource = channuoiList;
        }

        private void Button_Tracuu(object sender, RoutedEventArgs e)
        {       
            string search = SearchBoxchannuoi.Text;
        
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Hãy nhập dữ liệu");
                return;
            }
            var check = _dbcontextdvhc.cosochannuoi.Where(x => x.ID.Contains(search) || x.Nguoidaidien.Contains(search) || x.IDhuyen.Contains(search) || x.Ten.Contains(search) || x.Diachi.Contains(search)|| x.Tinhtrang.Contains(search) || x.Loaihinh.Contains(search)).ToList();
            if(check.Count > 0)
            {
                ListViewtochuccapphep.Visibility = Visibility.Collapsed;
                listViewDieukienChannuoi.Visibility = Visibility.Collapsed;
                lvGiayChungNhan.Visibility = Visibility.Collapsed;
                listViewCosochannuoi.Visibility = Visibility.Visible;
                listViewCosochannuoi.ItemsSource = check;
                return;
            }
            else
            {
                MessageBox.Show("Không tìm thấy cơ sở");
                listViewCosochannuoi.Visibility = Visibility.Collapsed;
                return;
            }
        }

        private void Button_Chungnhan(object sender, RoutedEventArgs e)
        {
            ListViewcosochebien.Visibility = Visibility.Collapsed;
            ListViewtochuccapphep.Visibility = Visibility.Collapsed;
            listViewCosochannuoi.Visibility= Visibility.Collapsed;
            listViewCosokhaonghiem.Visibility= Visibility.Collapsed;
            listViewDieukienChannuoi.Visibility= Visibility.Collapsed;
            lvGiayChungNhan.Visibility= Visibility.Visible;
            var giaychungnhan = _quanlichannuoicontroller.LoadDatagiaychungnhancoso();
            lvGiayChungNhan.ItemsSource = giaychungnhan;
        }

        private void Button_DieuKien(object sender, RoutedEventArgs e)
        {
            ListViewcosochebien.Visibility = Visibility.Collapsed;
            ListViewtochuccapphep.Visibility= Visibility.Collapsed;
            listViewCosokhaonghiem.Visibility = Visibility.Collapsed;
            lvGiayChungNhan.Visibility = Visibility.Collapsed;
            listViewCosochannuoi.Visibility= Visibility.Collapsed;
            listViewDieukienChannuoi.Visibility= Visibility.Visible;
            var dieukienlist = _quanlichannuoicontroller.LoadDatadieukienchannuoi();
            listViewDieukienChannuoi.ItemsSource= dieukienlist;
        }

        private void Button_ChiCucThuY(object sender, RoutedEventArgs e)
        {
            listViewCoSogietmo.Visibility= Visibility.Collapsed;    
            ListViewKhutamgiu.Visibility= Visibility.Collapsed; 
            listViewDaily.Visibility= Visibility.Collapsed;
            listviewchicucthuy.Visibility= Visibility.Visible;
            var chicucthuy = _quanlichannuoicontroller.LoadDatachicucthuy();
            listviewchicucthuy.ItemsSource = chicucthuy;
        }

        private void Button_TraCuuChiCucThuY(object sender, RoutedEventArgs e)
        {
            var search = SearchBoxyte.Text;
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Hãy nhập dữ liệu");
                return;
            }
            var chicucthuy = _dbcontextdvhc.chicucthuy.Where(x => x.IDchicuc.Contains(search) || x.tenchicuc.Contains(search) || x.tenquanli.Contains(search) || x.soluongdongvat.ToString().Contains(search) || x.Idhuyen.Contains(search)).ToList();
            if(chicucthuy.Count > 0)
            {
                listViewCoSogietmo.Visibility = Visibility.Collapsed;
                ListViewKhutamgiu.Visibility = Visibility.Collapsed;
                listViewDaily.Visibility= Visibility.Collapsed;
                listviewchicucthuy.Visibility = Visibility.Visible;
               listviewchicucthuy.ItemsSource = chicucthuy;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu");
                return ;
            }
        }

        private void Button_DaiLyThuY(object sender, RoutedEventArgs e)
        {
            listViewCoSogietmo.Visibility = Visibility.Collapsed;
            ListViewKhutamgiu.Visibility = Visibility.Collapsed;
            listviewchicucthuy.Visibility= Visibility.Collapsed;
            listViewDaily.Visibility = Visibility.Visible;
            var dailylist = _quanlichannuoicontroller.LoadDatadailybanthuoc();
            listViewDaily.ItemsSource = dailylist;
        }

        private void Button_TraCuuDaiLyThuY(object sender, RoutedEventArgs e)
        {
            
            var search = SearchBoxyte.Text;
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Hãy nhập dữ liệu");
                return ;
            }
            var check = _dbcontextdvhc.dailybanthuoc.Where(x => x.Iddaily.Contains(search) || x.tendaily.Contains(search) || x.nguoiquanly.Contains(search) || x.idhuyen.Contains(search) || x.diachi.Contains(search) || x.sdt.Contains(search)).ToList();
            if(check.Count > 0)
            {
                listviewchicucthuy.Visibility = Visibility.Collapsed;
                listViewCoSogietmo.Visibility = Visibility.Collapsed;
                ListViewKhutamgiu.Visibility = Visibility.Collapsed;
                listViewDaily.Visibility= Visibility.Visible;
                listViewDaily.ItemsSource = check;
                return;
            }
            else
            {
                MessageBox.Show("Không tìm thấy đại lý");
                return;
            }
        }

        private void Button_Timkiemcssx(object sender, RoutedEventArgs e)
        { 
            string search = SearchBox.Text;
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Hãy nhập dữ liệu");
                return;
            }
            var check = _dbcontextdvhc.Cososanxuats.Where( x => x.ID.Contains(search) || x.IdXa.Contains(search) || x.Luongchatthai.ToString().Contains(search) || x.Diachi.Contains(search)).ToList();
            if(check.Count() > 0)
            {
                themchathai.Visibility= Visibility.Collapsed;
                listViewCosokhaonghiem.Visibility= Visibility.Collapsed;
                ListViewcososanxuat.Visibility = Visibility.Visible;
                ListViewcososanxuat.ItemsSource = check;
                return;
            }
            else
            {
                MessageBox.Show("không tìm thấy cơ sở");
                return;
            }
        }

        private void Button_Danhmuckhaonghiem(object sender, RoutedEventArgs e)
        {
            Suachatthai.Visibility= Visibility.Collapsed;
            Xoachatthai.Visibility= Visibility.Collapsed;
            themchathai.Visibility = Visibility.Collapsed;
            ListViewcososanxuat.Visibility = Visibility.Collapsed;
            listViewCosokhaonghiem.Visibility = Visibility.Visible;
            var khaonghiemList = _quanlichannuoicontroller.LoadDataCosokhaonghiem();
            listViewCosokhaonghiem.ItemsSource = khaonghiemList;
        }

        private void Button_Timkiemkhaonghiem(object sender, RoutedEventArgs e)
        {
            string search = SearchBox.Text;
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Hãy nhập dữ liệu");
                return;
            }
            var check = _dbcontextdvhc.cosokhaonghiem.Where(x => x.ID == search || x.Idxa == search || x.Tinhtrang == search || x.Congnghexuli == search).ToList();
            if (check.Count > 0 )
            {
                themchathai.Visibility ^= Visibility.Collapsed;
                listViewCosokhaonghiem.Visibility = Visibility.Visible;
                listViewCosokhaonghiem.ItemsSource = check;
                return;
            }
            else
            {
                MessageBox.Show("không tìm thấy cơ sở");
                listViewCosokhaonghiem.Visibility= Visibility.Collapsed;
                return;
            }
        }

        private void Button_Tracuutccapphep(object sender, RoutedEventArgs e)
        {
            string search = SearchBoxchannuoi.Text;
           
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Hãy nhập dữ liệu");
            }
            var check = _dbcontextdvhc.tochuccapphep.Where(x => x.IDtochuc.Contains(search)).ToList();
            if (check.Count > 0)
            {
                listViewCosochannuoi.Visibility = Visibility.Collapsed;
                listViewCosokhaonghiem.Visibility = Visibility.Collapsed;
                listViewDieukienChannuoi.Visibility = Visibility.Collapsed;
                lvGiayChungNhan.Visibility = Visibility.Collapsed;
                ListViewtochuccapphep.Visibility = Visibility.Visible;
                ListViewtochuccapphep.ItemsSource = check;
                return;
            }
            else
            {
                MessageBox.Show("không tìm thấy dữ liệu");
                return;
            }

        }

        private void Button_cosochebien(object sender, RoutedEventArgs e)
        {
            listViewCosochannuoi.Visibility = Visibility.Collapsed;
            listViewCosokhaonghiem.Visibility = Visibility.Collapsed;
            listViewDieukienChannuoi.Visibility = Visibility.Collapsed;
            lvGiayChungNhan.Visibility = Visibility.Collapsed;
            ListViewtochuccapphep.Visibility = Visibility.Collapsed;
            ListViewcosochebien.Visibility= Visibility.Visible;
            var cscblist = _quanlichannuoicontroller.LoadDatacosochebien();
            ListViewcosochebien.ItemsSource = cscblist;
        }

        private void Button_tracuucosochebien(object sender, RoutedEventArgs e)
        {
            var search = SearchBoxchannuoi.Text; 
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Hãy nhập dữ liệu");
                return;
            }
            var check = _dbcontextdvhc.cosochebien.Where(x => x.Idcscb.Contains(search) || x.Tencscb.Contains(search) || x.soluongnhanvien.Contains(search) || x.nguyenlieu.Contains(search) || x.congsuatchebien.Contains(search) || x.mhuyen.Contains(search)).ToList();
            if (check.Count > 0)
            {
                listViewCosochannuoi.Visibility = Visibility.Collapsed;
                listViewCosokhaonghiem.Visibility = Visibility.Collapsed;
                listViewDieukienChannuoi.Visibility = Visibility.Collapsed;
                lvGiayChungNhan.Visibility = Visibility.Collapsed;
                ListViewtochuccapphep.Visibility = Visibility.Collapsed;
                ListViewcosochebien.Visibility = Visibility.Visible;
                ListViewcosochebien.ItemsSource= check;
                return;
            }
            else
            {
                MessageBox.Show("Không tìm thấy cơ sở");
                return;
            }
        }

        private void SearchBoxyte_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_khutamgiu(object sender, RoutedEventArgs e)
        {
            listViewDaily.Visibility = Visibility.Collapsed;
             listViewCoSogietmo.Visibility = Visibility.Collapsed;
            listviewchicucthuy.Visibility = Visibility.Collapsed;
            ListViewKhutamgiu.Visibility = Visibility.Visible;
            var tamgiulist = _quanlichannuoicontroller.LoadDatakhutamgiu(); 
            ListViewKhutamgiu.ItemsSource= tamgiulist;
        }

        private void Button_TraCuukhutamgiu(object sender, RoutedEventArgs e)
        {
            var search = SearchBoxyte.Text;
            if(string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Hãy nhập dữ liệu");
            }
            var check = _dbcontextdvhc.khutamgiu.Where(x => x.Idkhu.Contains(search) || x.Tenkhu.Contains(search) || x.Loaikhu.Contains(search) || x.nguoiquanli.Contains(search) || x.tinhtrang.Contains(search) || x.dientich.ToString().Contains(search)).ToList();
            if(check.Count > 0)
            {
                listViewDaily.Visibility = Visibility.Collapsed;
                listViewCoSogietmo.Visibility = Visibility.Collapsed;
                listviewchicucthuy.Visibility= Visibility.Collapsed;
                ListViewKhutamgiu.Visibility= Visibility.Visible;
                ListViewKhutamgiu.ItemsSource = check;
            }
            else
            {
                MessageBox.Show("không tìm thấy dữ liệu");
            }
        }

        private void Button_cosogietmo(object sender, RoutedEventArgs e)
        {
            ListViewKhutamgiu.Visibility= Visibility.Collapsed;
            listviewchicucthuy.Visibility = Visibility.Collapsed;
            listViewDaily.Visibility= Visibility.Collapsed;
            listViewCoSogietmo.Visibility = Visibility.Visible;
            var cosogietmo = _quanlichannuoicontroller.LoadDatacosogietmo();
            listViewCoSogietmo.ItemsSource = cosogietmo;
        }

        private void Button_TraCuucosogietmo(object sender, RoutedEventArgs e)
        {
            var search = SearchBoxyte.Text;
            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Hãy nhập dữ liệu");
            }
            var check = _dbcontextdvhc.cosogietmo.Where(x => x.idcoso.Contains(search) || x.tencoso.Contains(search) || x.nguoiquanly.Contains(search) || x.sodienthoai.Contains(search) || x.congsuat.Contains(search) || x.tinhtrang.Contains(search) || x.macoquanquanly.Contains(search)).ToList();
            if (check.Count > 0)
            {
                listViewDaily.Visibility = Visibility.Collapsed;
                listviewchicucthuy.Visibility = Visibility.Collapsed;
                ListViewKhutamgiu.Visibility = Visibility.Collapsed;
                listViewCoSogietmo.Visibility = Visibility.Visible;
                listViewCoSogietmo.ItemsSource = check;
            }
            else
            {
                MessageBox.Show("không tìm thấy dữ liệu");
            }
        }

        private void Button_Themchatthai(object sender, RoutedEventArgs e)
        {
            Xoachatthai.Visibility = Visibility.Collapsed;
            Suachatthai.Visibility = Visibility.Collapsed;
            ListViewcososanxuat.Visibility = Visibility.Collapsed;
            listViewCosokhaonghiem.Visibility = Visibility.Collapsed;
            themchathai.Visibility = Visibility.Visible;
        }

        private void Button_Xoachatthai(object sender, RoutedEventArgs e)
        {
            Suachatthai.Visibility= Visibility.Collapsed;
            themchathai.Visibility = Visibility.Collapsed;
            listViewCosokhaonghiem.Visibility = Visibility.Collapsed;
            ListViewcososanxuat.Visibility = Visibility.Collapsed;
            Xoachatthai.Visibility = Visibility.Visible;
        }

        private void Button_Suachatthai(object sender, RoutedEventArgs e)
        {
            themchathai.Visibility = Visibility.Collapsed;
            listViewCosokhaonghiem.Visibility = Visibility.Collapsed;
            ListViewcososanxuat.Visibility = Visibility.Collapsed;
            Xoachatthai.Visibility = Visibility.Collapsed;
            Suachatthai.Visibility = Visibility.Visible;
        }

        private void Button_Xongthemchatthai(object sender, RoutedEventArgs e)
        {
            string id = IDTextBox.Text;
            string ten = TenTextBox.Text;
            string diachi = DiachiTextBox.Text;
            double luongchatthai = double.Parse(LuongchatthaiTextBox.Text);
            string idxa = IdXaTextBox.Text;
            _quanlichannuoicontroller.addcososanxuat(id, ten, diachi, luongchatthai, idxa);
            MessageBox.Show("Đã thêm cơ sở");
            return;
        }

        private void Button_Xongxoachatthai(object sender, RoutedEventArgs e)
        {
            string id = IDxoaTextBox.Text;
            _quanlichannuoicontroller.xoacososanxuat(id);
            MessageBox.Show("Đã Xóa Cơ Sở");
            return;
        }

        private void Button_Xongsuachatthai(object sender, RoutedEventArgs e)
        {
            string id = IDsuaTextBox.Text;
            double luongchatthainew = double.Parse(LuongchatthaisuaTextBox.Text);
            _quanlichannuoicontroller.suacososanxuat(id, luongchatthainew);
            MessageBox.Show("Đã sửa dữ liệu");
            return;
        }
    }
}
