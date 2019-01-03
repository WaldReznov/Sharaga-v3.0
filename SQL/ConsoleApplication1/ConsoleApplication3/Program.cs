using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
#if EXPERIMENTAL
            Console.WriteLine("Компилируется для экспериментальной версии."):
#elif RElease
            Console.WriteLine("Компилируется для окончательной версии.");
#else
            Console.WriteLine("Компилируется для внутреннего тестирования.");
#endif
#if TRIAL && !RELEASE
            Console.WriteLine("Пробная версия.");
#endif
            Console.WriteLine("Присутствует во всех версиях.");
        }
    }
}