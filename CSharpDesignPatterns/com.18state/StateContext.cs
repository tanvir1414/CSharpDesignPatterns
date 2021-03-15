using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._18state
{
    class StateContext
    {
        private IMeetingState currentState;

        public StateContext()
        {
            SetState(new StateOffline());
        }

        public void SetState(IMeetingState newState)
        {
            currentState = newState;   
        }

        public void IsMeetingOn(string room)
        {
            currentState.IsMeetingOn(this, room);
        }
    }
}
