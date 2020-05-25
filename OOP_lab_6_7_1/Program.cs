using System;

namespace OOP_lab_6_7_1
{
    class Program
    {
        private static int n = int.Parse(Console.ReadLine());

        public static Student[] group = new Student[n];

        private static void Main(string[] args)
        {
            Input input = new Input();

            input.Read();
            
            Output output = new Output();

            output.Write();
        }
    }
}
