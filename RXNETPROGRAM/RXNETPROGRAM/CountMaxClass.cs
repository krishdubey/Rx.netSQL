using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;
using System.Reactive.Linq;

namespace RXNETPROGRAM
{
    class CountMaxClass
    {
       
        static void Main(string[] args)
        {
            var numbers = Observable.Range(0, 3);
       //     numbers.Dump("numbers");
         //   numbers.Count().Dump("count");
        }
    }
}
