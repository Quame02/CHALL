// See https://aka.ms/new-console-template for more information
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Code_Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Split splitObj = new Split();
            splitObj.subStringA();
            Console.WriteLine(splitObj._tt());
            splitObj._subStringA();
            splitObj._subStringB();
        }
    }
}