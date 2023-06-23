using System.Security.Cryptography;

namespace _1._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfWords = Console.ReadLine()
                .Split()
                .ToArray();

            
            Random random = new Random();
            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                string temp = arrayOfWords[i];
                int randomIndex = random.Next(0, arrayOfWords.Length);
                string randomIndexValue = arrayOfWords[randomIndex];

                arrayOfWords[i] = randomIndexValue;
                arrayOfWords[randomIndex] = temp;
            }
            foreach (string word in arrayOfWords)
            {
            Console.WriteLine(word);
            }
        }
    }
}