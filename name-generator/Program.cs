using System;

namespace name_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Names.GetRandomMaleName();
            for(int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(x);
            }
            
        }
    }
}
