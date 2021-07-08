using System;

namespace OOPExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var comp = new Computer();
            comp.name = "Generic Computer";
            Console.WriteLine(comp.name);
            Console.ReadLine();
        }
    }
}
