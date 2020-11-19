using System;
using System.IO;

namespace MapManager
{
    public class Asset : IEquatable<Asset>
    {
        public Asset(string filePath)
        {
            this.FilePath = filePath;
            Name = Path.GetFileNameWithoutExtension(filePath);
            
        }
        public string Name { get; set; }

        public string FilePath { get; set; }

        public override int GetHashCode()
        {
            return FilePath.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj as Asset);
        }

        public bool Equals(Asset other)
        {
            bool isEqual = false;
            if (other == null)
            {
                isEqual = false;
            }
            else if (other.GetHashCode() == GetHashCode())
            {
                if (other.FilePath.Equals(FilePath)&&other.Name.Equals(Name))
                {
                    isEqual = true;
                }
            }

            return isEqual;
        }

        public override string ToString()
        {
            return FilePath;
        }
    }
}
