using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZaitsevMS.Sprint0.Task6.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма эл. = " + DataService.AdditionArray(numsArray)); 
            Console.WriteLine("Разность эл. = " + DataService.SubstractArray(numsArray));
            Console.WriteLine("Произведение эл. = " + DataService.MultArray(numsArray));
            Console.ReadKey();
        }
    }
}
