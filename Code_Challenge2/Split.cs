using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_Challenge2
{
    public class Split
    {
        public string result {get; set;}
        public string splitA {get; set;}
        public string splitB {get; set;}
        public void subStringA()
        {
            Console.WriteLine("Hello Welcome! This code is for string manipulation...And its open to new ideas.\n*******");
        }

        public string _tt()
        {
            Menu.main_Menu();
            string phrase = Console.ReadLine();
            Console.Clear();

            if (phrase.Length < 10)
            {
                Split mySplit = new Split();
                mySplit._tt();
            }
            else
            {
                string[] words = phrase.Split(" ");
                foreach (var item in words)
                {
                    result += item;
                }
            }
            return result;
        }

        public void _subStringA()
        {
            try
            {
                Console.Write("\nEven index of substring A :");

                for (int i = 0; i < result.Length/2; i++)
                {
                    if (i%2==0)
                    {
                        splitA = ($"{result[i]}");
                        Console.Write($"{splitA}");
                    }
                }
            
                Console.Write("\nEven index of substring B :");
                for (int i = ((result.Length)/2); i < result.Length; i++)
                {
                    if (i%2==0)
                    {
                        splitB = ($"{result[i]}");
                        Console.Write($"{splitB}");
                    }
                }
                Console.Write($"\nSUBSTRING A: {splitA}{splitB}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void _subStringB()
        {
            try
            {
                Console.Write("\nOdd index of substring A :");

                for (int i = 0; i < result.Length/2; i++)
                {
                    if (i%2!=0)
                    {
                        splitA = ($"{result[i]}");
                        Console.Write($"{splitA}");
                    }
                }

                Console.Write("\nOdd index of substring B :");
                for (int i = ((result.Length)/2); i < result.Length; i++)
                {
                    if (i%2!=0)
                    {
                        splitB = ($"{result[i]}");
                        Console.Write($"{splitB}");
                    }
                }
                Console.Write("\nSUBSTRING B:" +splitA +splitB);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}