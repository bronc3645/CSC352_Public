using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapManager
{
    public class Layer
    {
        public Layer()
        {
            shouldrend = true;
        }

        public Layer(string filePath)
        {
            Name = Path.GetFileNameWithoutExtension(filePath);
            current = new Bitmap(filePath);
            FileName = filePath;
            Location = new Point(0, 0);
        }

        public Bitmap current { get; set; }
        
        public Point Location { get; set; }
        
        public string FileName { get; set; }

        public string Name { get; set; }

        public Size Scale { get; set; }

        public bool shouldrend { get; set; }

    }
}
