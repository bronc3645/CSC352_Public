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

        [Test]
        public void GenerateGrid()
        {
            Bitmap paper = new Bitmap(1001, 1001);
            using (Graphics g = Graphics.FromImage(paper))
            {
                for(int i = 0; i <= 1000; i += 10)
                {
                    g.DrawLine(new Pen(Color.Black), new Point(i, 0), new Point(i, 1000));
                    g.DrawLine(new Pen(Color.Black), new Point(0, i), new Point(1000, i));
                }
            }
            string savePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Grid.bmp");
            paper.Save(savePath);
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
                    new Layer(@"C:\Users\kingd\Documents\GitHub\CSC352_Public\MapManager.UnitTests\bin\Debug\Grid.bmp"),
                    new Layer(@"C:\Users\kingd\Documents\GitHub\CSC352_Public\MapManager\Assets\Agents\Controllers\Omen_artwork.png")
                    {
                        Location = new Point(206, 24)
                    }
                },
                1001,
                1001
                ).SetName("CenteredImage");
        }
    }
}
