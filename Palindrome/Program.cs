using System;
namespace PALINDROME
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
            string word, reverse = "";
            word = Convert.ToString(Console.ReadLine());
            Console.WriteLine("The string is:" + word);
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }
            if (reverse == word)
            {
                Console.WriteLine("The given string {0} is Palindrome", reverse);
            }
            else
            {
                Console.WriteLine("The given string word is not Palindrome", reverse);
            }
            Console.ReadLine();
        }
    }
}