﻿using ApeFree.ApeForms.Demo.Properties;
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
                s.Message = "这是一个纯文本类型的消息通知栏，你可以在此处设置任何文本";
                s.RetentionTime = (uint)nudDisappearDelay.Value;
                s.ReminderColor = btnReminderColor.BackColor;
            });
        }

        private void btnPublishTextWithOptions_Click(object sender, EventArgs e)
        {
            var notify = Notification.Builder.ShowTextNotification(s =>
            {
                s.Title = tbNotificationTitle.Text;
                s.Message = "这是一个纯文本类型的消息通知栏，你可以在此处设置任何文本。通知栏允许添加自定义选项（可配置选项的单击事件）。";
                s.RetentionTime = (uint)nudDisappearDelay.Value;
                s.ReminderColor = btnReminderColor.BackColor;

                s.Options.Add(new NotificationOption("选项1", (obj, args) =>
                {
                    Toast.Show("你选择了选项1");
                }));
                s.Options.Add(new NotificationOption("选项2", (obj, args) =>
                {
                    Toast.Show("你选择了选项2");
                }));
            });
        }

        private void btnPublishImageText_Click(object sender, EventArgs e)
        {
            var notify = Notification.Builder.ShowImageTextNotification(s =>
            {
                s.Title = tbNotificationTitle.Text;
                s.Message = "这是一个图片+文本类型的消息通知栏，你可以自定义显示图片和显示文本。";
                s.Image = Resources.Magnet_12;
                s.ImageSizeMode = PictureBoxSizeMode.StretchImage;
                s.RetentionTime = (uint)nudDisappearDelay.Value;
                s.ReminderColor = btnReminderColor.BackColor;
            });
        }

        private void btnPublishImageTextWithOptions_Click(object sender, EventArgs e)
        {
            var notify = Notification.Builder.ShowImageTextNotification(s =>
            {
                s.Title = tbNotificationTitle.Text;
                s.Message = "这是一个图片+文本类型的消息通知栏，你可以自定义显示图片和显示文本。通知栏允许添加自定义选项（可配置选项的单击事件）。";
                s.Image = Resources.Magnet_12;
                s.RetentionTime = (uint)nudDisappearDelay.Value;
                s.ReminderColor = btnReminderColor.BackColor;
                s.Options.Add(new NotificationOption("单击后关闭", (obj, args) =>
                {
                    Toast.Show("默认状态下，单击任意选项后都会关闭通知栏");
                }));
                s.Options.Add(new NotificationOption("单击后不关闭", (obj, args) =>
                {
                    args.IsDisappear = false;
                    Toast.Show("修改事件参数的IsDisappear属性，通知栏将不会被关闭。");
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
                s.RetentionTime = 10000;
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
