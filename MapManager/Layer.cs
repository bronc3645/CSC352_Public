using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapManager
{
    public class Layer
    {
        public Layer()
        {
            Name = Guid.NewGuid().ToString("D");
        }

        public Layer(string filePath)
        {
            Name = Guid.NewGuid().ToString("D");
            current = new Bitmap(filePath);
            FileName = filePath;
            Location = new Point(0, 0);
        }

        public Bitmap current { get; set; }
        
        public Point Location { get; set; }
        
        public string FileName { get; set; }

        public string Name { get; set; }

    }
}
