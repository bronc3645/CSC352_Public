﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapManager
{
    public partial class Form1 : Form
    {
        Bitmap renderImage = new Bitmap(@"C:\Users\kingd\Documents\GitHub\CSC352_Public\MapManager\Assets\JPG Maps\ascent_callouts.jpg");
        Bitmap overlayImage = null;
        Bitmap combinedImage = null;
        Point overlayLocation = new Point(0, 0);

        BindingList<Layer> layers= new BindingList<Layer>();
        
        decimal scalex = 0;
        decimal scaley = 0;

        bool edittingImage = false;

        public Form1()
        {
            InitializeComponent();
            mapPictureBox.Image = renderImage;
            mapPictureBox_Resize(this, new EventArgs());
            layers.Add(new Layer() { FileName = @"C:\Users\kingd\Documents\GitHub\CSC352_Public\MapManager\Assets\JPG Maps\ascent_callouts.jpg",
                current = new Bitmap(mapPictureBox.Image),
                Location = new Point(0, 0) });
            renderImage = RenderLayer();

            //binding the combobox to the layers list
            BindingSource layersbindingsource = new BindingSource();
            layersbindingsource.DataSource = layers;
            LayerList.DataSource = layersbindingsource.DataSource;
            LayerList.DisplayMember = "Name";
            LayerList.ValueMember = "current";

            this.MouseWheel += Form1_MouseWheel;
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {

        }

        private Bitmap RenderLayer()
        {
            return Renderer.RenderLayers(layers, mapPictureBox.Image.Width,mapPictureBox.Image.Height);
            /*Bitmap temp=new Bitmap(layers.First().current);

            using (Graphics combiner = Graphics.FromImage(temp))
            {
                foreach (Layer lay in layers)
                {
                    if (!lay.Equals(layers.First())) {
                        combiner.DrawImage(lay.current, lay.Location);
                    }
                }
            }
            return temp;*/
        }

        private void assetBox_Click(object sender, EventArgs e)
        {
            overlayImage = new Bitmap(assetBox.Image);
            mapPictureBox.Cursor = Cursors.Cross;
            edittingImage = true;
            debugStatis.Text = "in edit mode";
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
            mousePx.Text = e.X+"  "+e.Y;
            int x = (int)(e.X * scalex);
            int y = (int)(e.Y * scaley);
            mousePy.Text = (x - overlayImage.Width / 2) + "    " + (y - overlayImage.Height / 2);
            overlayLocation = new Point(x - overlayImage.Width / 2, y - overlayImage.Height / 2);
            showCombinedImage();
        }

        private void mapPictureBox_Click(object sender, EventArgs e)
        {
            if (overlayImage == null)
            {
                return;
            }

            layers.Add(new Layer() { current = new Bitmap(overlayImage), Location = overlayLocation, FileName = "" });

            overlayImage.Dispose();
            overlayImage = null;
            overlayLocation = new Point(0, 0);

            mapPictureBox.Cursor = Cursors.Default;
            renderImage.Dispose();
            renderImage = new Bitmap(RenderLayer());
            mapPictureBox.Image = renderImage;
            edittingImage = false;
            debugStatis.Text = "not in edit mode";
        }

        private void mapPictureBox_Resize(object sender, EventArgs e)
        {
            scalex = Decimal.Divide(renderImage.Width, mapPictureBox.Width);
            scaley = Decimal.Divide(renderImage.Height, mapPictureBox.Height);
        }

        private void LayerList_SelectedValueChanged(object sender, EventArgs e)
        {
            if(LayerList.SelectedValue is Bitmap)
            {
                Layerspic.Image = LayerList.SelectedValue as Bitmap;
            }
            else if(LayerList.SelectedValue is Layer)
            {
                Layerspic.Image = (LayerList.SelectedValue as Layer).current;
            }
        }
    }
}
