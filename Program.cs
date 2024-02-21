using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tính tổng các phần tử trong array
            int[] numb = new int[5];
            for (int i = 0; i < numb.Length; i++)
            {
                Console.Write("Input number: ");
                numb[i] = int.Parse(Console.ReadLine()) ;
            }
            

            int sum = 0;
            for (int j = 0;j < numb.Length;j++)
            {
                sum += numb[j] ;
            }
            Console.WriteLine(sum);
        }
    }
}
