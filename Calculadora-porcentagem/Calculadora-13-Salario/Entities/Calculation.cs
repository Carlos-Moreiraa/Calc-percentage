using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_13_Salario.Entities
{
    class Calculation
    {
        public static double Mounth = 12; 
        public static double SalaryDivisor(double calc, double portion)
        {
            calc = calc * (portion / 100);
            return calc;
        }

       
        
    }
}
