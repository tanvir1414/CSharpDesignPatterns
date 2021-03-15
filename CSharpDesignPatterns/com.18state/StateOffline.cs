using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._18state
{
    class StateOffline : IMeetingState
    {
        public void IsMeetingOn(StateContext context, string room)
        {
            Console.WriteLine("Meeting not started in " + room);
        }
    }
}
