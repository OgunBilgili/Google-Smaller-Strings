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
        public static List<int> Nlist = new List<int>();
        public static List<int> Klist = new List<int>();
        public static List<string> Slist = new List<string>();

        static void Main(string[] args)
        {
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                                        's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            bool flag = true;   //It`s used to check whether expression generator reached the designated string or not, if reached it stops generating
            int testCases, loopCounterforLenght, additionalCounter, Parser;
            string C = string.Empty;

            testCases = Int32.Parse(Console.ReadLine());    //Refers to number of test cases
            
            for(int i = 0; i < testCases; i++)
            {
                Parser = Int32.Parse(Console.ReadLine().Replace(" ", ""));
                Nlist.Add(Parser / 10);  //Refers to lenght of given string
                Klist.Add(Parser % 10);  //Refers to Alphabet range
                Slist.Add(Console.ReadLine());   //Refers to given string piece
            }
          
            for (int i = 0; i < testCases; i++)
            {
                for (int x = 0; x < Klist[i] && flag == true; x++)
                {
                    loopCounterforLenght = 1;
                    additionalCounter = Strings.Count;
                    Strings.Add(letters[x].ToString());

                    while (loopCounterforLenght <= Nlist[i] && flag == true)
                    {
                        C = Strings[additionalCounter];

                        if (C.Length == 1 && C.Length == Nlist[i] && C.First() < Slist[i].First())
                            CheckPalindrome(C);

                        if (C.Length < Nlist[i] && C.First() <= Slist[i].First())
                        {
                            for (int y = 0; y < Klist[i] && flag == true; y++)
                            {
                                C = string.Concat(C, letters[y].ToString());
                                Strings.Add(C);

                                if (C.Length == Nlist[i] && !C.Equals(Slist[i]))
                                    CheckPalindrome(C);

                                if (C.Equals(Slist[i]))
                                    flag = false;

                                C = C.Remove(C.Length - 1);

                                if (y == Klist[i] - 1)
                                {
                                    additionalCounter++;
                                    if (Strings[additionalCounter].Length == Nlist[i])
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

                Console.WriteLine("Case #{0}: {1}", i, Palindromes.Count);
                Palindromes.Clear();
                Strings.Clear();
                flag = true;
            }
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

