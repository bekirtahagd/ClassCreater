using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreater
{
    public class VariableSyntaxCreator
    {
        //Methods
        public string createVariablesPart(List<VariableData> variables, bool useRegions)
        {
            //Creating Headline
            string output = "        // Variables\n";
            
            //If user wants to use region add region header
            if(useRegions)
            {
                output += "        #region Variables\n\n";
            }

            //Creating each line with looping through every variable
            for (int i = 0; i < variables.Count; i++)
            {
                output += createVariable(variables[i]);
            }

            //If user wants to use region add region end
            if (useRegions)
            {
                output += "\n        #endregion\n\n";
            }

            //Add a line for extra space between next part of class 
            output += "\n";

            return output;
        }
        private string createVariable(VariableData variable)
        {
            string output = "        ";

            //Look if variable private
            if (variable.getIsPrivate())
            {
                output += "private ";
            }
            else
            {
                output += "public ";
            }

            //Add variable type and name
            output += $"{variable.getVarType()} {variable.getVarName()};\n";

            return output;
        }
    }
}
