using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputationComparisionProblem 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation");
            CalculateLength calculateLength = new CalculateLength();
            calculateLength.LineComputation();
            
        }
    }
}

