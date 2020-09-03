using System;

namespace palindromeRearranging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string inputString = Console.ReadLine();
            if (palindromeRearranging(inputString))
            {
                Console.WriteLine("The word is Palindrome Rearranging!");
            }
            else
            {
                Console.WriteLine("The word is NOT Palindrome Rearranging!");
            }
            Console.ReadLine();
        }
        static bool palindromeRearranging(string inputString)
        {
            bool isPalindrome = true;
            string ch = "";
            int num = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                int count = 1;
                for (int j = 0; j < inputString.Length; j++)
                {
                    if(i != j)
                    {
                        if(inputString[i] == inputString[j])
                        {
                            count++;
                        }
                    }
                }
                if(count % 2 == 0)
                {
                    continue;
                }
                else
                {
                    num++;
                    if (num == 1)
                    {
                        ch += inputString[i];
                    }
                    else
                    {
                        if (ch[0] != inputString[i])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }
                }
            }
            return isPalindrome;
        }

    }
}
