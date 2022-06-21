using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoServiceOrchestration
{
    public class MyProgramStep
    {
        public string strFunctionName;
        public List<VariableMapping> inputmapping, outputmapping;

        public VariableDictionary Execute(VariableDictionary input)
        {
            MyFunction func = MyFunction.GetInstance(strFunctionName);
            return func.Execute(input);
        }
    }
}