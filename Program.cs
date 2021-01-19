using System;

namespace refout
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 200;
            int n2 = 10;

            Subtract subt = new Subtract();
            subt.subtract(ref n1,n2);

            Subtract subt2 = new Subtract();
            subt2.subtract2(out int n3, n2);

        }
    }
}
