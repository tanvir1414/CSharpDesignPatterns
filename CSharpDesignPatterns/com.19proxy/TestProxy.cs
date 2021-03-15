using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._19proxy
{
    class TestProxy
    {
        static void Main(string[] args)
        {
            ITwitter tweet1 = new ProxyServer("@BillGates", "Pass123");
            ITwitter tweet2 = new ProxyServer("@Oprah", "Pass1234");

            tweet1.DisplayTweets();
            tweet2.DisplayTweets();

        }
    }
}
