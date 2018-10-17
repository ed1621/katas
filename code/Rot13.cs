using System;
using System.Collections.Generic;

namespace code
{
    public class Rot13
    {
        public static string ExecuteRot13(string message)
        {
            var characters = message.ToCharArray();
            var finalWord = new List<char>();

            foreach (var letter in characters)
            {
                int letterNumber = (int)letter;

                if (letterNumber >= 65 && letterNumber <= 90) // uppercase letters
                {
                    finalWord.Add(GoToChar(letter, 90));
                }
                else if (letterNumber >= 97 && letterNumber <= 122) // lowercase letters
                {
                    finalWord.Add(GoToChar(letter, 122)); 
                }
                else
                {
                    finalWord.Add((char)letter);
                }
            }
            return new string(finalWord.ToArray());
        }

        private static char GoToChar(char letter, int max)
        {
            var nextLetterNumber = (((int)letter) + 13);
            if (nextLetterNumber > max)
            {
                nextLetterNumber -= 26; 
            }       
            return (char)nextLetterNumber;
        }
    }
}
