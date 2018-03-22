using System;
using System.Collections.Generic;

namespace _14.WordDictionary
{
    public class SampleWordDictionary
    {
        public static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            const int wordsCount = 5;

            string[] wKeys = new string[wordsCount] { ".NET", "CLR", "namespace", "dictionary", "class" };

            string[] wValues = new string[wordsCount]
                {
                "platform for applications from Microsoft",
                "managed execution environment for .NET",
                "hierarchical organization of classes",
                "represents a collection of keys and values",
                "is a construct that enables you to create your own custom types by grouping together variables of other types, methods and events"
                };

            for (int i = 0; i < wordsCount; i++)
            {
                dictionary.Add(wKeys[i].ToUpper(), wValues[i]);
            }

            Console.Write(".NET, CLR, namespace, dictionary, class -> Enter a word: ");
            string inputWord = Console.ReadLine();

            Console.WriteLine(dictionary[inputWord.ToUpper()]);
        }
    }
}
