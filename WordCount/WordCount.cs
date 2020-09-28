// <copyright file="UnitTests.cs" company="Ace Olszowka">
// Copyright (c) 2020 Ace Olszowka.
// </copyright>

namespace WordCount
{
    using System;
    using System.Collections.Generic;

    public static class WordCount
    {
        public static IDictionary<string, int> CountWords(string phrase)
        {
            IDictionary<string, int> result = new Dictionary<string, int>();

            phrase = phrase.ToLower();

            string[] split = phrase.Split(new string[] { " ", "," , "\n","_"}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < split.Length; i++)
            {
                split[i] = sanitizePhrase(split[i]);
                if (split[i] != "")
                {
                    if (result.ContainsKey(split[i]))
                    {
                        result[split[i]] = result[split[i]] + 1;
                    }
                    else
                    {
                        result[split[i]] = 1;
                    }
                }
            }
            return result;
        }

        private static string sanitizePhrase(string input)
        {
            string[] forbiddenCharacters =
            {
                ":",
                "!",
                "@",
                "#",
                "$",
                "%",
                "^",
                "&",
                "*",
                "(",
                ")",
                "?",
                "-",
                "=",
                "+",
                "/",
                "\\",
                "."
            };
            foreach (string forbiddenchar in forbiddenCharacters)
            {
                input = input.Replace(forbiddenchar, string.Empty);
            }
            if (input.IndexOf("'") != input.LastIndexOf("'"))
            {
                while (input.Contains("'"))
                {
                    input=input.Replace("'", string.Empty);
                }
            }
            return input;
        }
    }
}
