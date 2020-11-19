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
                    if (layer.shouldrend)
                    {
                        combiner.DrawImage(new Bitmap(layer.current, layer.Scale), layer.Location);
                    }
                }
            }

            return render;
        }
        public static Bitmap RenderUntil(IEnumerable<Layer> layers,int stop, int width,int height)
        {
            Bitmap render = new Bitmap(width, height);

            for(int i = 0; i < layers.Count(); i++)
            {
                if (i== stop)
                {
                    break;
                }
                Layer layer = layers.ElementAt(i);
                using (Graphics combiner = Graphics.FromImage(render))
                {
                    if (layer.shouldrend)
                    {
                        combiner.DrawImage(new Bitmap(layer.current, layer.Scale), layer.Location);
                    }
                }
            }

            return render;
        }
        public static Bitmap RenderLast(IEnumerable<Layer> layers, int start,Bitmap current)
        {
            Bitmap render = new Bitmap(current);

            if (start + 1 != layers.Count())
            {
                for (int i = start + 1; i < layers.Count(); i++)
                {
                    Layer layer = layers.ElementAt(i);
                    using (Graphics combiner = Graphics.FromImage(render))
                    {
                        if (layer.shouldrend)
                        {
                            combiner.DrawImage(new Bitmap(layer.current, layer.Scale), layer.Location);
                        }
                    }
                }
            }
            else
            {
                render.Dispose();
                render = null;
            }

            return render;
        }

        public static Size Scale(Size original,double growpercent)
        {
            int scalewidth = (int)(original.Width * growpercent);
            int scaleheight = (int)(original.Height * growpercent);
            return new Size(scalewidth, scaleheight);
        }
    }
}
