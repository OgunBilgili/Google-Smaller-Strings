using System;
using System.Collections.Generic;
//a b c d e f g h i j k l m n o p q r s t u v w x y z
//result should be smaller than S string
namespace SmallerStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                                        's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


            Tuple<char[]> tuple = new Tuple<char[]>(letters);

            List<string> Strings = new List<string>();
            
            int stringLenght, alphabetRange, testCases, lenghtofString;
            string S = string.Empty;
            string C = string.Empty;
            testCases = 3;
            stringLenght = 2;
            alphabetRange = 3;
            S = "bc";
            lenghtofString = S.Length;

            int countLoopforLenght = 2;
            int counter = 0;

            for(int x = 0; x < alphabetRange; x++)
            {
                countLoopforLenght = 1;
                Strings.Add(letters[x].ToString());
                
                while (countLoopforLenght <= stringLenght)
                {
                    C = Strings[counter];
                    
                    for(int y = 0; y < alphabetRange; y++)
                    {
                        C = string.Concat(C, letters[y].ToString());
                        Strings.Add(C);
                        C = C.Remove(C.Length - 1);
                        countLoopforLenght++;
                        counter++;
                    }

                    C = string.Empty;
                }
                counter++;
            }

            foreach(string a in Strings)
                Console.WriteLine(a);
        }
    }
}

