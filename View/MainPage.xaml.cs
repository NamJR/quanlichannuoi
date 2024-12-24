using Microsoft.Identity.Client;
using quanlichannuoi.Controller;
using quanlichannuoi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace quanlichannuoi.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private readonly quanlichannuoicontroller _quanlichannuoicontroller;
        private readonly quanlichannuoicontroller _quanlichannuoicontroller2;
        public MainPage()
        {
            InitializeComponent();
            AppDbcontext dbcontext = new AppDbcontext();
            AppDbcontextdvhc _context = new AppDbcontextdvhc();
            _quanlichannuoicontroller = new quanlichannuoicontroller(_context);
            _quanlichannuoicontroller2 = new quanlichannuoicontroller(dbcontext);

        }
       
        private void DonViCapHuyen_Click(object sender, RoutedEventArgs e)
        {
            XaPresenter.Visibility = Visibility.Collapsed;
            UserListView.Visibility = Visibility.Collapsed;
            HuyenPresenter.Content = new DonViCapHuyenControl(_quanlichannuoicontroller);
            HuyenPresenter.Visibility = Visibility.Visible;      

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NhomListView.Visibility = Visibility.Collapsed;
            HuyenPresenter.Visibility = Visibility.Collapsed;
            UserListView.Visibility = Visibility.Collapsed;
            XaPresenter.Content = new DonViCapXaControl(_quanlichannuoicontroller);
            XaPresenter.Visibility = Visibility.Visible;
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NhomListView.Visibility = Visibility.Collapsed;
            XaPresenter.Visibility = Visibility.Collapsed;
            HuyenPresenter.Visibility = Visibility.Collapsed;
            UserListView.Visibility= Visibility.Visible;
            var listuser = _quanlichannuoicontroller2.LoadDatadsnguoidung();
            UserListView.ItemsSource = listuser;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
             
            WindowProcess windowProcess = new WindowProcess();
            windowProcess.Show();
           
        }

        private void Button_timkiemhethong(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Quanlinhom(object sender, RoutedEventArgs e)
        {
            XaPresenter.Visibility = Visibility.Collapsed;
            HuyenPresenter.Visibility = Visibility.Collapsed;
            UserListView.Visibility = Visibility.Collapsed;
            NhomListView.Visibility = Visibility.Visible;
            var nhomlist = _quanlichannuoicontroller2.LoadDatanhom();
            NhomListView.ItemsSource = nhomlist;
        }

        private void Button_lichsutrycap(object sender, RoutedEventArgs e)
        {

        }

        private void Button_baocaotonghop(object sender, RoutedEventArgs e)
        {

        }
    }
}
