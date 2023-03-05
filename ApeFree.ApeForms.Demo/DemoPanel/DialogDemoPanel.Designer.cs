namespace ApeFree.ApeForms.Demo.DemoPanel
{
    partial class DialogDemoPanel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNeutralOptionColor = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnPositiveOptionColor = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnNegativeOptionColor = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnFunctionalOptionColor = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnSpecialOptionColor = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMessageDialog = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnInputDialog = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnInputMultiLineDialog = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnPasswordDialog = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnPromptDialog = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnSelectionDialog = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.btnMultipleSelectionDialog = new ApeFree.ApeForms.Core.Controls.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbContent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(863, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Settings";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnNeutralOptionColor);
            this.flowLayoutPanel2.Controls.Add(this.btnPositiveOptionColor);
            this.flowLayoutPanel2.Controls.Add(this.btnNegativeOptionColor);
            this.flowLayoutPanel2.Controls.Add(this.btnFunctionalOptionColor);
            this.flowLayoutPanel2.Controls.Add(this.btnSpecialOptionColor);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 117);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(855, 44);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // btnNeutralOptionColor
            // 
            this.btnNeutralOptionColor.AutoSize = true;
            this.btnNeutralOptionColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNeutralOptionColor.BorderColor = System.Drawing.Color.Empty;
            this.btnNeutralOptionColor.BorderSize = 1;
            this.btnNeutralOptionColor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btnNeutralOptionColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btnNeutralOptionColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btnNeutralOptionColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeutralOptionColor.ForeColor = System.Drawing.Color.White;
            this.btnNeutralOptionColor.Location = new System.Drawing.Point(4, 4);
            this.btnNeutralOptionColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnNeutralOptionColor.Name = "btnNeutralOptionColor";
            this.btnNeutralOptionColor.Size = new System.Drawing.Size(111, 36);
            this.btnNeutralOptionColor.TabIndex = 1;
            this.btnNeutralOptionColor.Text = "Neutral";
            this.btnNeutralOptionColor.UseVisualStyleBackColor = false;
            this.btnNeutralOptionColor.Click += new System.EventHandler(this.btnOptionColor_Click);
            // 
            // btnPositiveOptionColor
            // 
            this.btnPositiveOptionColor.AutoSize = true;
            this.btnPositiveOptionColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPositiveOptionColor.BorderColor = System.Drawing.Color.Empty;
            this.btnPositiveOptionColor.BorderSize = 1;
            this.btnPositiveOptionColor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btnPositiveOptionColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btnPositiveOptionColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btnPositiveOptionColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositiveOptionColor.ForeColor = System.Drawing.Color.White;
            this.btnPositiveOptionColor.Location = new System.Drawing.Point(123, 4);
            this.btnPositiveOptionColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPositiveOptionColor.Name = "btnPositiveOptionColor";
            this.btnPositiveOptionColor.Size = new System.Drawing.Size(111, 36);
            this.btnPositiveOptionColor.TabIndex = 2;
            this.btnPositiveOptionColor.Text = "Positive";
            this.btnPositiveOptionColor.UseVisualStyleBackColor = false;
            this.btnPositiveOptionColor.Click += new System.EventHandler(this.btnOptionColor_Click);
            // 
            // btnNegativeOptionColor
            // 
            this.btnNegativeOptionColor.AutoSize = true;
            this.btnNegativeOptionColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNegativeOptionColor.BorderColor = System.Drawing.Color.Empty;
            this.btnNegativeOptionColor.BorderSize = 1;
            this.btnNegativeOptionColor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btnNegativeOptionColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btnNegativeOptionColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btnNegativeOptionColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegativeOptionColor.ForeColor = System.Drawing.Color.White;
            this.btnNegativeOptionColor.Location = new System.Drawing.Point(242, 4);
            this.btnNegativeOptionColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnNegativeOptionColor.Name = "btnNegativeOptionColor";
            this.btnNegativeOptionColor.Size = new System.Drawing.Size(111, 36);
            this.btnNegativeOptionColor.TabIndex = 3;
            this.btnNegativeOptionColor.Text = "Negative";
            this.btnNegativeOptionColor.UseVisualStyleBackColor = false;
            this.btnNegativeOptionColor.Click += new System.EventHandler(this.btnOptionColor_Click);
            // 
            // btnFunctionalOptionColor
            // 
            this.btnFunctionalOptionColor.AutoSize = true;
            this.btnFunctionalOptionColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFunctionalOptionColor.BorderColor = System.Drawing.Color.Empty;
            this.btnFunctionalOptionColor.BorderSize = 1;
            this.btnFunctionalOptionColor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btnFunctionalOptionColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btnFunctionalOptionColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btnFunctionalOptionColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunctionalOptionColor.ForeColor = System.Drawing.Color.White;
            this.btnFunctionalOptionColor.Location = new System.Drawing.Point(361, 4);
            this.btnFunctionalOptionColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnFunctionalOptionColor.Name = "btnFunctionalOptionColor";
            this.btnFunctionalOptionColor.Size = new System.Drawing.Size(111, 36);
            this.btnFunctionalOptionColor.TabIndex = 4;
            this.btnFunctionalOptionColor.Text = "Functional";
            this.btnFunctionalOptionColor.UseVisualStyleBackColor = false;
            this.btnFunctionalOptionColor.Click += new System.EventHandler(this.btnOptionColor_Click);
            // 
            // btnSpecialOptionColor
            // 
            this.btnSpecialOptionColor.AutoSize = true;
            this.btnSpecialOptionColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSpecialOptionColor.BorderColor = System.Drawing.Color.Empty;
            this.btnSpecialOptionColor.BorderSize = 1;
            this.btnSpecialOptionColor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btnSpecialOptionColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btnSpecialOptionColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btnSpecialOptionColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecialOptionColor.ForeColor = System.Drawing.Color.White;
            this.btnSpecialOptionColor.Location = new System.Drawing.Point(480, 4);
            this.btnSpecialOptionColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpecialOptionColor.Name = "btnSpecialOptionColor";
            this.btnSpecialOptionColor.Size = new System.Drawing.Size(111, 36);
            this.btnSpecialOptionColor.TabIndex = 5;
            this.btnSpecialOptionColor.Text = "Special";
            this.btnSpecialOptionColor.UseVisualStyleBackColor = false;
            this.btnSpecialOptionColor.Click += new System.EventHandler(this.btnOptionColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(4, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Option Tag Color";
            // 
            // tbContent
            // 
            this.tbContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbContent.Location = new System.Drawing.Point(4, 77);
            this.tbContent.Margin = new System.Windows.Forms.Padding(4);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(855, 23);
            this.tbContent.TabIndex = 3;
            this.tbContent.Text = "This is a Demo to demonstrate the Dialog functionality.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(4, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Content";
            // 
            // tbTitle
            // 
            this.tbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTitle.Location = new System.Drawing.Point(4, 37);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(855, 23);
            this.tbTitle.TabIndex = 1;
            this.tbTitle.Text = "Dialog Demo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 183);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(863, 561);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dialogs";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMessageDialog);
            this.flowLayoutPanel1.Controls.Add(this.btnInputDialog);
            this.flowLayoutPanel1.Controls.Add(this.btnInputMultiLineDialog);
            this.flowLayoutPanel1.Controls.Add(this.btnPasswordDialog);
            this.flowLayoutPanel1.Controls.Add(this.btnPromptDialog);
            this.flowLayoutPanel1.Controls.Add(this.btnSelectionDialog);
            this.flowLayoutPanel1.Controls.Add(this.btnMultipleSelectionDialog);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 20);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(855, 537);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnMessageDialog
            // 
            this.btnMessageDialog.AutoSize = true;
            this.btnMessageDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMessageDialog.BorderColor = System.Drawing.Color.Empty;
            this.btnMessageDialog.BorderSize = 1;
            this.btnMessageDialog.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btnMessageDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btnMessageDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btnMessageDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessageDialog.ForeColor = System.Drawing.Color.White;
            this.btnMessageDialog.Location = new System.Drawing.Point(4, 4);
            this.btnMessageDialog.Margin = new System.Windows.Forms.Padding(4);
            this.btnMessageDialog.Name = "btnMessageDialog";
            this.btnMessageDialog.Size = new System.Drawing.Size(178, 52);
            this.btnMessageDialog.TabIndex = 0;
            this.btnMessageDialog.Text = "MessageDialog";
            this.btnMessageDialog.UseVisualStyleBackColor = false;
            this.btnMessageDialog.Click += new System.EventHandler(this.btnMessageDialog_Click);
            // 
            // btnInputDialog
            // 
            this.btnInputDialog.AutoSize = true;
            this.btnInputDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInputDialog.BorderColor = System.Drawing.Color.Empty;
            this.btnInputDialog.BorderSize = 1;
            this.btnInputDialog.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btnInputDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btnInputDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btnInputDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputDialog.ForeColor = System.Drawing.Color.White;
            this.btnInputDialog.Location = new System.Drawing.Point(190, 4);
            this.btnInputDialog.Margin = new System.Windows.Forms.Padding(4);
            this.btnInputDialog.Name = "btnInputDialog";
            this.btnInputDialog.Size = new System.Drawing.Size(178, 52);
            this.btnInputDialog.TabIndex = 1;
            this.btnInputDialog.Text = "InputDialog";
            this.btnInputDialog.UseVisualStyleBackColor = false;
            this.btnInputDialog.Click += new System.EventHandler(this.btnInputDialog_Click);
            // 
            // btnInputMultiLineDialog
            // 
            this.btnInputMultiLineDialog.AutoSize = true;
            this.btnInputMultiLineDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInputMultiLineDialog.BorderColor = System.Drawing.Color.Empty;
            this.btnInputMultiLineDialog.BorderSize = 1;
            this.btnInputMultiLineDialog.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btnInputMultiLineDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btnInputMultiLineDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btnInputMultiLineDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputMultiLineDialog.ForeColor = System.Drawing.Color.White;
            this.btnInputMultiLineDialog.Location = new System.Drawing.Point(376, 4);
            this.btnInputMultiLineDialog.Margin = new System.Windows.Forms.Padding(4);
            this.btnInputMultiLineDialog.Name = "btnInputMultiLineDialog";
            this.btnInputMultiLineDialog.Size = new System.Drawing.Size(178, 52);
            this.btnInputMultiLineDialog.TabIndex = 2;
            this.btnInputMultiLineDialog.Text = "InputDialog(MultiLine)";
            this.btnInputMultiLineDialog.UseVisualStyleBackColor = false;
            this.btnInputMultiLineDialog.Click += new System.EventHandler(this.btnInputMultiLineDialog_Click);
            // 
            // btnPasswordDialog
            // 
            this.btnPasswordDialog.AutoSize = true;
            this.btnPasswordDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPasswordDialog.BorderColor = System.Drawing.Color.Empty;
            this.btnPasswordDialog.BorderSize = 1;
            this.btnPasswordDialog.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btnPasswordDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btnPasswordDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btnPasswordDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordDialog.ForeColor = System.Drawing.Color.White;
            this.btnPasswordDialog.Location = new System.Drawing.Point(562, 4);
            this.btnPasswordDialog.Margin = new System.Windows.Forms.Padding(4);
            this.btnPasswordDialog.Name = "btnPasswordDialog";
            this.btnPasswordDialog.Size = new System.Drawing.Size(178, 52);
            this.btnPasswordDialog.TabIndex = 3;
            this.btnPasswordDialog.Text = "PasswordDialog";
            this.btnPasswordDialog.UseVisualStyleBackColor = false;
            this.btnPasswordDialog.Click += new System.EventHandler(this.btnPasswordDialog_Click);
            // 
            // btnPromptDialog
            // 
            this.btnPromptDialog.AutoSize = true;
            this.btnPromptDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPromptDialog.BorderColor = System.Drawing.Color.Empty;
            this.btnPromptDialog.BorderSize = 1;
            this.btnPromptDialog.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btnPromptDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btnPromptDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btnPromptDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromptDialog.ForeColor = System.Drawing.Color.White;
            this.btnPromptDialog.Location = new System.Drawing.Point(4, 64);
            this.btnPromptDialog.Margin = new System.Windows.Forms.Padding(4);
            this.btnPromptDialog.Name = "btnPromptDialog";
            this.btnPromptDialog.Size = new System.Drawing.Size(178, 52);
            this.btnPromptDialog.TabIndex = 4;
            this.btnPromptDialog.Text = "PromptDialog";
            this.btnPromptDialog.UseVisualStyleBackColor = false;
            this.btnPromptDialog.Click += new System.EventHandler(this.btnPromptDialog_Click);
            // 
            // btnSelectionDialog
            // 
            this.btnSelectionDialog.AutoSize = true;
            this.btnSelectionDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSelectionDialog.BorderColor = System.Drawing.Color.Empty;
            this.btnSelectionDialog.BorderSize = 1;
            this.btnSelectionDialog.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btnSelectionDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btnSelectionDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btnSelectionDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionDialog.ForeColor = System.Drawing.Color.White;
            this.btnSelectionDialog.Location = new System.Drawing.Point(190, 64);
            this.btnSelectionDialog.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectionDialog.Name = "btnSelectionDialog";
            this.btnSelectionDialog.Size = new System.Drawing.Size(178, 52);
            this.btnSelectionDialog.TabIndex = 5;
            this.btnSelectionDialog.Text = "SelectionDialog";
            this.btnSelectionDialog.UseVisualStyleBackColor = false;
            this.btnSelectionDialog.Click += new System.EventHandler(this.btnSelectionDialog_Click);
            // 
            // btnMultipleSelectionDialog
            // 
            this.btnMultipleSelectionDialog.AutoSize = true;
            this.btnMultipleSelectionDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMultipleSelectionDialog.BorderColor = System.Drawing.Color.Empty;
            this.btnMultipleSelectionDialog.BorderSize = 1;
            this.btnMultipleSelectionDialog.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.btnMultipleSelectionDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(163)))));
            this.btnMultipleSelectionDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(244)))));
            this.btnMultipleSelectionDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultipleSelectionDialog.ForeColor = System.Drawing.Color.White;
            this.btnMultipleSelectionDialog.Location = new System.Drawing.Point(376, 64);
            this.btnMultipleSelectionDialog.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultipleSelectionDialog.Name = "btnMultipleSelectionDialog";
            this.btnMultipleSelectionDialog.Size = new System.Drawing.Size(178, 52);
            this.btnMultipleSelectionDialog.TabIndex = 6;
            this.btnMultipleSelectionDialog.Text = "MultipleSelectionDialog";
            this.btnMultipleSelectionDialog.UseVisualStyleBackColor = false;
            this.btnMultipleSelectionDialog.Click += new System.EventHandler(this.btnMultipleSelectionDialog_Click);
            // 
            // DialogDemoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DialogDemoPanel";
            this.Size = new System.Drawing.Size(863, 744);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Core.Controls.SimpleButton btnMessageDialog;
        private Core.Controls.SimpleButton btnInputDialog;
        private Core.Controls.SimpleButton btnInputMultiLineDialog;
        private Core.Controls.SimpleButton btnPasswordDialog;
        private Core.Controls.SimpleButton btnPromptDialog;
        private Core.Controls.SimpleButton btnSelectionDialog;
        private Core.Controls.SimpleButton btnMultipleSelectionDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Core.Controls.SimpleButton btnNeutralOptionColor;
        private Core.Controls.SimpleButton btnPositiveOptionColor;
        private Core.Controls.SimpleButton btnNegativeOptionColor;
        private Core.Controls.SimpleButton btnFunctionalOptionColor;
        private Core.Controls.SimpleButton btnSpecialOptionColor;
    }
}
