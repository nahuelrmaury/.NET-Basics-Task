using System;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            /* input phrase  */
            Console.WriteLine("Insert phrase: ");
            string phrase = Console.ReadLine();

            /* variable for split */
            char[] delimiterChars = { ' ', ',' };

            /* variable to show in console the final result with the original words respecting capital letters */
            string[] originalWords = phrase.Replace(".", "").Split(delimiterChars);

            /* modified original phrase to ignore letter case and hyphens */
            string phraseReplaced = phrase.ToLower().Replace("-", "");

            /* phrase splited and saved in array words */
            string[] words = phraseReplaced.Split(delimiterChars);

            /* initialize string variable to add each word and show final result in console */
            string finalResult = "";

            /* flag to correct functionality of algorithm */
            bool flag;

            /* variable to measure length of each word */
            int length;

            /* variable to index and show correctly in console the words */
            int j = 0;

            /* if phrase is not empty */
            if (phrase != "")
            {
                /* algorithm */
                foreach (var word in words)
                {
                    length = word.Length;
                    flag = true;

                    /* this if is in case that there are some white spaces */
                    if (length != 0)
                    {
                        /* this if is in case the input is one character */
                        if (length == 1)
                        {
                            finalResult += $"{word} – palindrome, ";
                            flag = false;
                        }
                        /* this algorithm check if the word is not palindrome */
                        for (int i = 0; i < length / 2; i++)
                        {
                            if (word[i] != word[length - i - 1])
                            {
                                finalResult = finalResult + $"{originalWords[j]} – not palindrome, ";
                                flag = false;
                                break;
                            }
                        }
                        /* if word is not just one character and also, is not palindrome */
                        if (flag)
                        {
                            finalResult = finalResult + $"{originalWords[j]} - palindrome, ";
                        }
                        j++;
                    }
                    else
                    {
                        j++;
                    }
                }
                /* this serves to remove the last ', ' of the string */
                finalResult = finalResult.Remove(finalResult.Length - 2, 2);

                /* show final result */
                Console.WriteLine(finalResult + ".");
            }
            /* if phrase is empty */
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
