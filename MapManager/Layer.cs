using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapManager
{
    class Layer
    {
        public Bitmap current { get; set; }
        
        public Point Location { get; set; }
        
        public string FileName { get; set; }

    }
}
