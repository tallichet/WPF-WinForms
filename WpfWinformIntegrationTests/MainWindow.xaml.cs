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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfWinformIntegrationTests
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly WindowInteropHelper wiHelper;

        public MainWindow()
        {
            InitializeComponent();
            wiHelper = new WindowInteropHelper(this);
            wiHelper.Owner = wiHelper.Handle;
        }

        private void OpenForm(object sender, RoutedEventArgs e)
        {
            BasicWinformApp.Form1 form = new BasicWinformApp.Form1();
            form.Show();
        }

        private void OpenDialog(object sender, RoutedEventArgs e)
        {
            BasicWinformApp.Form1 form = new BasicWinformApp.Form1();
            var result = form.ShowDialog();

            txtResult.Text = result.ToString();
        }
    }
}
