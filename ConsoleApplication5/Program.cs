using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            String content = "abcd";
            content = content + "wxyz";

            Console.WriteLine(content);

            StringBuilder content2 = new StringBuilder("abcd");

            content2 = content2.Append("wxyz");

            Console.WriteLine(content2);

            Console.ReadLine();

        }

    }
}