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
        public void DisplayTweets()
        {
            throw new NotImplementedException();
        }
    }
}
