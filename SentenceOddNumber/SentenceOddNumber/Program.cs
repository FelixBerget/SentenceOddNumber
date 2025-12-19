namespace SentenceOddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SentenceDivider sentencedivider = new SentenceDivider();
            string[] sentenceString = sentencedivider.SplitSentence("John is Here");
            Console.WriteLine(sentenceString[0]);
            Console.WriteLine(sentenceString[1]);
            Console.WriteLine(sentenceString[2]);

        }
    }
}
