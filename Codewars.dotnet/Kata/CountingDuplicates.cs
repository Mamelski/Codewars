using System.Collections.Generic;

namespace Kata
{
    // Write a function that will return the count of distinct case-insensitive alphabetic characters
    // and numeric digits that occur more than once in the input string.
    // The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.
    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            var numberOfCharactersOccuringMoreThanOnce = 0;
            var charactersOccurence = new HashSet<char>();
            var duplicatesCounted = new HashSet<char>();
            
            foreach (var character in str.ToLower())
            {
                if (charactersOccurence.Contains(character))
                {
                    if (!duplicatesCounted.Contains(character))
                    {
                        ++numberOfCharactersOccuringMoreThanOnce;
                        duplicatesCounted.Add(character);
                    }
                }
                else
                {
                    charactersOccurence.Add(character);
                }
            }
            return numberOfCharactersOccuringMoreThanOnce;
        }
    }
}