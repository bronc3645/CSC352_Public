using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MapManager
{
    public partial class Form1 : Form
    {
        Bitmap renderImage = new Bitmap("C:/Users/kingd/Documents/GitHub/CSC352_Public/MapManager/Assets/JPG Maps/ascent_callouts.jpg");
        Bitmap overlayImage = null;
        Bitmap combinedImage = null;
        Point overlayLocation = new Point(0, 0);

        List<Layer> layers= new List<Layer>();
        
        decimal scalex = 0;
        decimal scaley = 0;

        public Form1()
        {
            InitializeComponent();
            mapPictureBox.Image = renderImage;
            mapPictureBox_Resize(this, new EventArgs());
            layers.Add(new Layer() { FileName = "C:/Users/kingd/Documents/GitHub/CSC352_Public/MapManager/Assets/JPG Maps/ascent_callouts.jpg",
                current = new Bitmap(mapPictureBox.Image),
                Location = new Point(0, 0) });
            renderImage = RenderLayer(layers);
        }

        private Bitmap RenderLayer(List<Layer> layers)
        {
            return layers.First().current;

            //Bitmap render = new Bitmap();

            //foreach(var layer in layers)
            //{

            //}
        }

        private void assetBox_Click(object sender, EventArgs e)
        {
            overlayImage = new Bitmap(assetBox.Image);
            mapPictureBox.Cursor = Cursors.Cross;
        }

        private void showCombinedImage()
        {
            if (renderImage == null && overlayImage == null)
            {
                return;
            }

            mapPictureBox.Image = renderImage;

            if (combinedImage != null)
            {
                combinedImage.Dispose();
                combinedImage = null;
            }

            combinedImage = new Bitmap(renderImage);

            using (Graphics combiner = Graphics.FromImage(combinedImage))
            {
                combiner.DrawImage(overlayImage, overlayLocation);
            }

            mapPictureBox.Image = combinedImage;



        }

        private void mapPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (overlayImage == null)
            {
                return;
            }
            int x = (int)(e.X * scalex);
            int y = (int)(e.Y * scaley);
            overlayLocation = new Point(x - overlayImage.Width / 2, y - overlayImage.Height / 2);
            showCombinedImage();
        }

        private void mapPictureBox_Click(object sender, EventArgs e)
        {
            if (overlayImage == null)
            {
                return;
            }
            overlayImage.Dispose();
            overlayImage = null;
            mapPictureBox.Cursor = Cursors.Default;
            renderImage.Dispose();
            renderImage = new Bitmap(combinedImage);
        }

        private void mapPictureBox_Resize(object sender, EventArgs e)
        {
            scalex = Decimal.Divide(renderImage.Width, mapPictureBox.Width);
            scaley = Decimal.Divide(renderImage.Height, mapPictureBox.Height);
        }
    }
}
