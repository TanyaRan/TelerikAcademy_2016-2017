using System;

namespace ParseURL
{
    public class ParseAndExtractURL
    {
        static void Main()
        {
            string URL = Console.ReadLine();

            int protocolEnd = URL.IndexOf("://");
            int serverStart = protocolEnd + "://".Length;
            int serverEnd = URL.IndexOf("/", serverStart);

            string protocol = URL.Substring(0, protocolEnd);
            string server = URL.Substring(serverStart, serverEnd - serverStart);
            string resource = URL.Substring(serverEnd);

            Console.WriteLine($"[protokol] = {protocol}\n[server] = {server}\n[resource] = {resource}");
        }
    }
}
