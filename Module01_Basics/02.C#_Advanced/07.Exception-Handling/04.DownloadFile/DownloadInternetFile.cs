using System;
using System.Net;

namespace DownloadFile
{
    public class DownloadInternetFile
    {
        public static void Main()
        {
            Console.Write("Please enter file URL address: ");
            string addressURL = Console.ReadLine();

            Console.Write("Please enter file name: ");
            string file = Console.ReadLine();

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFile(addressURL, file);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The address can not be null or invalid input!");
                }
                catch (WebException)
                {
                    Console.WriteLine("Invalid address or empty file!");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("This method does not support simultaneous downloads!");
                }
            }
        }

        //URL -> http://telerikacademy.com/Content/Images/news-img01.png
        //file name -> ../../news-img01.png 
    }
}
