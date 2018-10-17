using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace RXNETPROGRAM
{
    class ThrowClass
    {
        static void Main(string[] args)
        {
            var throws = Observable.Throw<string>(new Exception());
            //Behaviorally equivalent to
            var subject = new ReplaySubject<string>();
            subject.OnNext("krishna");
            subject.OnError(new Exception());
            throws.Subscribe(a =>
            {
                Console.WriteLine(a);
            });
        }
    }
}
