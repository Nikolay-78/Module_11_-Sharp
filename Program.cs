using System;

namespace Module_11_СSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Николай";
            byte MyAge = 42;
            bool Pet = true;
            double MyShoeSize = 46;
                        
            Console.WriteLine("Меня зовут " + MyName);
            Console.WriteLine("Мне " + MyAge + " года");
            Console.WriteLine("У меня есть питомец и это " + Pet);
            Console.WriteLine("Мой размер обуви - " + MyShoeSize);
            Console.ReadKey();
        }
    }
}
