using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapManager
{
    public class AssetFactory
    {
        ///<summary>
        ///Given a Directory of asset files, construct an enumerable that represents the asset
        /// </summary>
        /// <param name="assetDirectory">
        /// the root directory to search for assets.
        /// </param>
        /// <returns>and IEnemerable of <see cref="Asset"/></returns>
        
        public static IEnumerable<Asset>Construct(string assetDirectory)
        {
            IList<Asset> assets = new List<Asset>();
            var allAssetPaths = Directory.EnumerateFiles(assetDirectory, "*.png", SearchOption.AllDirectories);

            foreach (var assetPath in allAssetPaths)
            {
                assets.Add(new Asset(assetPath));
            }

            return assets;
        }
        public static IEnumerable<Asset> Constructpath(string assetDirectory)
        {
            IList<Asset> assets = new List<Asset>();
            var allAssetPaths = Directory.EnumerateDirectories(assetDirectory);

            foreach (var assetPath in allAssetPaths)
            {
                assets.Add(new Asset(assetPath));
            }

            return assets;
        }
    }
}
