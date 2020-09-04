namespace Acronym
{
    using System;
    using System.Text;

    public static class Acronym
    {
        public static string Abbreviate(string phrase)
        {
            StringBuilder sb = new StringBuilder();

            String[] splitphrase = phrase.Split(' ');

            foreach(String subphrase in splitphrase)
            {
                if (subphrase.Length != 0)
                {
                    char firstchar = subphrase[0];

                    if (firstchar == '_')
                    {
                        sb.Append(subphrase[1]);
                    }
                    else if (firstchar != '-')
                    {
                        sb.Append(firstchar);
                    }
                }
            }

            return sb.ToString().ToUpper();
        }
    }
}
