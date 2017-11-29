using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpQuiz
{
    class Program
    {

        static void Main(string[] args)
        {
            string dupString = "mississippi river";
            Console.WriteLine(removeDups(dupString));
            Console.Read();
        }

        static string removeDups(string str)
        {
            str.ToCharArray();
            List<char> charsToRemove = new List<char>();
            string noDupStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (noDupStr.Contains(str[i])){
                    charsToRemove.Add(str[i]);
                }
                else
                {
                    noDupStr = noDupStr + str[i];
                }
            }

            foreach (var c in charsToRemove)
            {
                noDupStr = noDupStr.Replace(c, ' ');
            }
            return noDupStr;
        }
    }
}
