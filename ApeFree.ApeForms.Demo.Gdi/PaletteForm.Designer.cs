namespace ApeFree.ApeForms.Demo.Gdi
{
    partial class PaletteForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDrawRect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnDrawEllipse = new System.Windows.Forms.Button();
            this.btnDrawCircle = new System.Windows.Forms.Button();
            this.box = new ApeFree.Cake2D.Gdi.Controls.Cake2DControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDrawRect
            // 
            this.btnDrawRect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrawRect.Location = new System.Drawing.Point(3, 17);
            this.btnDrawRect.Name = "btnDrawRect";
            this.btnDrawRect.Size = new System.Drawing.Size(144, 30);
            this.btnDrawRect.TabIndex = 1;
            this.btnDrawRect.Text = "添加矩形";
            this.btnDrawRect.UseVisualStyleBackColor = true;
            this.btnDrawRect.Click += new System.EventHandler(this.btnDrawRect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnScale);
            this.groupBox1.Controls.Add(this.btnDrawEllipse);
            this.groupBox1.Controls.Add(this.btnDrawCircle);
            this.groupBox1.Controls.Add(this.btnDrawRect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(646, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 595);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作面板";
            // 
            // btnScale
            // 
            this.btnScale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnScale.Location = new System.Drawing.Point(3, 562);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(144, 30);
            this.btnScale.TabIndex = 4;
            this.btnScale.Text = "重置原点与视角";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnDrawEllipse
            // 
            this.btnDrawEllipse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrawEllipse.Location = new System.Drawing.Point(3, 77);
            this.btnDrawEllipse.Name = "btnDrawEllipse";
            this.btnDrawEllipse.Size = new System.Drawing.Size(144, 30);
            this.btnDrawEllipse.TabIndex = 3;
            this.btnDrawEllipse.Text = "添加椭圆";
            this.btnDrawEllipse.UseVisualStyleBackColor = true;
            this.btnDrawEllipse.Click += new System.EventHandler(this.btnDrawEllipse_Click);
            // 
            // btnDrawCircle
            // 
            this.btnDrawCircle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrawCircle.Location = new System.Drawing.Point(3, 47);
            this.btnDrawCircle.Name = "btnDrawCircle";
            this.btnDrawCircle.Size = new System.Drawing.Size(144, 30);
            this.btnDrawCircle.TabIndex = 2;
            this.btnDrawCircle.Text = "添加圆形";
            this.btnDrawCircle.UseVisualStyleBackColor = true;
            this.btnDrawCircle.Click += new System.EventHandler(this.btnDrawCircle_Click);
            // 
            // box
            // 
            this.box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box.Location = new System.Drawing.Point(0, 0);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(646, 595);
            this.box.TabIndex = 0;
            // 
            // PaletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 595);
            this.Controls.Add(this.box);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaletteForm";
            this.Text = "Cake2D 交互式画板演示";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private ApeFree.Cake2D.Gdi.Controls.Cake2DControl box;
        private System.Windows.Forms.Button btnDrawRect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDrawEllipse;
        private System.Windows.Forms.Button btnDrawCircle;
        private System.Windows.Forms.Button btnScale;
    }
}