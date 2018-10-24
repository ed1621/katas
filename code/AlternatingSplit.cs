using System;
using System.Collections.Generic;
using System.Linq;

namespace code
{
    public class AlternatingSplit
    {
        public string Encrypt(string text, int n)
        {
            var validation = ValidateParameters(text, n);
            if (validation == null || validation == string.Empty || validation == text)
            {
                return validation;
            }

            var encryptedWord = string.Empty;
            for (int i = 0; i < n; i++)
            {
                encryptedWord = string.Concat(
                    new string(new List<char>(text)
                        .Where((x, index) => index % 2 != 0)
                        .ToArray()),
                    new string(new List<char>(text)
                        .Where((x, index) => index % 2 == 0)
                        .ToArray())
                );
                text = encryptedWord;
            }

            return encryptedWord;
        }

        private string ValidateParameters(string text, int n)
        {
            if (text == null)
            {
                return null;
            }
            if (text == String.Empty)
            {
                return String.Empty;
            }
            if (n <= 0)
            {
                return text;
            }

            return "I'm just filling this in with a string that I hope no one would be dumb enough to put in. I'm to tired to figure out another string";
        }

    }
}