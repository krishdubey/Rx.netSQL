using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace RXNETPROGRAM
{
    class ReturnClass
    {
        static void Main(string[] args)
        {
            var singleValue = Observable.Return<string>("Value");
            //which could have also been simulated with a replay subject
            var subject = new ReplaySubject<string>();
            subject.OnNext("Value");
            subject.OnCompleted();
            singleValue.Subscribe(x => {
                Console.WriteLine(x);
            });
            
        }
    }
}
