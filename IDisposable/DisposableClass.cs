using System;

namespace IDisposableTest
{
    /// <summary>
    /// Class implements IDisposable interface
    /// </summary>
    public class DisposableClass : IDisposable
    {
        bool _disposed;

        public Person _person;

        public void SomeOperation()
        {
            Console.WriteLine("Performing operation with DisposableClass object");
        }

        /// <summary>
        /// Initializes Person class in default constructor.
        /// </summary>
        public DisposableClass()
        {
            Console.WriteLine("Constructor method is called");
            this._person = new Person();
        }

        /// <summary>
        /// Implementation of dispose method in IDisposable interface
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine("Dispose method is called");
            Dispose(true);
        }

        /// <summary>
        /// Sets properties of this class to null if disposing is true and sets _disposed to true.
        /// </summary>
        /// <param name="disposing">bool</param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                this._person = null;
            }

            _disposed = true;
        }
    }
}
