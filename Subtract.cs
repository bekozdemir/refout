using System;
using System.Collections.Generic;
using System.Text;

namespace refout
{
    class Subtract
    {
        public void subtract(ref int n1, int n2) 
        {
            n1 = 40;
            int result = n1 - n2;
            Console.WriteLine("result : " + result);
        }


        public void subtract2(out int n3, int n2)
        {
            n3 = 100;
            int result2 = n3 - n2;
            Console.WriteLine("result2 : " + result2);
        }
    }
}
