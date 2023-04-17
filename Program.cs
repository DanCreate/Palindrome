using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Leetcode
{
    class Program
    {

        static void Main(string[] args)
        {
            var wor = "";

            Console.WriteLine("Enter a word: ");
            wor = Console.ReadLine();

            while (wor != "exit")
            {
                var palin = Verification(wor);
                var len = Countwords(wor);

                string result = IsPalindrome(palin, len);
                Console.WriteLine(result);
                Console.WriteLine("Enter a word: ");
                wor = Console.ReadLine();
            }

        }

        public static bool Verification(string wor)
        {
            string sentence = wor;
            var removecharacters = Regex.Replace(sentence, "[^a-zA-Z]+", "");
            char[] charArr = removecharacters.ToCharArray();
            Array.Reverse(charArr);
            string charsStr = new string(charArr);
            if (removecharacters.Equals(charsStr, StringComparison.OrdinalIgnoreCase))
            {

                bool verdadero = true;
                return verdadero;
            }
            else
            {

                bool falso = false;
                return falso;


            }

        }

        public static int Countwords(string wor)
        {
            var conteo = wor.Length;


            return conteo;


        }
        public static string IsPalindrome(bool palin, int len)
        {
            var resultado = $"Is the word a Palindrome? {palin}, Length: {len}";
            return resultado;

        }
    }
}
