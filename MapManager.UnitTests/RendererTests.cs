namespace MapManager.UnitTests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using NUnit.Framework;

    [TestFixture]
    public class RendererTests
    {
        [TestCaseSource(typeof(RenderLayer_ValidArguments_Tests))]
        public void RenderLayers_ValidArguments(IEnumerable<Layer> layers, int width, int height)
        {
            Bitmap render = Renderer.RenderLayers(layers, width, height);
            string bitmapPath = Path.Combine(TestContext.CurrentContext.TestDirectory, $"{TestContext.CurrentContext.Test.Name}.bmp");
            render.Save(bitmapPath);
        }
    }

    internal class RenderLayer_ValidArguments_Tests : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new TestCaseData
                (
                new Layer[]
                {
                    new Layer(@"C:\Users\kingd\Documents\GitHub\CSC352_Public\MapManager\Assets\JPG Maps\ascent_callouts.jpg"),
                    new Layer(@"C:\Users\kingd\Documents\GitHub\CSC352_Public\MapManager\Assets\Agents\Controllers\Omen_artwork.png")
                    {
                        Location = new Point(206, 77)
                    }
                },
                1000,
                1054
                ).SetName("CenteredImage");
        }
    }
}
