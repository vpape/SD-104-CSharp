using System;

namespace PalindromeValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            //takes user input
            // loops through each letter
            // checks if backwards position letter is the same as current position letter
            // if loop finishes, then you have a palindrome
            // if a letter is different, then it is not a palindrome, HINT: Use a bool!!!

            Console.WriteLine("Please enter a word: ");
            
            string word = Console.ReadLine().ToLower();
            bool isPalindrome = true;

            for (int count = 0; count < word.Length; count++)
            {
                if(word[count] != word[word.Length -1-count])
                {
                    isPalindrome = false;
                }

            }
            
            if (isPalindrome == false)
            {
                Console.WriteLine("This word is not a palindrome.");
            }
            else
            {
                Console.WriteLine("This word is a palindrome.");
            }
            Console.Read();
        }

    }
}
