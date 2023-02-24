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
using BC = BCrypt.Net.BCrypt;

namespace BCrypt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            txtContentHash.Text = BC.HashPassword(txtContent.Text,12);
        }

        private void btnVerify_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Result check pass: { BC.Verify(txtContent.Text, txtContentHash.Text)}","Verify resut",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void btnCopyEncrypt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Clipboard.SetText(txtContentHash.Text);
        }
    }
}
