namespace Acronym
{
    using System;
    using System.Text;

    public static class Acronym
    {
        public static string Abbreviate(string phrase)
        {
            StringBuilder sb = new StringBuilder();
            char[] delimiters = new char[] { ' ', '-','_' };
            String[] splitphrase = phrase.Split(delimiters,StringSplitOptions.RemoveEmptyEntries);

            foreach(String subphrase in splitphrase)
            {
                    char firstchar = subphrase[0];
                    sb.Append(firstchar);
            }

            return sb.ToString().ToUpper();
        }
    }
}
