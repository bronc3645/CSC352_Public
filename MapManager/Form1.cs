using System;
using System.Drawing;
using System.Windows.Forms;

namespace MapManager
{
    public partial class Form1 : Form
    {
        Bitmap renderImage = new Bitmap("C:/Users/kingd/Documents/GitHub/CSC352_Public/MapManager/Assets/JPG Maps/ascent_callouts.jpg");
        Bitmap overlayImage = null;
        Bitmap combinedImage = null;
        Point overlayLocation = new Point(0,0);
        int orginalsizeX = 0;
        int orginalsizey = 0;
        double scalex = 0;
        double scaley = 0;

        public Form1()
        {
            InitializeComponent();
            orginalsizeX = renderImage.Width;
            orginalsizey = renderImage.Height;
            renderImage = new Bitmap(mapPictureBox.Image);
            scalex = (double)(Decimal.Divide(orginalsizeX,mapPictureBox.Width));
            scaley = (double)Decimal.Divide(orginalsizey,mapPictureBox.Height);
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

            /*// If there's no background image, do nothing.
            if (renderImange == null) return;

            // Copy the background.
            combinedImage= new Bitmap(renderImange);

            // Add the overlay.
            if (overlayImage != null)
            {
                using (Graphics gr = Graphics.FromImage(combinedImage))
                {
                    gr.DrawImage(overlayImage, overlayLocation);
                }
            }

            // Display the result.
            mapPictureBox.Image = combinedImage;*/

        }

        private void mapPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (overlayImage == null)
            {
                return;
            }
            int x = (int)( e.X * scalex);
            int y = (int)(e.Y * scaley);
            overlayLocation=new Point(x - overlayImage.Width / 2, y - overlayImage.Height / 2);
            showCombinedImage();
        }
    }
}
