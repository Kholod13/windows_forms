using System.Drawing;
using System.Security.Cryptography;

namespace blaBlaPaint
{
    public partial class Form1 : Form
    {
        private List<IDrawable> shapes = new List<IDrawable>();
        private enum DrawingTools { Pencil, Point, Line, Rectangle, Ellipse, Curve };
        private IDrawable currentTool;

        private Color colorBrush = Color.Black;
        float sizeBrush = 2f;
        private Bitmap bitmap = null;
        private bool isDrawing = false;
        public Form1()
        {
            InitializeComponent();

            //bitmap
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;

            foreach (var item in Enum.GetValues<DrawingTools>())
            {
                toolStripComboBoxInstruments.Items.Add(item);
            }
            toolStripComboBoxInstruments.SelectedIndex = 0;
            currentTool = new Pencil(colorBrush, sizeBrush);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            foreach (IDrawable shape in shapes)
                shape.Drawing(graphics);
            graphics.Dispose();
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            DrawingTools tool = (DrawingTools)toolStripComboBoxInstruments.SelectedItem;
            switch (tool)
            {
                case DrawingTools.Pencil:
                    currentTool = new Pencil(colorBrush, sizeBrush);
                    break;
                case DrawingTools.Point:
                    currentTool = new Pointer(colorBrush, sizeBrush);
                    break;
                case DrawingTools.Line:
                    currentTool = new Line(colorBrush, sizeBrush);
                    break;
                case DrawingTools.Rectangle:
                    currentTool = new MyRectangle(colorBrush, sizeBrush);
                    break;
                case DrawingTools.Ellipse:
                    currentTool = new Ellipse(colorBrush, sizeBrush);
                    break;
                case DrawingTools.Curve:
                    currentTool = new Curve(colorBrush, sizeBrush);
                    break;
                default:
                    break;
            }

            if (currentTool != null)
            {
                currentTool.StartDrawing(e.Location);
                shapes.Add(currentTool as IDrawable);
                pictureBox1.Invalidate();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentTool != null)
            {
                currentTool.ContinueDrawing(e.Location);
                currentTool = null;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentTool != null)
            {
                currentTool.ContinueDrawing(e.Location);
                pictureBox1.Invalidate();
            }
        }

        private void toolStripButtonColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                colorBrush = dlg.Color;
        }

        private void trackBarSize_ValueChanged(object sender, EventArgs e)
        {
            sizeBrush = (float)trackBarSize.Value;
        }
    }
}