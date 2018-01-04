﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverPattern
{
    public interface IObserver
    {
        void Update(ISubject sub, object arg);
    }
}
