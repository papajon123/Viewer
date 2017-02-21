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
using Xceed.Wpf.Toolkit;
using System.Management;
using static System.Net.Dns;

namespace Viewer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var host = GetHostName();
            var IP = GetHostByName(host).AddressList[0].ToString();
            InitializeComponent();
            label.Content = host;
            label2.Content = IP;
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            //   if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            //   {
            //       MainWindow.
            //      MainWindow.Position = new Point(Cursor.Position.X - 3000, Cursor.Position.Y - 300);
            //   }
        }

        private void image_MouseEnter(object sender, MouseEventArgs e)
        {
            Xceed.Wpf.Toolkit.MessageBox.Show("W");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var host = GetHostName();
            var IP = GetHostByName(hostName: host).AddressList[0].ToString();

            label.Content = host;
            label2.Content = IP;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}