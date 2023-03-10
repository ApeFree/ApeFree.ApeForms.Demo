using ApeFree.ApeDialogs.Settings;
using ApeFree.ApeForms.Core.Controls;
using ApeFree.ApeForms.Demo.DemoPanel;
using ApeFree.ApeForms.Forms.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeFree.ApeForms.Demo
{
    public partial class DemoForm : Form
    {
        // 导航栏数据
        private NavigationBarData[] nav = new NavigationBarData[]
        {
            new NavigationBarData("Button")
            {
                {"Button",new Lazy<Control>(()=>new ButtonDemoPanel()) },
            },
            new NavigationBarData("DatePicker")
            {
                {"DatePicker",new Lazy<Control>(()=>new DatePickerDemoPanel()) },
            },
            new NavigationBarData("Card")
            {
                {"Magnet",new Lazy<Control>(()=>new MagnetDemoPanel()) },
                {"SimpleCard",new Lazy<Control>(()=>new SimpleCardDemoPanel()) },
            },
            new NavigationBarData("Container")
            {
                {"ControlListBox",new Lazy<Control>(()=>new ControlListBoxDemoPanel()) },
                {"SlideBox",new Lazy<Control>(()=>new SlideBoxDemoPanel()) },
                {"Shutter(preview)",new Lazy<Control>(()=>new ShutterDemoPanel()) },
            },
            new NavigationBarData("Notifications")
            {
                {"Toast",new Lazy<Control>(()=>new ToastDemoPanel()) },
                {"Notification",new Lazy<Control>(()=>new NotificationBoxDemoPanel()) },
            },
            new NavigationBarData("Dialogs")
            {
                {"ApeDialogs",new Lazy<Control>(()=>new DialogDemoPanel()) },
            },

            new NavigationBarData("Extensions")
            {
                {"Form",new Lazy<Control>(()=>new FormExtensionDemoPanel()) },
            },
            new NavigationBarData("GDI+")
            {
                {"GdiPalette",new Lazy<Control>(()=>new GdiPaletteDemoPanel()) },
            },
        };

        public DemoForm()
        {
            InitializeComponent();

            Text = $"{ProductName} - V{ProductVersion}";
        }

        private void DemoForm_Load(object sender, EventArgs e)
        {
            foreach (NavigationBarData data in nav.Reverse())
            {
                SimpleButtonShutter shutter = new SimpleButtonShutter();
                shutter.MainControl.Text = data.Name;
                shutter.MainControl.BackColor = Color.FromArgb(30, 20, 50);
                shutter.MainControl.ForeColor = Color.FromArgb(245, 245, 245);

                foreach (var kv in data.Reverse())
                {
                    var btn = shutter.AddChildButton(kv.Key, (s, args) =>
                    {
                        slideTabControl.AddPage(kv.Key, kv.Value.Value, (data.Icon ?? this.Icon).ToBitmap());
                    });
                    btn.BackColor = Color.FromArgb(70, 55, 100);
                    btn.ForeColor = Color.FromArgb(245, 245, 245);
                }
                controlListBox.AddItem(shutter);
            }

            //ApeFormsDialogProvider provider = new ApeFormsDialogProvider();
            //var dialog = provider.CreateInputDialog(new InputDialogSettings()
            //{
            //    Title = "Test Dialog",
            //    Content = "这是一个测试Dialog",
            //}, this);
            //dialog.Show();

            //Console.WriteLine($"Result[{!dialog.Result.IsCancel}] : {dialog.Result.Data}");
        }

        private void labBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.csdn.net/lgj123xj");
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.csdn.net/lgj123xj/category_11811822.html");
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ApeFree/ApeFree.ApeForms");
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://qm.qq.com/cgi-bin/qm/qr?k=pa-gDVKW6EHScuoeIxLgncshyQJgM3jP&jump_from=webapi&authKey=7yeoSaM8AVK+Svc/FBskmAu6n478PQn1BgNdtTZArMjc9YbSBRfSC+pufaKUKWJM");
            Clipboard.SetDataObject("929371169");
            this.ShowToast("QQ群：929371169 (已复制)", ToastMode.Preemption, 5000);
        }
    }

    /// <summary>
    /// 导航栏数据
    /// </summary>
    public class NavigationBarData : Dictionary<string, Lazy<Control>>
    {
        public string Name { get; set; }
        public Icon Icon { get; set; }

        public NavigationBarData(string name, Icon icon = null)
        {
            Name = name;
            Icon = icon;
        }
    }
}
