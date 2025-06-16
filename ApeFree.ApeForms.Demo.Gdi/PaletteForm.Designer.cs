using ApeFree.ApeForms.Core.Gdi;

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
            this.hsbImage = new System.Windows.Forms.HScrollBar();
            this.vsbImage = new System.Windows.Forms.VScrollBar();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.box = new PaletteBox();
            this.cbEnableMouseWheelScale = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDrawRect
            // 
            this.btnDrawRect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrawRect.Location = new System.Drawing.Point(3, 17);
            this.btnDrawRect.Name = "btnDrawRect";
            this.btnDrawRect.Size = new System.Drawing.Size(125, 23);
            this.btnDrawRect.TabIndex = 1;
            this.btnDrawRect.Text = "矩形";
            this.btnDrawRect.UseVisualStyleBackColor = true;
            this.btnDrawRect.Click += new System.EventHandler(this.btnDrawRect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEnableMouseWheelScale);
            this.groupBox1.Controls.Add(this.cbMode);
            this.groupBox1.Controls.Add(this.btnScale);
            this.groupBox1.Controls.Add(this.btnDrawEllipse);
            this.groupBox1.Controls.Add(this.btnDrawCircle);
            this.groupBox1.Controls.Add(this.btnDrawRect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(665, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 595);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnScale
            // 
            this.btnScale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnScale.Location = new System.Drawing.Point(3, 569);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(125, 23);
            this.btnScale.TabIndex = 4;
            this.btnScale.Text = "缩放比例100%";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnDrawEllipse
            // 
            this.btnDrawEllipse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrawEllipse.Location = new System.Drawing.Point(3, 63);
            this.btnDrawEllipse.Name = "btnDrawEllipse";
            this.btnDrawEllipse.Size = new System.Drawing.Size(125, 23);
            this.btnDrawEllipse.TabIndex = 3;
            this.btnDrawEllipse.Text = "椭圆形";
            this.btnDrawEllipse.UseVisualStyleBackColor = true;
            this.btnDrawEllipse.Click += new System.EventHandler(this.btnDrawEllipse_Click);
            // 
            // btnDrawCircle
            // 
            this.btnDrawCircle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrawCircle.Location = new System.Drawing.Point(3, 40);
            this.btnDrawCircle.Name = "btnDrawCircle";
            this.btnDrawCircle.Size = new System.Drawing.Size(125, 23);
            this.btnDrawCircle.TabIndex = 2;
            this.btnDrawCircle.Text = "圆形";
            this.btnDrawCircle.UseVisualStyleBackColor = true;
            this.btnDrawCircle.Click += new System.EventHandler(this.btnDrawCircle_Click);
            // 
            // hsbImage
            // 
            this.hsbImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hsbImage.Location = new System.Drawing.Point(0, 578);
            this.hsbImage.Maximum = 500;
            this.hsbImage.Minimum = -500;
            this.hsbImage.Name = "hsbImage";
            this.hsbImage.Size = new System.Drawing.Size(645, 17);
            this.hsbImage.TabIndex = 5;
            this.hsbImage.ValueChanged += new System.EventHandler(this.hsbImage_ValueChanged);
            // 
            // vsbImage
            // 
            this.vsbImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.vsbImage.Location = new System.Drawing.Point(645, 0);
            this.vsbImage.Maximum = 500;
            this.vsbImage.Minimum = -500;
            this.vsbImage.Name = "vsbImage";
            this.vsbImage.Size = new System.Drawing.Size(20, 595);
            this.vsbImage.TabIndex = 6;
            this.vsbImage.ValueChanged += new System.EventHandler(this.hsbImage_ValueChanged);
            // 
            // cbMode
            // 
            this.cbMode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Location = new System.Drawing.Point(3, 549);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(125, 20);
            this.cbMode.TabIndex = 5;
            this.cbMode.SelectedValueChanged += new System.EventHandler(this.cbMode_SelectedValueChanged);
            // 
            // panel
            // 
            this.box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box.CanvasBackColor = System.Drawing.Color.White;
            this.box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box.Location = new System.Drawing.Point(0, 0);
            this.box.Name = "panel";
            this.box.Size = new System.Drawing.Size(645, 578);
            this.box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box.TabIndex = 0;
            this.box.TabStop = false;
            // 
            // cbEnableMouseWheelScale
            // 
            this.cbEnableMouseWheelScale.AutoSize = true;
            this.cbEnableMouseWheelScale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbEnableMouseWheelScale.Location = new System.Drawing.Point(3, 533);
            this.cbEnableMouseWheelScale.Name = "cbEnableMouseWheelScale";
            this.cbEnableMouseWheelScale.Size = new System.Drawing.Size(125, 16);
            this.cbEnableMouseWheelScale.TabIndex = 6;
            this.cbEnableMouseWheelScale.Text = "EnableMouseWheelScale";
            this.cbEnableMouseWheelScale.UseVisualStyleBackColor = true;
            this.cbEnableMouseWheelScale.CheckedChanged += new System.EventHandler(this.cbEnableMouseWheelScale_CheckedChanged);
            // 
            // PaletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 595);
            this.Controls.Add(this.box);
            this.Controls.Add(this.hsbImage);
            this.Controls.Add(this.vsbImage);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaletteForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Core.Gdi.PaletteBox box;
        private Button btnDrawRect;
        private GroupBox groupBox1;
        private Button btnDrawEllipse;
        private Button btnDrawCircle;
        private Button btnScale;
        private HScrollBar hsbImage;
        private VScrollBar vsbImage;
        private ComboBox cbMode;
        private CheckBox cbEnableMouseWheelScale;
    }
}
