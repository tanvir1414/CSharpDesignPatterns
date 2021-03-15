using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._15templatemethod
{
    class TestTemplateMethod
    {
        static void Main(string[] args)
        {
            ExcelFile obj = new ExcelFile();
            obj.ReadProcessandSave();
            //obj.ReadData();
            //obj.ProcessData();
            //obj.SaveData();

            Console.WriteLine("-----------------");

            TextFile obj2 = new TextFile();
            obj2.ReadProcessandSave();
            //obj2.ReadData();
            //obj2.ProcessData();
            //obj2.SaveData();
        }
    }
}
