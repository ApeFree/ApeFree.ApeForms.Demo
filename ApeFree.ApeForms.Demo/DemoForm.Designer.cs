using ApeFree.ApeForms.Core.Controls;

namespace ApeFree.ApeForms.Demo
{
    partial class DemoForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
            ApeFree.ApeForms.Core.Utils.StateColorSet stateColorSet1 = new ApeFree.ApeForms.Core.Utils.StateColorSet();
            this.panelHead = new System.Windows.Forms.Panel();
            this.controlListBox1 = new ApeFree.ApeForms.Core.Controls.ControlListBox();
            this.btnDocument = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnGithub = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnContact = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labBlog = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.slideTabControl = new ApeFree.ApeForms.Core.Controls.SlideTabControl();
            this.controlListBox = new ApeFree.ApeForms.Core.Controls.ControlListBox();
            this.panelHead.SuspendLayout();
            this.controlListBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panelHead.Controls.Add(this.controlListBox1);
            this.panelHead.Controls.Add(this.picLogo);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(784, 50);
            this.panelHead.TabIndex = 1;
            // 
            // controlListBox1
            // 
            this.controlListBox1.AutoScroll = true;
            this.controlListBox1.BackColor = System.Drawing.Color.Transparent;
            this.controlListBox1.Controls.Add(this.btnDocument);
            this.controlListBox1.Controls.Add(this.btnGithub);
            this.controlListBox1.Controls.Add(this.btnContact);
            this.controlListBox1.Direction = System.Windows.Forms.FlowDirection.RightToLeft;
            this.controlListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlListBox1.Location = new System.Drawing.Point(150, 0);
            this.controlListBox1.Name = "controlListBox1";
            this.controlListBox1.Size = new System.Drawing.Size(634, 50);
            this.controlListBox1.TabIndex = 1;
            // 
            // btnDocument
            // 
            this.btnDocument.AutoSize = true;
            this.btnDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDocument.BorderColor = System.Drawing.Color.Empty;
            this.btnDocument.BorderSize = 0;
            this.btnDocument.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDocument.FlatAppearance.BorderSize = 0;
            this.btnDocument.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.btnDocument.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.btnDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.btnDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocument.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDocument.Location = new System.Drawing.Point(361, 0);
            this.btnDocument.Name = "btnDocument";
            this.btnDocument.Size = new System.Drawing.Size(91, 50);
            this.btnDocument.TabIndex = 2;
            this.btnDocument.Text = "Document";
            this.btnDocument.UseVisualStyleBackColor = false;
            this.btnDocument.Click += new System.EventHandler(this.btnDocument_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.AutoSize = true;
            this.btnGithub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.btnGithub.BorderColor = System.Drawing.Color.Empty;
            this.btnGithub.BorderSize = 0;
            this.btnGithub.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGithub.FlatAppearance.BorderSize = 0;
            this.btnGithub.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(44)))));
            this.btnGithub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.btnGithub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.btnGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGithub.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGithub.Location = new System.Drawing.Point(452, 0);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(91, 50);
            this.btnGithub.TabIndex = 1;
            this.btnGithub.Text = "GitHub";
            this.btnGithub.UseVisualStyleBackColor = false;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // btnContact
            // 
            this.btnContact.AutoSize = true;
            this.btnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.btnContact.BorderColor = System.Drawing.Color.Empty;
            this.btnContact.BorderSize = 0;
            this.btnContact.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.btnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.btnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(42)))));
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnContact.Location = new System.Drawing.Point(543, 0);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(91, 50);
            this.btnContact.TabIndex = 0;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.labBlog);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(150, 511);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(634, 50);
            this.panel2.TabIndex = 2;
            // 
            // labBlog
            // 
            this.labBlog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labBlog.Location = new System.Drawing.Point(5, 9);
            this.labBlog.Name = "labBlog";
            this.labBlog.Size = new System.Drawing.Size(624, 12);
            this.labBlog.TabIndex = 1;
            this.labBlog.TabStop = true;
            this.labBlog.Text = "博客主页";
            this.labBlog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labBlog_LinkClicked);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(624, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "QQ交流群: 929371169";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © 2022-2023 Landriesnidis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slideTabControl
            // 
            this.slideTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slideTabControl.CloseAllPagesOptionText = "Close all";
            this.slideTabControl.ClosePageOptionText = "Close";
            this.slideTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideTabControl.Location = new System.Drawing.Point(150, 50);
            this.slideTabControl.Name = "slideTabControl";
            this.slideTabControl.Rate = 2;
            this.slideTabControl.Size = new System.Drawing.Size(634, 461);
            stateColorSet1.GotFocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            stateColorSet1.GotFocusForeColor = System.Drawing.Color.White;
            stateColorSet1.LostFocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            stateColorSet1.LostFocusForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            stateColorSet1.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(97)))), ((int)(((byte)(152)))));
            stateColorSet1.MouseDownForeColor = System.Drawing.Color.White;
            stateColorSet1.MouseLeaveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            stateColorSet1.MouseLeaveForeColor = System.Drawing.Color.White;
            stateColorSet1.MouseMoveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(239)))));
            stateColorSet1.MouseMoveForeColor = System.Drawing.Color.White;
            this.slideTabControl.StateColorSet = stateColorSet1;
            this.slideTabControl.TabIndex = 0;
            this.slideTabControl.TitleDock = System.Windows.Forms.DockStyle.Top;
            this.slideTabControl.TitleLayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            // 
            // controlListBox
            // 
            this.controlListBox.AutoScroll = true;
            this.controlListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.controlListBox.Direction = System.Windows.Forms.FlowDirection.TopDown;
            this.controlListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlListBox.Location = new System.Drawing.Point(0, 50);
            this.controlListBox.Name = "controlListBox";
            this.controlListBox.Size = new System.Drawing.Size(150, 511);
            this.controlListBox.TabIndex = 3;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.slideTabControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.controlListBox);
            this.Controls.Add(this.panelHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApeForms Demo";
            this.Load += new System.EventHandler(this.DemoForm_Load);
            this.panelHead.ResumeLayout(false);
            this.controlListBox1.ResumeLayout(false);
            this.controlListBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Core.Controls.SlideTabControl slideTabControl;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panel2;
        private ControlListBox controlListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.LinkLabel labBlog;
        private System.Windows.Forms.Label label2;
        private ControlListBox controlListBox1;
        private SimpleButton btnDocument;
        private SimpleButton btnGithub;
        private SimpleButton btnContact;
    }
}

