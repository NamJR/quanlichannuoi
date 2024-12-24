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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace quanlichannuoi.View
{
    /// <summary>
    /// Interaction logic for DonViCapHuyenControl.xaml
    /// </summary>
    public partial class DonViCapHuyenControl : System.Windows.Controls.UserControl
    {
        private readonly quanlichannuoicontroller _quanlichannuoicontroller;

        public DonViCapHuyenControl(quanlichannuoicontroller controller)
        {
            InitializeComponent();
           _quanlichannuoicontroller = controller;
            LoadDatah();
        }
        void LoadDatah()
        {
            var huyenList = _quanlichannuoicontroller.LoadDataHuyen();
            HuyenDataGrid.ItemsSource = huyenList;
        }
        private void HuyenDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
