using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._15templatemethod
{
    public class TextFile : DataProcessor
    {
        //public void ReadProcessandSave()
        //{
        //    ReadData();
        //    ProcessData();
        //    SaveData();
        //}
        public override void ReadData()
        {
            Console.WriteLine("Reads data from Text file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process data from Text file");
        }

        //public void SaveData()
        //{
        //    Console.WriteLine("Saves data to Db");
        //}
    }
}
