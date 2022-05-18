using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo
{
    public class FindPowerOfTwo
    {
        public void PowerFinding()
        {
            Console.Write("Enter the power value for finding 2's power :");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("2" + " " + "^" + " " + i + " " + "=" + " " + Math.Pow(2, i));
            }
        }
    }
}