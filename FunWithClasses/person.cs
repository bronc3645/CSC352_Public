using System;
using System.Text;

namespace FunWithClasses
{
    public class person
    {
        private string nFirstname;
        public String firstname
        {
            get
            {
                return this.nFirstname;
            }

            set
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(value);
                sb[0] = char.ToUpper(value[0]);

                /*for(int i = 0; i < value.Length; i++)
                {
                    if (i == 0)
                    {
                        sb.Append(char.ToUpper(value[i]));
                    }
                    else
                    {
                        sb.Append(value[i]);
                    }
                }*/

                this.nFirstname = sb.ToString();
            }
        }
        public string Lastname
        {
            set;
            get;
        }
        public DateTime birthdate
        {
            get;
            set;
        }
        public override int GetHashCode()
        {
            return this.firstname.GetHashCode() + this.Lastname.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool isEqual = false;
            person other = obj as person;
            if (other == null)
            {
                isEqual = false;
            }
            else
            {
                if (this.GetHashCode() == other.GetHashCode())
                {
                    if (this.firstname==other.firstname && this.Lastname==other.Lastname && this.birthdate == other.birthdate)
                    {
                        isEqual = true;
                    }
                    else
                    {
                        isEqual = false;
                    }
                }
                else
                {
                    isEqual = false;
                }
            }
            return isEqual;
        }
    }
}
