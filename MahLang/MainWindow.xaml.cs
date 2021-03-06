using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace MahLang
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool useZhCN = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cultureStr = "zh-CN";
            if (!useZhCN)
                cultureStr = "en-US";

            this.useZhCN = !this.useZhCN;
            this.langTxt.Text = cultureStr;
            Application.Current.Dispatcher.Thread.CurrentUICulture = new CultureInfo(cultureStr);
        }
    }
}
