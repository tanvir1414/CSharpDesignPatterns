using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._19proxy
{
    class RealTimeTweets : ITwitter
    {
        private string twitterHandle;

        public RealTimeTweets(string twitterHandle)
        {
            this.twitterHandle = twitterHandle;
        }

        /**
         *  Displays the tweets
         */
        public void DisplayTweets()
        {
            Console.WriteLine("Displaying tweets for " + twitterHandle);
        }
    }
}
