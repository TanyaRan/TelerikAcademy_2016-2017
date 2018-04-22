using System;

namespace VersionAttributeTask
{
    [Version("2.11")]
    public class VersionAttributeStartup
    {
        public static void Main(string[] args)
        {
            object[] versionAttributes = typeof(VersionAttributeStartup).GetCustomAttributes(typeof(VersionAttribute), false);

            Console.WriteLine("Version: {0}", versionAttributes[0]);
        }
    }
}
