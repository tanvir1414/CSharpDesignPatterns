using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._24observer
{
    class Blog : ISubject
    {
        List<IObserver> observerList;
        private bool stateChange;
        private string blogArticle;

        public Blog()
        {
            this.observerList = new List<IObserver>();
            stateChange = false; 
        }

        public void RegisterObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }

        public void PostNewArticle()
        {
            this.blogArticle = "Hey! I met North West in Paris!";
            stateChange = true;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            if (stateChange)
            {
                foreach(IObserver observer in observerList)
                {
                   observer.UpdateUsers(blogArticle);
                }
            } 
             
        }


    }
}
