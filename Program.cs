using System.Text.RegularExpressions;

namespace regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Some text with IP addresses like 192.168.1.1, 10.0.0.1, and 172.16.254.1.";
            
            string pattern = @"\b(?:\d{1,3}\.){3}\d{1,3}\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            Console.WriteLine("Found IP addresses:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
