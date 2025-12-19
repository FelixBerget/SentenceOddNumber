using System;
using System.Collections.Generic;
using System.Text;

namespace SentenceOddNumber
{
    internal class SentenceDivider
    {
        public SentenceDivider() { }

        public string[] SplitSentence(string sentence)
        {
            string[] sentenceArray;

            if (sentence.Length % 2 == 0)
            {
                sentenceArray = new string[sentence.Length / 2];
            }
            else
            {
                sentenceArray = new string[sentence.Length / 2 + 1];
            }

            for (int i = 0; i < sentence.Length; i += 2)
            {
                string part1 = sentence[i].ToString();

                if (i == sentence.Length - 1)
                {
                    string underscore = "_";
                    sentenceArray[i / 2] = part1 + underscore + "";
                    return sentenceArray;
                }

                string part2 = sentence[i + 1].ToString();
                sentenceArray[i / 2] = part1 + part2 + "";
            }

            return sentenceArray;
        }
    }
}
