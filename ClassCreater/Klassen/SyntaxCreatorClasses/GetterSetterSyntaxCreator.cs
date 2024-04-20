using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreater
{
    public class GetterSetterSyntaxCreator
    {
        //Sy Getter Setter Creation
        public string createGSettersPart(List<VariableData> variables, bool useRegion)
        {
            //Create header line
            string output = "        // Setter and Getter\n";

            //If user wants to use region then create region header
            if(useRegion)
            {
                output = "        #region Setter and Getter\n\n";
            }

            //Loop through variables and create setter/getter for each one
            for (int i = 0; i < variables.Count; i++)
            {
                output += createGSetter(variables[i]);
            }

            //If user wants to use region close region
            if(useRegion)
            {
                output += "        #endregion\n\n\n";
            }

            return output;
        }

        private string createGSetter(VariableData variable)
        {
            //Convert first letter of varname to upper
            string uVarname = char.ToUpper(variable.getVarName()[0]) + variable.getVarName().Substring(1);

            //Return getter and setter syntax
            return $"        public void set{uVarname}({variable.getVarType()} value)\n" +
                    "        {\n" +
                   $"            {variable.getVarName()} = value;\n" +
                    "        }\n" +
                   $"        public {variable.getVarType()} get{uVarname}()\n" +
                    "        {\n" +
                   $"            return {variable.getVarName()};\n" +
                    "        }\n\n";
        }
    }
}
