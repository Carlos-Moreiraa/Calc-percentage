using System;
using System.Globalization;
using Calculadora_13_Salario.Entities;

namespace Calculadora_13_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();           
            CultureInfo CI = CultureInfo.InvariantCulture; 
            Console.WriteLine("Olá, este é a calculadora de porcentagem");
            Console.WriteLine("Vamos começar?");
            Console.Write("Digite quanto quer calcular: ");
            double calc = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a porcentagem: ");
            double portion = double.Parse(Console.ReadLine(), CI);            
            double cot = Calculation.SalaryDivisor(calc, portion);
            Console.WriteLine("O valor da porcentagem é " + cot);
            








        }
    }
}
