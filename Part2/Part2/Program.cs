using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {

            }
            Console.ReadLine();
        }
    }
}
