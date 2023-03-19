using ApeFree.ApeForms.Demo.Properties;
using ApeFree.ApeForms.Forms.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ApeFree.ApeForms.Demo.DemoPanel
{
    public partial class NotificationBoxDemoPanel : UserControl
    {
        public NotificationBoxDemoPanel()
        {
            InitializeComponent();

            if (Notification.Orientation == NotifyOrientation.Queue)
            {
                rbtnOrientationQueue.Checked = true;
            }

            if (Notification.PrimeDirection == NotifyPrimeDirection.Top)
            {
                rbtnPrimeDirectionTop.Checked = true;
            }

            nudDefaultWidth.Value = Notification.DefaultFormsSize.Width;
            nudDefaultHeight.Value = Notification.DefaultFormsSize.Height;
            nudSpacingDistance.Value = Notification.SpacingDistance;
        }

        private void rbtnOrientation_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOrientationQueue.Checked)
            {
                Notification.Orientation = NotifyOrientation.Queue;

            }
            else if (rbtnOrientationStack.Checked)
            {
                Notification.Orientation = NotifyOrientation.Stack;
            }
        }

        private void rbtnPrimeDirection_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPrimeDirectionTop.Checked)
            {
                Notification.PrimeDirection = NotifyPrimeDirection.Top;

            }
            else if (rbtnPrimeDirectionBottom.Checked)
            {
                Notification.PrimeDirection = NotifyPrimeDirection.Bottom;
            }
        }

        private void btnChangeDefaultSzie_Click(object sender, EventArgs e)
        {
            Notification.DefaultFormsSize = new Size((int)nudDefaultWidth.Value, (int)nudDefaultHeight.Value);
            Notification.SpacingDistance = (int)nudSpacingDistance.Value;
        }

        private void btnPublishText_Click(object sender, EventArgs e)
        {
            var notify = Notification.Builder.ShowTextNotification(s =>
            {
                s.Title = tbNotificationTitle.Text;
                s.Message = "Notification(Text)";
                s.RetentionTime = (uint)nudDisappearDelay.Value;
                s.ReminderColor = btnReminderColor.BackColor;
            });
        }

        private void btnPublishImageText_Click(object sender, EventArgs e)
        {
            var notify = Notification.Builder.ShowImageTextNotification(s =>
            {
                s.Title = tbNotificationTitle.Text;
                s.Message = "Notification(Image + Text)";
                s.Image = Resources.Magnet_12;
                s.RetentionTime = (uint)nudDisappearDelay.Value;
                s.ReminderColor = btnReminderColor.BackColor;
                s.Options.Add(new NotificationOption("关闭通知栏", (obj, args) =>
                {
                    Toast.Show("此按钮会关闭通知栏");
                }));
                s.Options.Add(new NotificationOption("不关闭通知栏", (obj, args) =>
                {
                    args.IsDisappear = false;
                    Toast.Show("修改事件参数的IsDisappear属性，通知栏将不会被关闭");
                }));
            });
        }

        private void btnPublishOptionDemo_Click(object sender, EventArgs e)
        {
            this.FindForm().WindowState = FormWindowState.Minimized;

            var notify = Notification.Builder.ShowImageTextNotification(s =>
            {
                s.Title = "ApeForms";
                s.Message = "Demo窗体已被最小化到开始栏，可通过下方按键还原窗体。";
                s.Image = Resources.ImageButton_1;
                s.RetentionTime = 0;
                s.ReminderColor = btnReminderColor.BackColor;
                s.Options.Add(new NotificationOption("窗口最大化", (obj, args) =>
                {
                    this.FindForm().WindowState = FormWindowState.Normal;
                }));
            });
        }

        private void btnReminderColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false;
            colorDialog.ShowHelp = true;
            colorDialog.Color = btnReminderColor.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
                btnReminderColor.BackColor = colorDialog.Color;
        }
    }
}
