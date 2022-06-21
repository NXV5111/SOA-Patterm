using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoServiceOrchestration
{
    public class VariableMapping
    {
        public string strSourceVariableName;
        public string strTargetVariableName;

        public VariableMapping(string strSourceVariableName, string strTargetVariableName)
        {
            this.strSourceVariableName = strSourceVariableName;
            this.strTargetVariableName = strTargetVariableName;
        }
    }
}