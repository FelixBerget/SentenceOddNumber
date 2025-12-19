namespace SentenceOddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SentenceDivider sentencedivider = new SentenceDivider();
            string[] sentenceString = sentencedivider.SplitSentence("Hey my name is Bobb");

            foreach (var strPart in sentenceString)
            {
                Console.WriteLine(strPart);
            }
        }
    }
}
