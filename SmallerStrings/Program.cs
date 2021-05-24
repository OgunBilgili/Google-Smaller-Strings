using System;
using System.Collections.Generic;
using System.Linq;
//a b c d e f g h i j k l m n o p q r s t u v w x y z
//result should be smaller than S string
namespace SmallerStrings
{
    class Program
    {
        public static List<string> Strings = new List<string>();
        public static List<string> Palindromes = new List<string>();

        static void Main(string[] args)
        {
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                                        's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            bool flag = true;   //It`s used to check whether expression generator reached the designated string or not, if reached it stops generating
            int testCases, N, K, loopCounterforLenght, additionalCounter;
            string S = string.Empty, C = string.Empty;
            
            testCases = 3;
            N = 2;  //Refers to lenght of given string
            K = 3;  //Refers to Alphabet range
            S = "bc";   //Refers to given string piece   

            for(int x = 0; x < K && flag == true; x++)
            {
                loopCounterforLenght = 1;
                additionalCounter = Strings.Count;
                Strings.Add(letters[x].ToString());
                
                while (loopCounterforLenght < N && flag == true)
                {
                    C = Strings[additionalCounter];

                    if (C.Length < N && C.First() <= S.First())
                    {
                        for (int y = 0; y < K && flag == true; y++)
                        {
                            C = string.Concat(C, letters[y].ToString());
                            Strings.Add(C);

                            if(C.Length == N)
                                CheckPalindrome(C);

                            if (C.Equals(S))
                                flag = false;

                            C = C.Remove(C.Length - 1);

                            if (y == K - 1)
                            {
                                additionalCounter++;
                                if (Strings[additionalCounter].Length == N)
                                    loopCounterforLenght++;
                            }
                        }
                    }
                    else
                    {
                        loopCounterforLenght++;
                    }
                    C = string.Empty;
                }
            }

            foreach(string a in Palindromes)
                Console.WriteLine(a);
        }

        public static void CheckPalindrome(String C)
        {
                string reverseString = string.Empty;
                foreach (char c in C)
                {
                    reverseString = c + reverseString;
                }
                if (reverseString.Equals(C))
                {
                    Palindromes.Add(C);
                } 
        }
    }
}

