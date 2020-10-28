using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapManager
{
    public partial class Form1 : Form
    {
        Bitmap renderImange = null;
        Bitmap overlayImage = null;
        Bitmap combinedImage = null;
        Point overlayLocation = new Point(0,0);

        public Form1()
        {
            InitializeComponent();
            renderImange = new Bitmap(mapPictureBox.Image);
        }

        private void assetBox_Click(object sender, EventArgs e)
        {
            overlayImage = new Bitmap(assetBox.Image);
            mapPictureBox.Cursor = Cursors.Cross;
        }

        private void showCombinedImage()
        {
            if (renderImange == null && overlayImage == null)
            {
                return;
            }

            mapPictureBox.Image = renderImange;

            if (combinedImage != null)
            {
                combinedImage.Dispose();
                combinedImage = null;
            }

            combinedImage = new Bitmap(renderImange);

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
            Console.WriteLine(e.X + "  " + e.Y);
            overlayLocation=new Point(e.X, e.Y);

            showCombinedImage();
        }
    }
}
