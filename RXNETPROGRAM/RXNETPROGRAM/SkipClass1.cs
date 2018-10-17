using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;
using System.Reactive.Linq;
namespace RXNETPROGRAM
{
    class SkipClass1
    {
        static void Main(string[] args)
        {
            Observable.Range(0, 10)
          .Skip(3)
         .Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
        }
    }
}
