using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace RXNETPROGRAM
{
    class ObservableTimerClass
    {
        static void Main(string[] args)
        {
            var timer = Observable.Timer(TimeSpan.FromSeconds(2));
            timer.Subscribe(
            Console.WriteLine,
            () => Console.WriteLine("completed"));
            Console.Read();
        }
    }
}
