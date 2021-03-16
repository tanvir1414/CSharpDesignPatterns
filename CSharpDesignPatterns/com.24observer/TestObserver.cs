using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._24observer
{
    class TestObserver
    {
        static void Main(string[] args)
        {
            Blog blog = new Blog();

            User user1 = new User(blog);
            User user2 = new User(blog);

            user1.PrintArticle();
            user2.PrintArticle();

            blog.PostNewArticle();

            user1.PrintArticle();
            user2.PrintArticle();
        }
    }
}
