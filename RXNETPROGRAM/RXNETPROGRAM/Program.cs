using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace RXNETPROGRAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var xs = "Hello World".ToObservable();

            xs.Subscribe(x => Console.Write(x));
            Console.ReadLine();
        }
    }
}
