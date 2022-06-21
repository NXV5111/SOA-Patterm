using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoServiceOrchestration
{
    class Program
    {
        static void Main(string[] args)
        {

            MyFunction.Initialize();
            MyProgram program = new MyProgram();
            string sPath = Console.ReadLine();

            MyCompositeFunction func10 = new MyCompositeFunction();
            func10.LoadProgramFromScript(@"e:\Teaching\2020-2021\HK2\DemoServiceOrchestration\Max3Integer.txt");
            MyFunction.AddFunction("Max3Integers", func10);

            program.LoadProgramFromScript(sPath);// @"c:\TempDemo\script1.txt");
            program.ExecuteProgram();
            program.DisplayAllVariables();
        }

    }
}
