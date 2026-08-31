using System;
using System.Drawing;
using System.Windows.Forms;
using ApeFree.Cake2D.Elements;
using ApeFree.Cake2D.Elements.Containers;
using ApeFree.Cake2D.Elements.Primitives;
using ApeFree.Cake2D.Math;

namespace ApeFree.ApeForms.Demo.Gdi
{
    public partial class PaletteForm : Form
    {
        private readonly Random _rand = new Random();

        public PaletteForm()
        {
            InitializeComponent();

            box.Scene.BackgroundColor = Color.FromArgb(248, 250, 252);
            box.Scene.Add(new GridElement());
            box.Scene.Add(new AxisElement());
        }

        private void btnDrawRect_Click(object sender, EventArgs e)
        {
            float x = _rand.Next(-200, 200);
            float y = _rand.Next(-200, 200);
            float w = _rand.Next(60, 150);
            float h = _rand.Next(40, 120);

            var rect = new RectangleElement(x, y, w, h)
            {
                Name = $"矩形 {_rand.Next(100, 999)}",
                FillColor = Color.FromArgb(160, _rand.Next(50, 230), _rand.Next(50, 230), _rand.Next(50, 230)),
                StrokeColor = Color.Black,
                LineWidth = 1.5f,
                ZIndex = 5
            };
            BindElementInteractivity(rect);
            box.Scene.Add(rect);
            box.Invalidate();
        }

        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            float x = _rand.Next(-200, 200);
            float y = _rand.Next(-200, 200);
            float r = _rand.Next(30, 80);

            var circle = new CircleElement(x, y, r)
            {
                Name = $"圆形 {_rand.Next(100, 999)}",
                FillColor = Color.FromArgb(160, _rand.Next(50, 230), _rand.Next(50, 230), _rand.Next(50, 230)),
                StrokeColor = Color.Black,
                LineWidth = 1.5f,
                ZIndex = 5
            };
            BindElementInteractivity(circle);
            box.Scene.Add(circle);
            box.Invalidate();
        }

        private void btnDrawEllipse_Click(object sender, EventArgs e)
        {
            float x = _rand.Next(-200, 200);
            float y = _rand.Next(-200, 200);
            float rx = _rand.Next(40, 90);
            float ry = _rand.Next(25, 60);

            var ellipse = new EllipseElement(x, y, rx, ry)
            {
                Name = $"椭圆 {_rand.Next(100, 999)}",
                FillColor = Color.FromArgb(160, _rand.Next(50, 230), _rand.Next(50, 230), _rand.Next(50, 230)),
                StrokeColor = Color.Black,
                LineWidth = 1.5f,
                ZIndex = 5
            };
            BindElementInteractivity(ellipse);
            box.Scene.Add(ellipse);
            box.Invalidate();
        }

        private void BindElementInteractivity(Element2D element)
        {
            Color? originalFill = element.FillColor;
            element.MouseEnter += (s, e) =>
            {
                if (originalFill.HasValue)
                {
                    element.FillColor = Color.FromArgb(240, originalFill.Value.R, originalFill.Value.G, originalFill.Value.B);
                }
                element.LineWidth = 3f;
                box.Invalidate();
            };

            element.MouseLeave += (s, e) =>
            {
                element.FillColor = originalFill;
                element.LineWidth = 1.5f;
                box.Invalidate();
            };
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            box.Scene.Viewport.SetView(PointF.Empty, 800f);
            box.Invalidate();
        }
    }
}