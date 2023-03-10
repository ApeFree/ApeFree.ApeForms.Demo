using ApeFree.ApeDialogs;
using ApeFree.ApeDialogs.Settings;
using ApeFree.ApeForms.Forms.Dialogs;
using ApeFree.ApeForms.Forms.Notifications;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ApeFree.ApeForms.Demo.DemoPanel
{
    public partial class DialogDemoPanel : UserControl
    {
        ApeFormsDialogProvider provider = DialogFactory.Factory.GetApeFormsDialogProvider();

        public DialogDemoPanel()
        {
            InitializeComponent();

            btnNeutralOptionColor.BackColor = provider.OptionTagColors[DialogOptionTag.Neutral];
            btnPositiveOptionColor.BackColor = provider.OptionTagColors[DialogOptionTag.Positive];
            btnNegativeOptionColor.BackColor = provider.OptionTagColors[DialogOptionTag.Negative];
            btnFunctionalOptionColor.BackColor = provider.OptionTagColors[DialogOptionTag.Functional];
            btnSpecialOptionColor.BackColor = provider.OptionTagColors[DialogOptionTag.Special];
        }

        private void btnMessageDialog_Click(object sender, EventArgs e)
        {
            // 写法一：
            //var settings = new MessageDialogSettings()
            //{
            //    // 标题文本
            //    Title = tbTitle.Text,
            //    // 消息文本
            //    Content = tbContent.Text,
            //};
            //settings.ConfirmOption.Text = "知道了";

            //var dialog = provider.CreateMessageDialog(settings);
            //dialog.Show();

            // 写法二（推荐）：
            var dialog = provider.CreateMessageDialog(s =>
            {
                // 是否可取消
                s.Cancelable = true;
                // 修改确认键文本
                s.ConfirmOption.Text = "知道了";
                // 修改Dialog窗体尺寸
                s.DialogSize = new Size(400, 250);
                // 修改标题名
                s.Title = tbTitle.Text;
                // 修改文本内容
                s.Content = tbContent.Text;
            });
            dialog.Show();
        }

        private void btnInputDialog_Click(object sender, EventArgs e)
        {
            // 写法一：
            //var settings = new InputDialogSettings()
            //{
            //    // 标题文本
            //    Title = tbTitle.Text,
            //    // 消息文本
            //    Content = tbContent.Text,
            //    // 输入框默认文本
            //    DefaultText = "You can set the default text in the input box by using the 'DefaultText' property.",
            //    // 是否可取消
            //    Cancelable = false,
            //    // 是否允许输入为空
            //    AllowEmpty = false,
            //    // 输入文本最大长度
            //    MaximumLength = 50,
            //    // 输入文本最小长度
            //    MinimumLength = 6,
            //    // 是否多行
            //    IsMultiline = false,
            //};
            //// 确认按钮文本
            //settings.ConfirmOption.Text = "Confirm(确定)";
            //// 取消按钮文本
            //settings.CancelOption.Text = "Cancel(取消)";
            //// 清空按钮文本
            //settings.ClearOption.Text = "Clear(清空)";
            //var dialog = provider.CreateInputDialog(settings, null);

            // 写法二（推荐）：
            var dialog = provider.CreateInputDialog(s =>
            {
                // 标题文本
                s.Title = tbTitle.Text;
                // 消息文本
                s.Content = tbContent.Text;
                // 输入框默认文本
                s.DefaultText = "You can set the default text in the input box by using the 'DefaultText' property.";
                // 是否可取消
                s.Cancelable = true;
                // 是否允许输入为空
                s.AllowEmpty = false;
                // 输入文本最大长度
                s.MaximumLength = 200;
                // 输入文本最小长度
                s.MinimumLength = 6;
                // 是否多行
                s.IsMultiline = false;
                // 确认按钮文本
                s.ConfirmOption.Text = "Confirm(确定)";
                // 取消按钮文本
                s.CancelOption.Text = "Cancel(取消)";
                // 清空按钮文本
                s.ClearOption.Text = "Clear(清空)";
            });

            dialog.Show();

            if (dialog.Result.IsCancel)
            {
                Toast.Show("取消输入");
            }
            else
            {
                Toast.Show($"输入内容为：{dialog.Result.Data}");
            }
        }

        private void btnInputMultiLineDialog_Click(object sender, EventArgs e)
        {
            // 写法一：
            //var dialog = provider.CreateInputDialog(new InputDialogSettings()
            //{
            //    Title = tbTitle.Text,
            //    Content = tbContent.Text,
            //    DefaultText = "You can set the default text in the input box by using the 'DefaultText' property.",
            //    IsMultiline = true
            //}, null);

            // 写法二（推荐）：
            var dialog = provider.CreateInputDialog(s =>
            {
                // 标题文本
                s.Title = tbTitle.Text;
                // 消息文本
                s.Content = tbContent.Text;
                // 输入框默认文本
                s.DefaultText = "You can set the default text in the input box by using the 'DefaultText' property.";
                // 是否可取消
                s.Cancelable = true;
                // 是否允许输入为空
                s.AllowEmpty = false;
                // 输入文本最大长度
                s.MaximumLength = 200;
                // 输入文本最小长度
                s.MinimumLength = 6;
                // 是否多行
                s.IsMultiline = true;
                // 确认按钮文本
                s.ConfirmOption.Text = "Confirm(确定)";
                // 取消按钮文本
                s.CancelOption.Text = "Cancel(取消)";
                // 清空按钮文本
                s.ClearOption.Text = "Clear(清空)";
            });

            dialog.Show();

            if (dialog.Result.IsCancel)
            {
                Toast.Show("取消输入");
            }
            else
            {
                Toast.Show($"输入内容为：{dialog.Result.Data}");
            }
        }

        private void btnPasswordDialog_Click(object sender, EventArgs e)
        {
            // 写法一：
            //var dialog = provider.CreatePasswordDialog(new PasswordDialogSettings()
            //{
            //    Title = tbTitle.Text,
            //    Content = tbContent.Text + $"\r\n提示：密码至少要[6]位",
            //    PasswordChar = '●',
            //    PrecheckResult = password => password != null && password.Length >= 6,
            //}, null);

            // 写法二（推荐）：
            var dialog = provider.CreatePasswordDialog(s =>
            {
                s.Title = tbTitle.Text;
                s.Content = tbContent.Text + $"\r\n提示：密码至少要[6]位";
                s.PasswordChar = '●';
                s.PrecheckResult = password => password != null && password.Length >= 6;
            });

            dialog.Show();
            if (dialog.Result.IsCancel)
            {
                Toast.Show("取消输入");
            }
            else
            {
                Toast.Show($"输入密码为：{dialog.Result.Data}");
            }
        }

        private void btnPromptDialog_Click(object sender, EventArgs e)
        {
            // 写法一：
            //var dialog = provider.CreatePromptDialog(new PromptDialogSettings() { Title = tbTitle.Text, Content = tbContent.Text }, null);

            // 写法二（推荐）：
            var dialog = provider.CreatePromptDialog(s =>
            {
                // 标题文本
                s.Title = tbTitle.Text;
                // 消息文本
                s.Content = tbContent.Text;
            }, null);

            dialog.Show();
            if (dialog.Result.Data)
            {
                Toast.Show("结果：积极选项");
            }
            else
            {
                Toast.Show("结果：消极选项");
            }
        }

        private void btnSelectionDialog_Click(object sender, EventArgs e)
        {
            Student[] students = new Student[] {
                new Student("张三","一年级"),
                new Student("李四","三年级"),
                new Student("王二","五年级"),
                new Student("马六","五年级"),
            };

            // 写法一：
            //var dialog = provider.CreateSelectionDialog(new SelectionDialogSettings<Student>()
            //{
            //    Title = tbTitle.Text,
            //    Content = tbContent.Text,
            //    PrecheckResult = item =>
            //    {
            //        var b = item != null;
            //        if (!b)
            //        {
            //            Toast.Show("至少要选一项哦！", 2000, null, ToastMode.Reuse);
            //        }
            //        return b;
            //    },
            //    ItemDisplayTextConvertCallback = stu => $"{stu.Name} ({stu.Description})",
            //}, students, null, null);

            // 写法二（推荐）：
            var dialog = provider.CreateSelectionDialog(students, null, s =>
            {
                // 标题文本
                s.Title = tbTitle.Text;
                // 消息文本
                s.Content = tbContent.Text;
                // 设置预检查回调
                s.PrecheckResult = item =>
                    {
                        var b = item != null;
                        if (!b)
                        {
                            Toast.Show("至少要选一项哦！", 2000, null, ToastMode.Reuse);
                        }
                        return b;
                    };
                s.ItemDisplayTextConvertCallback = stu => $"{stu.Name} ({stu.Description})";
            });

            dialog.Show();
            if (dialog.Result.IsCancel)
            {
                Toast.Show("取消选择");
            }
            else
            {
                Toast.Show($"结果：{dialog.Result.Data.Name} , {dialog.Result.Data.Description}");
            }
        }



        private void btnMultipleSelectionDialog_Click(object sender, EventArgs e)
        {
            Student[] students = new Student[] {
                new Student("张三","一年级"),
                new Student("李四","三年级"),
                new Student("王二","五年级"),
                new Student("马六","五年级"),
            };

            // 写法一：
            //var dialog = provider.CreateMultipleSelectionDialog(new MultipleSelectionDialogSettings<Student>()
            //{
            //    Title = tbTitle.Text,
            //    Content = tbContent.Text,
            //    PrecheckResult = item =>
            //    {
            //        var b = item.Any();
            //        if (!b)
            //        {
            //            Toast.Show("至少要选一项哦！", 2000, null, ToastMode.Reuse);
            //        }
            //        return b;
            //    },
            //    ItemDisplayTextConvertCallback = stu => $"{stu.Name} ({stu.Description})",
            //}, students, null, null);

            // 写法二（推荐）：
            var dialog = provider.CreateMultipleSelectionDialog(students, null, s =>
            {
                // 标题文本
                s.Title = tbTitle.Text;
                // 消息文本
                s.Content = tbContent.Text;
                // 设置预检查回调
                s.PrecheckResult = item =>
                {
                    var b = item.Any();
                    if (!b)
                    {
                        Toast.Show("至少要选一项哦！", 2000, null, ToastMode.Reuse);
                    }
                    return b;
                };
                s.ItemDisplayTextConvertCallback = stu => $"{stu.Name} ({stu.Description})";
            });


            dialog.Show();
            if (dialog.Result.IsCancel)
            {
                Toast.Show("取消选择");
            }
            else
            {
                Toast.Show($"结果：{string.Join("|", dialog.Result.Data.Select(s => $"{s.Name}({s.Description})"))}");
            }
        }

        private void btnOptionColor_Click(object sender, EventArgs e)
        {
            var btn = sender as Control;
            var tagName = btn.Text;
            var ot = tagName.ToEnum<DialogOptionTag>();

            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = btn.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                btn.BackColor = MyDialog.Color;
                provider.OptionTagColors[ot] = btn.BackColor;
            }
        }

        class Student
        {
            public Student(string name, string description)
            {
                Name = name;
                Description = description;
            }
            public string Name { get; set; }
            public string Description { get; set; }
        }

    }
}
