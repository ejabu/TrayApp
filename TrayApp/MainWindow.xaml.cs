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
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace TrayApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NotifyIcon TrayIcon = new NotifyIcon();

        public MainWindow()
        {
            InitializeComponent();
            var contextMenuStrip = new ContextMenuStrip();

            // Toggle Show Menu Item
            var toggleShowMenuItem = new ToolStripMenuItem
            {
                Text = "Show",
            };

            toggleShowMenuItem.Click += (e, s) =>
            {
                Debug.WriteLine("something");
            };

            // Exit Menu Item
            var exitMenuItem = new ToolStripMenuItem
            {
                Text = "Exit",
            };

            toggleShowMenuItem.Click += (e, s) =>
            {
                Debug.WriteLine("something");
            };


            contextMenuStrip.Items.Add(toggleShowMenuItem);
            contextMenuStrip.Items.Add(new ToolStripSeparator());
            contextMenuStrip.Items.Add(exitMenuItem);
            TrayIcon.Icon = new Icon(@"Resources/Icon.ico");
            TrayIcon.Visible = true;
            TrayIcon.Text = "Tray Application";

            TrayIcon.ContextMenuStrip = contextMenuStrip;
        }
    }
}
