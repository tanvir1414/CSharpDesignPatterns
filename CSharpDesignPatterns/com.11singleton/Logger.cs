using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._11singleton
{
    public class Logger
    {
        //static method only can access static object
        //  private static Logger logger;

        private static Logger instance;
        private Logger()
        { 
        
        }

        //One per class in static

        /*     public static Logger GetInstance()
             {
                 if(logger == null)
                 {
                     logger = new Logger();
                 }
                 return logger;
             }
        */
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                
                return instance;
            }

        }
    }
}
