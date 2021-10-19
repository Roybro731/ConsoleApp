using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1(1, "class");

            Record1 record1 = new Record1(2, "record");

            Console.WriteLine($"Class => {class1.Id}-{class1.Name}");
            Console.WriteLine($"Record => {record1.Id}-{record1.Name}");

            //record1.Name = "et";

        }
    }
}
