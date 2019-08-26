using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string html_code = "", space;


            Console.WriteLine("Introduce el codigo HTML");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ok -> to EXIT");
            Console.ForegroundColor = ConsoleColor.Yellow;

            space = LookupHtml(ref html_code);

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Output del codigo HTML");
            Console.WriteLine(ConverterToHtmlEncode(html_code));

            Console.ReadLine();
        }

        private static string LookupHtml(ref string html_code)
        {
            string space;
            do
            {
                space = Console.ReadLine();
                html_code += space;
            } while (space != "ok.");
            return space;
        }

        public static string ConverterToHtmlEncode(string html_code)
        {
            string html_encode = "";

            html_encode = html_code
                .Trim()
                .Replace("\\","\\\\")
                .Replace("        ", "")
                .Replace("  ","")
                .Replace("\"", "\\\"")
                .Replace(" <", "<")
                .Replace("< ", "<")
                .Replace(" >", ">")
                .Replace("> ", ">")
                .Replace("ok.", "")
                .Trim().Trim().Trim();
            Console.ForegroundColor = ConsoleColor.Green;

            return html_encode;
        }
    }
}

