using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PAINT
{
    public partial class PaintLiteEditionSuper : Form
    {
      
    
        int historyCounter;
        bool drawing;
        GraphicsPath currentPath;
        Point oldLocation;
        Pen currentPen;
        Color historyColor;
        List<Image> History;
        public PaintLiteEditionSuper()
        {
       
            History = new List<Image>();
            InitializeComponent();
            drawing = false;
            currentPen = new Pen (Color.Black);
            currentPen.Width =trackBar1.Value;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.Clear();
            historyCounter = 0;
            Bitmap pic = new Bitmap(1325, 894);
            picDrawingSurface.Image = pic;
            History.Add(new Bitmap(picDrawingSurface.Image));
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение рисунка?", "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: saveToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }
        }

        private void picDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            historyColor = currentPen.Color;
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!");
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }
            if (e.Button == MouseButtons.Right)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPen.Color = Color.White;
                currentPath = new GraphicsPath();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "jpeg img| *.jpg|bitmap image|*.bmp|gif image|*.gif|png image|*.png";
            SaveDlg.Title = "Save an image file";
            SaveDlg.FilterIndex = 4;
            SaveDlg.ShowDialog();
            if (SaveDlg.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile();
                    switch (SaveDlg.FilterIndex)
                    {
                        case 1:
                            this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                            break;
                        case 2:
                            this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                            break;
                        case 3:
                            this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                            break;
                        case 4:
                            this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                            break;
                    }
                    fs.Close();
                }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "jpeg img| *.jpg|bitmap image|*.bmp|gif image|*.gif|png image|*.png";
            OP.Title = "save an image file";
            OP.FilterIndex = 1;
            if (OP.ShowDialog() != DialogResult.Cancel)
                picDrawingSurface.Load(OP.FileName);
        }

        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
            History.Add(new Bitmap(picDrawingSurface.Image));
            if (historyCounter + 1 < 10) historyCounter++;
            if (History.Count - 1 == 10) History.RemoveAt(0);
            drawing = false;
            try
            {
                
                currentPath.Dispose();
                currentPen.Color = historyColor;
                
            }
            catch { };
        }

        private void picDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
                label_XY.Text = e.X.ToString() + ", " + e.Y.ToString();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBar1.Value;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0)
            {
                picDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter<History.Count-1)
            {
                picDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            }
            else MessageBox.Show("История пуста");
           
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;
            solidToolStripMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = false;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = true;
            dashDotDotToolStripMenuItem.Checked = false;
        }

        private void dashDotDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.DashDotDot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = true;
        }

        private void picDrawingSurface_Click(object sender, EventArgs e)
        {

        }
    }
}
