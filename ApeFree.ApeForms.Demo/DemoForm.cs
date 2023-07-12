using ApeFree.ApeForms.Core.Controls;
using ApeFree.ApeForms.Demo.DemoPanel;
using ApeFree.ApeForms.Demo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeFree.ApeForms.Demo
{
    public partial class DemoForm : TemplateForm
    {
        public DemoForm()
        {
            InitializeComponent();

            LogoImage = Resources.ApeForms_Logo;

            SideNavData = new List<NavBarGroup>
            {
                new NavBarGroup("Button")
                {
                    new NavItem ("Button",typeof(ButtonDemoPanel) ),
                },
                new NavBarGroup("DatePicker")
                {
                    new NavItem("DatePicker", typeof(DatePickerDemoPanel)),
                },
                new NavBarGroup("Card")
                {
                    new NavItem("Magnet", typeof(MagnetDemoPanel)),
                    new NavItem("SimpleCard", typeof(SimpleCardDemoPanel)),
                },
                new NavBarGroup("Container")
                {
                    new NavItem("ControlListBox", typeof(ControlListBoxDemoPanel)),
                    new NavItem("SlideBox", typeof(SlideBoxDemoPanel)),
                    new NavItem("Shutter(preview)", typeof(ShutterDemoPanel)),
                },
                new NavBarGroup("Notifications")
                {
                        new NavItem("Toast", typeof(ToastDemoPanel)),
                    new NavItem("Notification", typeof(NotificationBoxDemoPanel)),
                },
                new NavBarGroup("Dialogs")
                {
                    new NavItem("ApeDialogs", typeof(DialogDemoPanel)),
                },

                new NavBarGroup("Extensions")
                {
                    new NavItem("Form", typeof(FormExtensionDemoPanel)),
                    new NavItem("GradualChange", typeof(GradualChangeExtensionDemoPanel)),
                },
                new NavBarGroup("GdiPalette")
                {
                    new NavItem("Clock", typeof(GdiPaletteClockDemoPanel)),
                    new NavItem("RadarChart", typeof(GdiPaletteRadarChartDemoPanel)),
                },
            };
        }

        protected override void LoadBottomBar(ControlListBox bottomBar)
        {
            base.LoadBottomBar(bottomBar);

            var linklab = new LinkLabel() { Text = "博客主页", AutoSize = false, Size = new Size(0, 15), TextAlign = ContentAlignment.MiddleCenter };
            var labContactUs = new Label() { Text = "QQ交流群: 929371169", AutoSize = false, Size = new Size(0, 15), TextAlign = ContentAlignment.MiddleCenter };
            var labCopyright = new Label() { Text = "Copyright © 2022-2023 Landriesnidis", AutoSize = false, Size = new Size(0, 15), TextAlign = ContentAlignment.MiddleCenter };

            linklab.Click += (s, e) => Process.Start("https://blog.csdn.net/lgj123xj/category_11811822.html");

            bottomBar.AddItem(linklab);
            bottomBar.AddItem(labContactUs);
            bottomBar.AddItem(labCopyright);
        }
    }
}
