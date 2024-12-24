using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using quanlichannuoi.Model;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using quanlichannuoi.Controller;
using quanlichannuoi.View;

namespace quanlichannuoi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AppDbcontext context;
        //private readonly quanlichannuoicontroller quanlichannuoicontroller;
        public MainWindow()
        {
            InitializeComponent();
            context = new AppDbcontext();
           // quanlichannuoicontroller = new quanlichannuoicontroller(context);
        }
        private void signup_btn_Click(object sender, RoutedEventArgs e)
        {
            string _username = username_txt.Text;
            string _password = password_txt.Text;

            if (_username == null || _password == null)
            {
                MessageBox.Show("Error");
                return;
            }
            var exsist = context.Users.FirstOrDefault(u => _username == u.username);
            if (exsist != null)
            {
                MessageBox.Show("Ten dang nhap da ton tai");
                return;
            }
            var user = new User
            {
                username = _username,
                password = _password,
            };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Created Success");
  

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string _username = username_txt.Text;
            string _password = password_txt.Text;
            if (string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password))
            {
                MessageBox.Show("Error");
                return;
            }
            var user = context.Users.FirstOrDefault(u => u.username == _username && u.password == _password);
            if (user != null)
            {
                MessageBox.Show("Login Success");
              

                Windowpage.Navigate(new MainPage());
            

            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại");
                return;
            }
        }

        private void Logout_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Logout success");
            return;
        }

        private void Windowpage_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
