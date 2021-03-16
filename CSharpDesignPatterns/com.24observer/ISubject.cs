using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._24observer
{
    interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();

    }
}
