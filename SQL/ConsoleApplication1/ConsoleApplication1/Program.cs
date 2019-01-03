#define CompanyA
#define CompanyB
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
#if CompanyA
            Console.WriteLine("This is CompanyA cofiguration");
#endif
            
#if CompanyB
            Console.WriteLine("This is CompanyB cofiguration");
#endif
            Console.Read();
        }
    }
}
