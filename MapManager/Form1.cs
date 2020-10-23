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
        public Form1()
        {
            InitializeComponent();
            assetBox.AllowDrop = true;
            mapPictureBox.AllowDrop = true;
        }

        private void assetBox_DragLeave(object sender, EventArgs e)
        {
            Console.WriteLine("this is a drag leave event");
        }

        private void assetBox_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("this is a drag drop event");
        }

        private void assetBox_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("this is a drag enter event");
        }

        private void assetBox_DragOver(object sender, DragEventArgs e)
        {
            Console.WriteLine("this is a drag over event");
        }
        
        private void assetBox_MouseDown(object sender, MouseEventArgs e)
        {
            assetBox.DoDragDrop(assetBox.Image, DragDropEffects.Copy);
        }

        private void mapPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("this is drag enter even map");
        }

        private void assetBox_Move(object sender, EventArgs e)
        {

        }
    }
}
