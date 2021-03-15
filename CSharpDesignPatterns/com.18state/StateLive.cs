using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._18state
{
    class StateLive : IMeetingState
    {
        public void IsMeetingOn(StateContext context, string room)
        {
            Console.WriteLine("Enter meeting in " + room);
        }
    }
}
