using System;

namespace Task2
{
    public class Program
    {
        public static void Main()
        {
            /* input values  */
            Console.WriteLine("Insert values (Example: 10, 5, 3, 4): ");
            string phrase = Console.ReadLine();

            /* variable for split */
            char[] delimiterChars = { ' ', ',' };

            /* variable to save and show the numbers */
            string finalResult = "";

            /* variable to ask if string is empty */
            string emptyString = phrase.Replace(" ", "");

            /* array to save the numbers */
            string[] numbers = phrase.Split(delimiterChars);

            /* if string is not empty */
            if (emptyString != "")
            {
                /* algorithm to swap de position of the values  */
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] != "")
                    {
                        finalResult = finalResult + numbers[numbers.Length - i - 1] + ", ";
                    }
                }
                /* show array result swapped */
                finalResult = finalResult.Remove(finalResult.Length - 2, 2);
                Console.WriteLine(finalResult);
            }
            /* if input is empty */
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
