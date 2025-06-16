using ApeFree.ApeForms.Core.Gdi;
using ApeFree.Cake2D.Shapes;
using ApeFree.Cake2D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeFree.ApeForms.Demo.DemoPanel
{
    public partial class GdiPaletteRadarChartDemoPanel : UserControl
    {
        public GdiPaletteRadarChartDemoPanel()
        {
            InitializeComponent();

            var chart = new RadarChart();
            chart.Parent = groupBox1;
            chart.SizeMode = PictureBoxSizeMode.Zoom;
            chart.Size = new Size(400, 400);
            chart.Location = new Point(20, 20);
            chart.BackColor = Color.White;
            chart.Dock = DockStyle.Fill;
            chart.BringToFront();

            chart.ChartAreas.Add(new RadarChartAreas { Name = "A", MaxValue = 100, MinValue = 0 });
            chart.ChartAreas.Add(new RadarChartAreas { Name = "B", MaxValue = 50, MinValue = 0 });
            chart.ChartAreas.Add(new RadarChartAreas { Name = "C", MaxValue = 10000, MinValue = 0 });
            chart.ChartAreas.Add(new RadarChartAreas { Name = "D", MaxValue = 100, MinValue = 0 });
            chart.ChartAreas.Add(new RadarChartAreas { Name = "E", MaxValue = 100, MinValue = 0 });
            chart.ChartAreas.Add(new RadarChartAreas { Name = "F", MaxValue = 100, MinValue = 0 });

            chart.Series.Add(new RadarChartSeries { Name = "小李", Color = Color.Red, Values = new decimal[] { 100, 15, 300, 20, 80, 45 } });
            chart.Series.Add(new RadarChartSeries { Name = "小王", Color = Color.Blue, Values = new decimal[] { 60, 25, 5000, 85, 70, 15 } });
            chart.Series.Add(new RadarChartSeries { Name = "老张", Color = Color.Green, Values = new decimal[] { 15, 50, 8000, 50, 20, 95 } });

            chart.RefreshChart();

            propertyGrid.SelectedObject = chart;
        }
    }

    /// <summary>
    /// 雷达图控件
    /// </summary>
    public partial class RadarChart : PaletteBox
    {
        /// <summary>
        /// 最大轴数
        /// </summary>
        private const int MaxAxis = 8;

        /// <summary>
        /// 最大圈数
        /// </summary>
        private const int MaxRings = 10;

        /// <summary>
        /// 最大数据系列数
        /// </summary>
        private const int MaxSeries = 5;

        /// <summary>
        /// 控件中心点的坐标
        /// </summary>
        private PointF CenterPoint => new PointF(Palette.CanvasSize.Width / 2, Palette.CanvasSize.Height / 2);

        /// <summary>
        /// 圆环的最大半径
        /// </summary>
        private float MaxRadius => Math.Min(Palette.CanvasSize.Width, Palette.CanvasSize.Height) / 2 - 30;

        /// <summary>
        /// 圈数
        /// </summary>
        public int RingCount
        {
            get => ringCount; set
            {
                if (value > MaxRings)
                {
                    value = MaxRings;
                }

                if (ringCount != value)
                {
                    ringCount = value;
                    RedrawRings();
                    RefreshImage();
                }
            }
        }
        private int ringCount = MaxRings;

        /// <summary>
        /// 轴数
        /// </summary>
        private int AxisCount => ChartAreas.Count < 1 || ChartAreas.Count > MaxAxis ? MaxAxis : ChartAreas.Count;

        /// <summary>
        /// 区域不透明度
        /// </summary>
        public byte AreaOpacity { get => areaOpacity; set { areaOpacity = value; RedrawPolygon(); RefreshImage(); } }
        private byte areaOpacity = 128;

        /// <summary>
        /// 线圈颜色
        /// </summary>
        public Color RingColor { get => ringStyle.Pen.Color; set { ringStyle.Pen.Color = value; RedrawRings(); RefreshImage(); } }

        /// <summary>
        /// 轴颜色
        /// </summary>
        public Color AxisColor { get => axisStyle.Pen.Color; set { axisStyle.Pen.Color = value; RedrawAxis(); RefreshImage(); } }

        /// <summary>
        /// 线圈风格
        /// </summary>
        private readonly GdiStyle ringStyle = new GdiStyle() { Pen = new Pen(Color.Gray) };

        /// <summary>
        /// 轴风格
        /// </summary>
        private readonly GdiStyle axisStyle = new GdiStyle() { Pen = new Pen(Color.Gray) };

        /// <summary>
        /// 标签风格
        /// </summary>
        private readonly GdiStyle labelStyle = new GdiStyle() { Pen = new Pen(Color.Gray), StringFormat = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center } };

        /// <summary>
        /// 图表中的数据系列
        /// </summary>
        public List<RadarChartSeries> Series
        {
            get => series; set
            {
                series = value;
                RedrawPolygon();
                RefreshImage();
            }
        }
        private List<RadarChartSeries> series = new List<RadarChartSeries>();

        /// <summary>
        /// 数据系列数
        /// </summary>
        private int SeriesCount => Series.Count < 1 || Series.Count > MaxSeries ? MaxSeries : Series.Count;

        /// <summary>
        /// 图表中的绘图区域
        /// </summary>
        public List<RadarChartAreas> ChartAreas
        {
            get => chartAreas; set
            {
                if (chartAreas.Count != value.Count)
                {
                    chartAreas = value;
                    RedrawAxis();
                    RedrawPolygon();
                    RefreshImage();
                }
                else
                {
                    chartAreas = value;
                }
            }
        }
        private List<RadarChartAreas> chartAreas = new List<RadarChartAreas>();
        private Layer<GdiStyle, TextShape> tipsLayer;
        private readonly List<Layer<GdiStyle, CircleShape>> ringLayers = new List<Layer<GdiStyle, CircleShape>>();
        private readonly List<Layer<GdiStyle, VectorSahpe>> axisLayers = new List<Layer<GdiStyle, VectorSahpe>>();
        private readonly List<Layer<GdiStyle, TextShape>> labelLayers = new List<Layer<GdiStyle, TextShape>>();
        private readonly List<Layer<GdiStyle, PolygonShape>> polygonLayers = new List<Layer<GdiStyle, PolygonShape>>();

        public RadarChart()
        {
            Palette.CanvasSize = new Size(300, 300);
            Palette.OutputSize = new Size(300, 300);
        }

        private void RedrawRings()
        {
            if (!ringLayers.Any())
            {
                for (int i = 0; i < MaxRings; i++)
                {
                    var layer = Palette.DrawCircle(ringStyle, new CircleShape(CenterPoint, 1));
                    layer.Visible = false;
                    ringLayers.Add(layer);
                }
            }

            var interval = MaxRadius / RingCount;

            for (int i = 0; i < MaxRings; i++)
            {
                var layer = ringLayers[i];
                layer.Shape.Location = CenterPoint;
                layer.Shape.Radius = interval * (i + 1);
                layer.Visible = i < RingCount;
            }
        }

        private void RedrawAxis()
        {
            var maxRadius = MaxRadius;
            var axisCount = AxisCount;

            if (!axisLayers.Any())
            {
                for (int i = 0; i < MaxAxis; i++)
                {
                    var layer = Palette.DrawVector(axisStyle, new VectorSahpe(CenterPoint, 0, 0));
                    layer.Visible = false;
                    axisLayers.Add(layer);

                    var text = Palette.DrawText(labelStyle, new TextShape(new PointF(), 100, 100, string.Empty));
                    layer.Visible = false;
                    labelLayers.Add(text);
                }
            }

            for (int i = 0; i < MaxAxis; i++)
            {
                var layer = axisLayers[i];
                layer.Shape.StartPoint = CenterPoint;
                layer.Shape.Length = maxRadius;
                layer.Shape.Angle = 360 / AxisCount * i;
                layer.Visible = i < axisCount;

                var text = labelLayers[i];
                text.Visible = layer.Visible;
                if (ChartAreas.Count > i)
                {
                    var vector = layer.Shape;
                    text.Shape.Location = Math2D.CalculatePointOnCircle(vector.StartPoint, vector.Length + 20, vector.Angle).Subtract(50, 50);
                    text.Shape.Text = ChartAreas[i].Name;
                }
            }
        }

        private void RedrawPolygon()
        {
            var maxRadius = MaxRadius;
            var seriesCount = SeriesCount;

            if (!polygonLayers.Any())
            {
                for (int i = 0; i < MaxSeries; i++)
                {
                    var layer = Palette.DrawPolygon(new GdiStyle(), new PolygonShape(new PointF[6]));
                    layer.Visible = false;
                    polygonLayers.Add(layer);
                }
            }

            for (int i = 0; i < seriesCount; i++)
            {
                var layer = polygonLayers[i];

                if (i >= Series.Count)
                {
                    layer.Visible = false;
                    continue;
                }

                var series = Series[i];
                var rate = series.Values.Select((v, ai) =>
                {
                    var area = ChartAreas[ai];
                    return (float)((v - area.MinValue) / (area.MaxValue - area.MinValue));
                }).ToArray();

                List<PointF> points = new List<PointF>();
                for (int j = 0; j < AxisCount; j++)
                {
                    var p = Math2D.CalculatePointOnCircle(CenterPoint, maxRadius * rate.ElementAt(j), 360 / AxisCount * j);
                    points.Add(p);
                }

                points.CopyTo(layer.Shape.Points, 0);
                layer.Style.Clear();
                layer.Style.Pen = new Pen(series.Color);
                layer.Style.Brush = new SolidBrush(Color.FromArgb(AreaOpacity, series.Color));
                layer.Visible = true;
                layer.Tag = series.Name;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RefreshChart();
        }

        public void RefreshChart()
        {
            RedrawRings();
            RedrawAxis();
            RedrawPolygon();
            RefreshImage();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            var layer = Palette.SelectTopLayerByCastingPoint(new PointF(e.X, e.Y));

            if (layer != null)
            {
                if (!polygonLayers.Contains(layer))
                {
                    if (tipsLayer != null)
                    {
                        tipsLayer.Visible = false;
                    }
                    RefreshImage();
                    return;
                }

                var layerInfo = layer.Tag as string;
                var location = new PointF(e.X + 10, e.Y + 10);

                layer.Parent.Layers.Remove(layer);
                layer.Parent.Layers.Add(layer);

                if (tipsLayer == null)
                {
                    tipsLayer = Palette.DrawText(new GdiStyle() { Brush = Brushes.Black, Font = Font, StringFormat = new StringFormat(StringFormatFlags.NoWrap) }, new TextShape(location, 100, 50, layerInfo));
                    tipsLayer.Selectable = false;
                }
                else
                {
                    tipsLayer.Shape.Text = layerInfo;
                    tipsLayer.Shape.Location = location;
                }

                tipsLayer.Parent.Layers.Remove(tipsLayer);
                tipsLayer.Parent.Layers.Add(tipsLayer);
                tipsLayer.Visible = true;
            }
            else
            {
                if (tipsLayer != null)
                {
                    tipsLayer.Visible = false;
                }
            }
            RefreshImage();
        }
    }

    [Serializable]
    public struct RadarChartAreas
    {
        public string Name { get; set; }
        public decimal MaxValue { get; set; }
        public decimal MinValue { get; set; }
    }

    [Serializable]
    public struct RadarChartSeries
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public decimal[] Values { get; set; }
    }
}
