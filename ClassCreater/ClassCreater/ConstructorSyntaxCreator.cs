using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreater
{
    class ConstructorSyntaxCreator
    {
        ParameterSyntaxCreator paraCreator = new ParameterSyntaxCreator();

        public string createConstructor(string className, List<VariableData> variables, bool useRegions)
        {
            //Parameter Creation
            string paraSyntax = paraCreator.createConstructorParameters(variables);

            //Create header line
            string output =  "        //Constructor\n";

            //If user wants to use region add region header
            if(useRegions)
            {
                output += "        #region Constructor\n\n";
            }

            //Create Constructor
            output +=
                $"        public {className}({paraSyntax})\n" +
                 "        {\n" +
                             $"{createConstructorSetter(variables)}" +
                 "        }\n";

            //If user wants to use regions close region
            if(useRegions)
            {
                output += "\n        #endregion\n\n";
            }

            //Add an extra line to built space before the next part
            output += "\n";

            return output;
        }

        private string createConstructorSetter(List<VariableData> variables)
        {
            string output = "";

            //Create loop to create every single line
            int length = variables.Count;
            for(int i = 0; i < length; i++)
            {
                string name = variables[i].getVarName();
                output += $"            {name} = {paraCreator.convertToConPara(name)};\n"; 
            }

            return output;
        }
    }
}
