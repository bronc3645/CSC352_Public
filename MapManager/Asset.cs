using System;

namespace MapManager
{
    public class Asset : IEquatable<Asset>
    {
        public Asset(string filePath)
        {
            this.filePath = filePath;

            
        }
        public string name { get; set; }

        public string filePath { get; set; }

        public override int GetHashCode()
        {
            return filePath.GetHashCode();
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
                if (other.filePath.Equals(filePath)&&other.name.Equals(name))
                {
                    isEqual = true;
                }
            }

            return isEqual;
        }

        public override string ToString()
        {
            return filePath;
        }
    }
}
