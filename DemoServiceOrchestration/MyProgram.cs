using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DemoServiceOrchestration
{
    public class MyProgram
    {
        private MyCompositeFunction processor = new MyCompositeFunction();
        public void DisplayAllVariables()
        {
            processor.DisplayAllVariables();
        }

        public bool ExecuteProgram()
        {
            processor.Execute(new VariableDictionary());
            return true;
        }

        public bool LoadProgramFromScript(string strFileName)
        {
            return processor.LoadProgramFromScript(strFileName);
        }


    }
}