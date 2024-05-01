using System.Runtime.ExceptionServices;

namespace CHARPTut040.Foreach
{
    public class Program
    {
        static void Main(string[] args)
        {
            var number = new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Foreach(number);
            Console.ReadKey();
        }
        static void Foreach<T>( IEnumerable<T> arr)
        {
            IEnumerator<T> enumerator = arr.GetEnumerator();
            IDisposable disposable;
            try
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);

                }
            }
            finally
            {
                disposable = (IDisposable)enumerator;
                disposable.Dispose();
            }
        }
    }
}