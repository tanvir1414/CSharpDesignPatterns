using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._24observer
{
    interface IObserver
    {
        //blogArticle - values the observer gets from the subject

        void UpdateUsers(string blogArticle);
        void PrintArticle();
    }
}
