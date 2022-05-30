using System;
using System.Text;

namespace StringBuilders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("hello world");

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new String('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First char " + builder[0]);

        }
    }
}
