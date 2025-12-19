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
            string[] sentenceArray = new string[sentence.Length/2];
            for (int i = 0; i < sentence.Length; i += 2)
            {
                string part1 = sentence[i].ToString();
                string part2 = sentence[i + 1].ToString();
                sentenceArray[i/2] = part1 + part2 + "";
            }
            return sentenceArray;
        }
    }
}
