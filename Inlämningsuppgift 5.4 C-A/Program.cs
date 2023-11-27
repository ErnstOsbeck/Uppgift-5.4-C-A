using System;

namespace uppgift_5._4
{
    class program
    {
        static void Main(string[] args)
        {
            string[] namn = { "Ernst", "Alexander", "Johan", "RObin", "Zache" };
            Array.Sort(namn);
            Console.WriteLine(namn[0]);
            Console.Read();
        }
    }
}

