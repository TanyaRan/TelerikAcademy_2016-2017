using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

namespace RemoveWords
{
    public class RemoveListedWordsHandleAllExceptions
    {
        public static void Main()
        {
            try
            {
                StreamReader readWords = new StreamReader("wordsToRemove.txt");
                List<string> words = new List<string>();

                using (readWords)
                {
                    string line = readWords.ReadLine();
                    while (line != null)
                    {
                        words.Add(line.Trim());
                        line = readWords.ReadLine();
                    }
                }

                StreamReader readText = new StreamReader("text.txt");
                StreamWriter resultText = new StreamWriter("result.txt");

                using (readText)
                {
                    using (resultText)
                    {
                        string line = readText.ReadLine();
                        while (line != null)
                        {
                            foreach (var word in words)
                            {
                                line = Regex.Replace(line, word, "",
                                    RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
                            }
                            resultText.WriteLine(line);
                            line = readText.ReadLine();
                        }
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
