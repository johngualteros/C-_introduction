using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_introduction
{
    internal class Method
    {
        static void Saludar()
        {
            Console.WriteLine("Hello World");
        }
        static int Sumar(int number_1,int number_2)
        {
            return number_1 + number_2;
        }
        static int Restar(int num_1,int num_2)=> num_1 - num_2;
        static int Restar(int num_1, int num_2, int num_3 = 0)=>num_1 - num_2 - num_3;
        {
        }
        static double Dividir(double dividendo, double divisor) => dividendo / divisor;
        static void Main(String[] args)
        {
            Saludar();
            Sumar(9,2);
            Dividir(3.6, 50);
        }
    }
}
