using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatinatingHelloWord
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";
            object helloWorld = word1 + " " + word2;
            string castingGreedings = (string)helloWorld;

            Console.WriteLine(castingGreedings);
            Console.WriteLine("Printing all variables:\n string word1 == {0}\n string word2 == {1}\n object helloWorld == {2}\n castingGreetings == {3}\n", word1, word2, helloWorld, castingGreedings);
            Console.ReadLine();
        }
    }
}
