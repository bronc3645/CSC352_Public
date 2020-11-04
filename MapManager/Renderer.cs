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
                    combiner.DrawImage(layer.current, layer.Location);
                }
            }

            return render;
        }
    }
}
