/* Read a word and write it backwards. 
 * Display the two words on the screen and return if it is a palindrome. 
 * A palindrome is a word or phrase that remains the same when read backwards.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class Palindrome
    {
        public static void Main()
        {
            string word = ""; 
            int attempts = 0; 
            do 
            {
                if (attempts > 0) 
                {
                    Console.WriteLine("The word must not contain numbers or special characters."); 
                } 
                Console.WriteLine("Enter a word to check whether or not it is a palindrome:");
                word = Console.ReadLine().ToUpper();
                attempts++; 
            } while (word.Any(char.IsDigit) || word.Any(char.IsPunctuation)); 
            Console.WriteLine(word);

            string invertedWord = "";
            var wordArray = word.ToCharArray();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(wordArray[i]);
                invertedWord += wordArray[i];
            }
            Console.WriteLine();

            string fullWord = invertedWord.ToString();
            Console.WriteLine(word == fullWord ? $"The word {word} is a palindrome." : $"The word {word} is not a palindrome.");
        }
    }
}
