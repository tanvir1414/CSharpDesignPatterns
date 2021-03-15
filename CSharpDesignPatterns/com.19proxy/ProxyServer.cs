using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._19proxy
{
    class ProxyServer : ITwitter
    {
        private RealTimeTweets tweets;
        private string twitterHandle;
        private string password;

        public ProxyServer(string twitterHandle, string password)
        {
            this.twitterHandle = twitterHandle;
            this.password = password;
        }

        /**
         * Authenticate password and displays the tweets
         */
        public void DisplayTweets()
        {
            if (password.Equals("Pass123"))
            {
                // Lazy loading. Fetch the tweets only if they are null.
                if(tweets == null)
                {
                    tweets = new RealTimeTweets(twitterHandle);
                }

                tweets.DisplayTweets();
            }
        }


    }
}
