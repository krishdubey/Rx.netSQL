using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace RXNETPROGRAM
{
    class NeverClass
    {
        static void Main(string[] args)
        {
            var never = Observable.Never<string>();
            //similar to a subject without notifications
            
            var subject = new Subject<string>();
            subject.OnNext("krishna");
            never.Subscribe(a =>
            {
                Console.WriteLine("hello");
            });
        }
    }
}
