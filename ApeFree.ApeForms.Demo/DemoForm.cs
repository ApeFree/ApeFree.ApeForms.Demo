using ApeFree.ApeForms.Core.Controls;
using ApeFree.ApeForms.Demo.DemoPanel;
using ApeFree.ApeForms.Demo.Properties;
using ApeFree.ApeForms.TemplateNest;
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

            // 程序标题
            Text = $"{ProductName} - V{ProductVersion}";

            // 修改Logo
            LogoImage = Resources.ApeForms_Logo;

            // 修改关闭选项名称
            CloseAllPagesOptionText = "全部关闭";
            ClosePageOptionText = "关闭";

            SideBarData = new List<NavBarGroup>
            {
                new NavBarGroup("Button",Resources.Icon_00)
                {
                    new NavItem ("Button",typeof(ButtonDemoPanel)){ Icon = Resources.Icon_01, ShowCloseButton = false },
                },
                new NavBarGroup("DatePicker",Resources.Icon_02)
                {
                    new NavItem("DatePicker", typeof(DatePickerDemoPanel)){ Icon = Resources.Icon_05},
                },
                new NavBarGroup("Card",Resources.Icon_03)
                {
                    new NavItem("Magnet", typeof(MagnetDemoPanel)){ Icon = Resources.Icon_06},
                    new NavItem("SimpleCard", typeof(SimpleCardDemoPanel)){ Icon = Resources.Icon_06},
                },
                new NavBarGroup("Grid",Resources.Icon_09)
                {
                    new NavItem("GridView", typeof(GridViewDemoPanel)){ Icon = Resources.Icon_09},
                },
                new NavBarGroup("Container",Resources.Icon_04)
                {
                    new NavItem("ControlListBox", typeof(ControlListBoxDemoPanel)){ Icon = Resources.Icon_07},
                    new NavItem("SlideBox", typeof(SlideBoxDemoPanel)){ Icon = Resources.Icon_07},
                    new NavItem("Shutter(preview)", typeof(ShutterDemoPanel)){ Icon = Resources.Icon_07},
                    new NavItem("StageLayout", typeof(StageLayoutDemoPanel)){ Icon = Resources.Icon_07},
                },
                new NavBarGroup("Notifications",Resources.Icon_08)
                {
                    new NavItem("Toast", typeof(ToastDemoPanel)),
                    new NavItem("Notification", typeof(NotificationBoxDemoPanel)),
                },
                new NavBarGroup("Dialogs",Resources.Icon_09)
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

            TopBarData = new List<TopBarItem> {
                new TopBarItem("获取源码",(s,e)=>Process.Start("https://github.com/ApeFree/ApeFree.ApeForms.Demo")),
                new TopBarItem("更多文档",(s,e)=>Process.Start("https://blog.csdn.net/lgj123xj/category_11811822.html")),
                new TopBarItem("加入组织",(s,e)=>{
                    Process.Start("https://qm.qq.com/cgi-bin/qm/qr?k=pa-gDVKW6EHScuoeIxLgncshyQJgM3jP&jump_from=webapi&authKey=7yeoSaM8AVK+Svc/FBskmAu6n478PQn1BgNdtTZArMjc9YbSBRfSC+pufaKUKWJM");
                    Clipboard.SetDataObject("929371169");
                    this.ShowToast("QQ群：929371169 (已复制)", ToastMode.Preemption, 5000);
                }),
            };
        }

        protected override void LoadBottomBar(ControlListBox bottomBar)
        {
            base.LoadBottomBar(bottomBar);

            var linklab = new LinkLabel() { Text = "博客主页", AutoSize = false, Size = new Size(0, 15), TextAlign = ContentAlignment.MiddleCenter };
            var labContactUs = new Label() { Text = "QQ交流群: 929371169", AutoSize = false, Size = new Size(0, 15), TextAlign = ContentAlignment.MiddleCenter };
            var labCopyright = new Label() { Text = "Copyright © 2022-2024 ApeFree", AutoSize = false, Size = new Size(0, 15), TextAlign = ContentAlignment.MiddleCenter };

            linklab.Click += (s, e) => Process.Start("https://blog.csdn.net/lgj123xj/category_11811822.html");

            bottomBar.AddItem(linklab);
            bottomBar.AddItem(labContactUs);
            bottomBar.AddItem(labCopyright);
        }
    }
}
