using System;

namespace Boolean8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite dva tselikh chisel!");
            Console.Write("A= ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B= ");
            int B = Convert.ToInt32(Console.ReadLine());
            bool result = A % 2 !=0 && B % 2 !=0 ? true : false;
            Console.WriteLine($"Kazhdoe iz chisel {A} i {B} nechetnoe = {result}"); 
        }
    }
}