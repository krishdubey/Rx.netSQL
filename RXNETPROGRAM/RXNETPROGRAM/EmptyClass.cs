using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace RXNETPROGRAM
{
    class EmptyClass
    {
        static void Main(string[] args)
        {
            var empty = Observable.Empty<string>();
            //Behaviorally equivalent to
            var subject = new ReplaySubject<string>();
            subject.OnNext("krishna");
            subject.OnCompleted();
            empty.Subscribe(a =>
            {
                Console.WriteLine(a);
            });

        }
    }
}
