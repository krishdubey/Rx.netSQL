using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;
using System.Reactive.Linq;

namespace RXNETPROGRAM
{
    class SequenceEqualClass
    {
        static void Main(string[] args)
        {
            var subject1 = new Subject<int>();
            subject1.Subscribe(
            i => Console.WriteLine("subject1.OnNext({0})", i),
            () => Console.WriteLine("subject1 completed"));
            var subject2 = new Subject<int>();
            subject2.Subscribe(
            i => Console.WriteLine("subject2.OnNext({0})", i),
            () => Console.WriteLine("subject2 completed"));
            var areEqual = subject1.SequenceEqual(subject2);
            areEqual.Subscribe(
            i => Console.WriteLine("areEqual.OnNext({0})", i),
            () => Console.WriteLine("areEqual completed"));
            subject1.OnNext(1);
            subject1.OnNext(2);
            subject2.OnNext(1);
            subject2.OnNext(2);
            subject2.OnNext(3);
            subject1.OnNext(3);
            subject1.OnCompleted();
            subject2.OnCompleted();
        }
    }
}
