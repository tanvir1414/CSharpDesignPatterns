using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._24observer
{
    class User : IObserver
    {
        private string article;
        private ISubject blog;

        public User(ISubject blog)
        {
            this.blog = blog;
            blog.RegisterObserver(this);
        }

        public void PrintArticle()
        {
            Console.WriteLine("Desktop Browser : " + this.article); 
        }

        public void UpdateUsers(string blogArticle)
        {
            this.article = blogArticle;
            Console.WriteLine("State change reported by Subject.");
        }

    }
}
