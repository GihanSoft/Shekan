using GihanSoft.WMI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
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

namespace Shekan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string ShekanDNS1 = "185.51.200.2";
        private const string ShekanDNS2 = "178.22.122.100";

        private Win32_NetworkAdapterSetting adapter;
        private string[] currentDominNameServerPair;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Tray.ToolTipText = "در حال بررسی اتصال";
            adapter = await Task.Run(() =>
            {
                Win32_NetworkAdapterSetting adapter;
                do
                {
                    adapter = Win32_NetworkAdapterSetting.GetAll()
                        .FirstOrDefault(a => a.Setting.IPEnabled);
                    Thread.Sleep(100);
                    Dispatcher.Invoke(() =>Tray.ToolTipText = "اتصال برقرار نیست");
                } while (adapter is null);
                return adapter;
            });
            Tray.ToolTipText = "در حال تنظیم DNS شکن";
            var netInterface = NetworkInterface.GetAllNetworkInterfaces()
                .FirstOrDefault(i => i.Name == adapter.Element.NetConnectionID);
            currentDominNameServerPair =
                netInterface.GetIPProperties().IsDynamicDnsEnabled ?
                null : adapter.Setting.DNSServerSearchOrder;

            adapter.Setting.SetDNSServerSearchOrder(new[] { ShekanDNS1, ShekanDNS2 });

            Tray.ToolTipText = "با «شکن» تحریم‌های اینترنتی بی‌اثر  شد";
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            adapter.Setting.SetDNSServerSearchOrder(currentDominNameServerPair);
        }

        private void TrayMenuExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TrayMenuAbout_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/GihanSoft/Shekan");
        }
    }
}
