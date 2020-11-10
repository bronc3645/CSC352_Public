using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapManager
{
    public class Renderer
    {
        public static Bitmap RenderLayers(IEnumerable<Layer> layers, int width, int height)
        {
            // This is the base layer on top of which all images will be rendered
            Bitmap render = new Bitmap(width, height);

            foreach (Layer layer in layers)
            {
                using (Graphics combiner = Graphics.FromImage(render))
                {
                    double scale = layer.Scale * .1;
                    Size scaledSize = new Size((int)(layer.current.Width * scale), (int)(layer.current.Height * scale));
                    combiner.DrawImage(new Bitmap(layer.current,scaledSize), layer.Location);
                }
            }

            return render;
        }
    }
}
