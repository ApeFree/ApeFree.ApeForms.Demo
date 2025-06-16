using ApeFree.ApeForms.Core.Gdi;
using ApeFree.Cake2D.Shapes;
using System.Windows.Forms;

namespace ApeFree.ApeForms.Demo.Gdi
{
    public partial class PaletteForm : Form
    {
        public PaletteForm()
        {
            InitializeComponent();
            box.Palette.OutputSize = new Size(1000, 1000);
            box.Palette.OriginOffset = new PointF(box.Palette.OutputSize.Width / 2, box.Palette.OutputSize.Height / 2);
            cbMode.Items.AddRange(Enum.GetValues(typeof(PictureBoxSizeMode)).Cast<object>().ToArray());
        }

        private void btnDrawRect_Click(object sender, EventArgs e)
        {
            box.Palette.DrawRectangle(new GdiStyle() { Pen = Pens.DarkGreen, Brush = Brushes.Green }, new RectangleShape(200, 200, 100, 100));
            box.RefreshImage();
        }

        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            //panel.Palette.DrawCircle(new GdiStyle() { Pen = Pens.DarkRed, Brush = Brushes.Red }, new CircleShape(0, 0, 280));
            var layer = box.Palette.DrawCircle(new GdiStyle() { Pen = Pens.Black }, new CircleShape(0, 0, 490));
            layer.Selectable = false;
            box.RefreshImage();
        }

        private void btnDrawEllipse_Click(object sender, EventArgs e)
        {
            box.Palette.DrawEllipse(new GdiStyle() { Pen = Pens.DarkOrange, Brush = Brushes.Orange }, new EllipseShape(100, 100, 50, 100));
            box.RefreshImage();
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            box.Palette.Scale = 1f;
            box.RefreshImage();
        }

        private void hsbImage_ValueChanged(object sender, EventArgs e)
        {
            box.Palette.ZoomCenter = new PointF(hsbImage.Value, vsbImage.Value);
            box.RefreshImage();
        }

        private void cbMode_SelectedValueChanged(object sender, EventArgs e)
        {
            box.SizeMode = (PictureBoxSizeMode)cbMode.SelectedItem;
        }

        private void cbEnableMouseWheelScale_CheckedChanged(object sender, EventArgs e)
        {
            box.EnableMouseWheelScale = cbEnableMouseWheelScale.Checked;
        }
    }
}
