using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._18state
{
    class TestState
    {
        static void Main(string[] args)
        {
            StateContext context = new StateContext();
            context.IsMeetingOn("Rm001");

            context.SetState(new StateLive());
            context.IsMeetingOn("Rm001");
        }
    }
}
