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

        bool asset = false;
        Layer moding;

        int overlayscale = 100;
        Bitmap originalOverlay;

        public Form1()
        {
            InitializeComponent();
            mapPictureBox.Image = renderImage;
            MapPictureBox_Resize(this, new EventArgs());
            layers.Add(new Layer() { FileName = @"C:\Users\kingd\Documents\GitHub\CSC352_Public\MapManager\Assets\JPG Maps\ascent_callouts.jpg",
                current = new Bitmap(mapPictureBox.Image),
                Location = new Point(0, 0),
                Scale=Renderer.Scale(renderImage.Size,1)});
            renderImage = RenderLayer();

            //binding the combobox to the layers list
            BindingSource layersbindingsource = new BindingSource();
            layersbindingsource.DataSource = layers;
            LayerList.DataSource = layersbindingsource.DataSource;
            LayerList.DisplayMember = "Name";
            LayerList.ValueMember = "current";

            MouseWheel += Form1_MouseWheel;
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (edittingImage)
            {
                if (originalOverlay == null)
                {
                    if (asset)
                    {
                        originalOverlay = new Bitmap(overlayImage);
                    }
                    else
                    {
                        originalOverlay = new Bitmap(moding.current);
                    }
                }
                int increasedScale = 1;

                if (Control.ModifierKeys == Keys.Shift)
                {
                    increasedScale=10;
                }
                
                if (e.Delta > 0)
                {
                    overlayscale+=increasedScale;
                }
                else if (e.Delta < 0)
                { 
                    if (overlayscale -increasedScale > 1)
                    {
                        overlayscale-=increasedScale;
                    }
                }
                
                double scale = overlayscale * .01;
                Size scaledSize;
                if (asset)
                {
                    scaledSize = new Size(originalOverlay.Width, originalOverlay.Height);
                }
                else
                {
                    scaledSize = moding.Scale;
                }

                Bitmap resized = new Bitmap(originalOverlay, Renderer.Scale(scaledSize,scale));

                overlayImage.Dispose();
                overlayImage = null;
                overlayImage = new Bitmap(resized);
                resized.Dispose();
                //MapPictureBox_MouseMove(sender, e);
            }
        }

        private Bitmap RenderLayer()
        {
            return Renderer.RenderLayers(layers, mapPictureBox.Image.Width, mapPictureBox.Image.Height);
        }

        private void AssetBox_Click(object sender, EventArgs e)
        {
            if (overlayImage != null)
            {
                overlayImage.Dispose();
                overlayImage = null;
                overlayscale = 100;
                if (originalOverlay != null)
                {
                    originalOverlay.Dispose();
                    originalOverlay = null;
                }
            }
            asset = true;
            overlayImage = new Bitmap(assetBox.Image);
            mapPictureBox.Cursor = Cursors.Cross;
            edittingImage = true;
        }

        private void ShowCombinedImage()
        {
            if (renderImage == null && overlayImage == null)
            {
                return;
            }

            if (combinedImage != null)
            {
                combinedImage.Dispose();
                combinedImage = null;
            }

            combinedImage = new Bitmap(renderImage);
            //if (!asset)
            //{
            //    moding.Location = overlayLocation;
            //    moding.shouldrend = true;
            //}

            using (Graphics combiner = Graphics.FromImage(combinedImage))
            {
                combiner.DrawImage(overlayImage, overlayLocation);
            }

            //if (!asset)
            //{
            //    moding.shouldrend = false;
            //}
            mapPictureBox.Image = combinedImage;

        }

        private void MapPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (overlayImage == null)
            {
                return;
            }
            int x = (int)(e.X * scalex);
            int y = (int)(e.Y * scaley);
            overlayLocation = new Point(x - overlayImage.Width / 2, y - overlayImage.Height / 2);
            ShowCombinedImage();
        }

        private void MapPictureBox_Click(object sender, EventArgs e)
        {
            if (overlayImage == null)
            {
                return;
            }
            if (originalOverlay != null)
            {
                if (asset)
                {
                    layers.Add(new Layer() { current = new Bitmap(originalOverlay), Scale = Renderer.Scale(originalOverlay.Size, overlayscale*.01), Location = overlayLocation, FileName = "" });
                    asset = false;
                }
                else
                {
                    if (!moding.Equals(layers.First()))
                    {
                        moding.Location = overlayLocation;
                    }
                    moding.Scale = Renderer.Scale(moding.Scale, overlayscale*.01);
                    moding.shouldrend = true;
                }

                overlayscale = 100;
                originalOverlay.Dispose();
                originalOverlay = null;
            }
            else
            {
                if (asset)
                {
                    layers.Add(new Layer() { current = new Bitmap(overlayImage),Scale=Renderer.Scale(overlayImage.Size,1), Location = overlayLocation, FileName = "" });
                    asset = false;
                }
                else
                {
                    if (!moding.Equals(layers.First()))
                    {
                        moding.Location = overlayLocation;
                    }
                    moding.shouldrend = true;
                }
            }
            overlayImage.Dispose();
            overlayImage = null;
            overlayLocation = new Point(0, 0);

            mapPictureBox.Cursor = Cursors.Default;
            renderImage.Dispose();
            renderImage = new Bitmap(RenderLayer());
            mapPictureBox.Image = renderImage;
            edittingImage = false;
        }

        private void MapPictureBox_Resize(object sender, EventArgs e)
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

        private void Layerspic_Click(object sender, EventArgs e)
        {
            asset = false;
            if (overlayImage != null)
            {
                overlayImage.Dispose();
                overlayImage = null;
                originalOverlay?.Dispose();
                originalOverlay = null;
            }
            moding = layers.ElementAt(LayerList.SelectedIndex);
            moding.shouldrend = false;
            renderImage = RenderLayer();
            overlayscale = 100;
            overlayImage = new Bitmap(Layerspic.Image,moding.Scale);
            mapPictureBox.Cursor = Cursors.Cross;
            edittingImage = true;
        }
    }
}
