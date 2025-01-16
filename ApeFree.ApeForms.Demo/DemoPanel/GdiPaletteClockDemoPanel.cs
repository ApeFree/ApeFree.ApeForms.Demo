using ApeFree.ApeForms.Core.Gdi;
using ApeFree.Cake2D.Shapes;
using ApeFree.Cake2D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeFree.ApeForms.Demo.DemoPanel
{
    public partial class GdiPaletteClockDemoPanel : UserControl
    {
        // 表盘中心点
        private Point centralPoint = new Point(200, 200);
        // 表盘半径
        private int clockRadius = 150;

        // 画板
        private readonly GdiPalette palette;
        // 时分秒针图层
        private readonly Layer<GdiStyle, VectorSahpe> layerHour;
        private readonly Layer<GdiStyle, VectorSahpe> layerMinute;
        private readonly Layer<GdiStyle, VectorSahpe> layerSecond;

        private readonly Layer<GdiStyle, PolygonShape> layerPolygon;

        /// <summary>
        /// 画布控件
        /// </summary>
        private Control ctrlCanvas => panelCanvas;

        public GdiPaletteClockDemoPanel()
        {
            InitializeComponent();

            // 创建GDI+画板
            palette = new GdiPalette();

            // 绘制圆形表盘和刻度
            palette.Draw(new GdiStyle() { Pen = new Pen(Color.Black, 3), Brush = new SolidBrush(Color.FromArgb(128, Color.White)) }, new CircleShape(centralPoint, clockRadius));

            for (int i = 0; i < 60; i++)
            {
                palette.Draw(new GdiStyle() { Pen = new Pen(Color.DarkGray, 2) }, new LineShape(Math2D.CalculatePointOnCircle(centralPoint, clockRadius - 10, i * 6), Math2D.CalculatePointOnCircle(centralPoint, clockRadius - (i % 5 == 0 ? 25 : 15), i * 6)));
            }

            // 绘制时针分针秒针，并将图层存到全局
            layerSecond = palette.DrawVector(new GdiStyle() { Pen = new Pen(Color.DarkRed, 1) }, new VectorSahpe(centralPoint, clockRadius - 10, -90));
            layerMinute = palette.DrawVector(new GdiStyle() { Pen = new Pen(Color.DarkGreen, 3) }, new VectorSahpe(centralPoint, clockRadius - 30, -90));
            layerHour = palette.DrawVector(new GdiStyle() { Pen = new Pen(Color.DarkBlue, 5) }, new VectorSahpe(centralPoint, clockRadius - 50, -90));

            layerPolygon = palette.DrawPolygon(new GdiStyle() { Pen = new Pen(Color.FromArgb(0, 122, 204), 1), Brush = new SolidBrush(Color.FromArgb(64, 0, 122, 204)) }, new PolygonShape(new PointF[] { new PointF(), new PointF(), new PointF() }));
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // 更新表盘画面
            UpdateClock();
        }

        int c = 0;
        private void timerClock_Tick(object sender, EventArgs e)
        {
            // 获取当前时间，并计算当前是今日的第几秒
            var now = DateTime.Now;
            var totalSeconds = now.Hour * 3600 + now.Minute * 60 + now.Second;

            // 根据当前时间计算时针分针秒针的指向
            layerSecond.Shape.With(shape =>
            {
                shape.Angle = totalSeconds % 60 / 60f * 360 - 90;
            });
            layerMinute.Shape.With(shape =>
            {
                shape.Angle = totalSeconds % 3600 / 3600f * 360 - 90;
            });
            layerHour.Shape.With(shape =>
            {
                shape.Angle = totalSeconds / 86400f * 360 - 90;
            });

            var points = new[] { layerSecond, layerMinute, layerHour }.Select(l => l.Shape.EndPoint);
            layerPolygon.Shape.Points = points.ToArray();

            UpdateClock();
        }

        Bitmap buffer;

        // 刷新时钟上的时间
        //public void UpdateClock()
        //{
        //    // 需要绘制的矩形区域
        //    Rectangle rect = ctrlCanvas.ClientRectangle;

        //    if (buffer == null)
        //    {
        //        buffer = new Bitmap(rect.Width, rect.Height);

        //        // 在位图缓存上绘制方块
        //        // 清除之前绘制的内容
        //        palette.Canvas = Graphics.FromImage(buffer);
        //    }

        //    if (ctrlCanvas.BackgroundImage != null)
        //    {
        //        palette.Canvas.DrawImageUnscaled(ctrlCanvas.BackgroundImage, rect);
        //    }
        //    else
        //    {
        //        palette.Canvas.Clear(ctrlCanvas.BackColor);
        //    }

        //    palette.UpdateCanvas();

        //    // 将位图缓存直接绘制到 Panel 控件上
        //    using (Graphics graphics = ctrlCanvas.CreateGraphics())
        //    {
        //        graphics.DrawImageUnscaled(buffer, rect);
        //    }
        //}

        // 刷新时钟上的时间
        public void UpdateClock()
        {
            // 需要绘制的矩形区域
            Rectangle rect = ctrlCanvas.ClientRectangle;
            palette.ClientRectangle = rect;

            if (ctrlCanvas.BackgroundImage != null)
            {
                palette.Canvas.DrawImageUnscaled(ctrlCanvas.BackgroundImage, rect);
            }
            else
            {
                palette.Canvas.Clear(ctrlCanvas.BackColor);
            }

            palette.UpdateCanvas();

            // 将位图缓存直接绘制到 Panel 控件上
            using (Graphics graphics = ctrlCanvas.CreateGraphics())
            {
                graphics.DrawImageUnscaled(palette.Image, rect);
            }
        }
    }
}
