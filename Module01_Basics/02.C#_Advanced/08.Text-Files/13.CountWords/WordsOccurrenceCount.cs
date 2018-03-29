using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text.RegularExpressions;

namespace CountWords
{
    public class WordsOccurrenceCount
    {
        public static void Main()
        {
            try
            {
                StreamReader readWords = new StreamReader("words.txt");
                Dictionary<string, int> wordsCounter = new Dictionary<string, int>();

                using (readWords)
                {
                    string allWords = readWords.ReadToEnd();
                    string[] splitedWords = allWords.Split(new char[] { ' ', '\n', '\t' }, 
                        StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in splitedWords)
                    {
                        wordsCounter.Add(word.ToLower(), 0);
                    }
                }

                StreamReader readText = new StreamReader("test.txt");
                string text = string.Empty;

                using (readText)
                {
                    text = readText.ReadToEnd();
                }

                MatchCollection matches = Regex.Matches(text, @"\b\w*\b");

                foreach (var word in matches)
                {
                    string key = word.ToString().ToLower();
                    if (wordsCounter.ContainsKey(key))
                    {
                        wordsCounter[key]++;
                    }
                }

                var sortByValueDesc = wordsCounter.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                StreamWriter resultText = new StreamWriter("result.txt");

                using (resultText)
                {
                    foreach (KeyValuePair<string, int> pair in sortByValueDesc)
                    {
                        resultText.WriteLine("{0}: {1}", pair.Key, pair.Value);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine(" The specified path, file name, or both exceed\n the system-defined maximum length." +
                    "Path must be\n less than 248 characters, and file names\n must be less than 260 characters.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("UnauthorizedAccesException detected! The reasons may be the following:\n" +
                    " - Path specified a file that is read-only.\n - This operation is not supported on the current platform.\n" +
                    " - The caller does not have the required permission.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("Sorry, but you does not have the required permission.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O (Input/Output) error occurred while opening the file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
