using Microsoft.EntityFrameworkCore.Diagnostics;
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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace quanlichannuoi.View
{
    /// <summary>
    /// Interaction logic for DonViCapXaControl.xaml
    /// </summary>
    public partial class DonViCapXaControl : UserControl
    {
        private readonly quanlichannuoicontroller _quanlichannuoicontroller;
        public DonViCapXaControl(quanlichannuoicontroller controller)
        {
            InitializeComponent();
            _quanlichannuoicontroller = controller;
           LoadData();

        }

        private void LoadData()
        {
            var xaList = _quanlichannuoicontroller.LoadDataXa();
            XaDataGrid.ItemsSource = xaList;
        }
        private void XaDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
