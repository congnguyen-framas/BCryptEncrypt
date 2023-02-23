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
            txtPassHash.Text = BC.HashPassword(txtPass.Text,12);
        }

        private void btnDecrypt_Click(object sender, RoutedEventArgs e)
        {
            labResult.Text=($"Result check pass: { BC.Verify(txtPass.Text, txtPassHash.Text)}");
        }
    }
}
