﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace RXNETPROGRAM
{
    class ObserIntervalClass
    {
        static void Main(string[] args)
        {
            var interval = Observable.Interval(TimeSpan.FromMilliseconds(250));
            interval.Subscribe(
            Console.WriteLine,
            () => Console.WriteLine("completed"));
            Console.Read();
        }
    }
}
