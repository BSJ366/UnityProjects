using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;

namespace _0513_CSharp
{
    internal class Program
    {
       private static double GetDiscountRate(object client)
        {
            

          switch (client)
            {
                case ("학생", int n):
                    {
                        if (n < 18)
                            return 0.2;
                        else
                            return 0.1;
                    }
                case ("일반", int n):
                    {
                        if (n < 18)
                            return 0.1;
                        else
                            return 0.05;
                    }
                case (_):
                    return 0;
            }
            
        }
        
        static void Main(string[] args)
        {
            var a = ("바보", 2 );
            Console.WriteLine($"{GetDiscountRate(a)}");
        }
    }
}
