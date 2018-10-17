using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace RXNETPROGRAM
{
    class Class1
    {
        static event Action<int> Changed;
        static Subject<int> Changed2 = new Subject<int>();
        static void Main(string[] args)
        {
          var d = Changed2.Subscribe(x =>
            {
                Console.WriteLine(x);
            });

            Changed2.OnNext(54);
            d.Dispose();
            Changed2.OnNext(60);
            Console.Read();
        }
    }
}
