using System;

namespace IDisposableTest
{
    /// <summary>
    /// Structure implements IDisposable interface.
    /// </summary>
    public struct DisposableStruct : IDisposable
    {
        bool _disposed;

        public Person _person;

        public void SomeOperation()
        {
            Console.WriteLine("Performing operation with DisposableClass object");
        }

        /// <summary>
        /// Implementation of dispose method in IDisposable interface
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine("Dispose method is called");
        }
    }
}
