using System;

namespace IDisposableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DisposableClass obj = new DisposableClass())
            {
                obj.SomeOperation();
            }

            using (DisposableStruct obj = new DisposableStruct())
            {
                obj.SomeOperation();
            }
            Console.ReadLine();
        }
    }
}
