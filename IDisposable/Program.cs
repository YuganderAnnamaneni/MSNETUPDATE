using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DisposableClass obj = new DisposableClass();
            obj.Dispose();
            Console.ReadLine();
        }

        public class DisposableClass : IDisposable
        {
            bool _disposed;

            public Person _person;

            /// <summary>
            /// Initializes Person class in default constructor.
            /// </summary>
            public DisposableClass()
            {
                this._person = new Person();
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            /// <summary>
            /// Calls when there are no references of instance of this class.
            /// </summary>
            ~DisposableClass()
            {
                Dispose(false);
            }

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

        public class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string Email { get; set; }
        }
    }
}
