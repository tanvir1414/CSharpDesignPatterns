using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._18state
{
    interface IMeetingState
    {
        void IsMeetingOn(StateContext context, string room);
       
    }
}
