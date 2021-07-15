using System;

namespace OOPExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //var comp = new Desktop("Generic Computer", Desktop.CaseType.Tower);
            var comp = new Laptop("Generc laptop", 1024, 768);
            Console.WriteLine("Computer type: " + comp.name);
            //Console.WriteLine("Computer Case Type: " + comp.caseType);
            Console.WriteLine(comp.GetType());

            comp.TogglePower();
            Console.WriteLine("The computer is on - " + comp.isOn);

            comp.ToggleSleep();
            Console.WriteLine("The computer is on - " + comp.isOn);
            
            comp.TogglePower();
            Console.WriteLine("The computer is sleeping - " + comp.isSleeping);

            Console.ReadLine();
        }
    }
}
