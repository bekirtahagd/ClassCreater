using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreater
{
    public class ParameterSyntaxCreator
    {
        public string createParameters(List<ParameterData> parameters)
        {
            string output = "";
            int length = parameters.Count();
            for (int i = 0; i < length; i++)
            {
                output += $"{parameters[i].getType()} {parameters[i].getName()}";

                //If this is not last iteration
                if (i != length - 1)
                {
                    output += ", ";
                }
            }

            return output;
        }

        public string createParameters(List<VariableData> parameters)
        {
            string output = "";
            int length = parameters.Count();
            for (int i = 0; i < length; i++)
            {
                output += $"{parameters[i].getVarType()} {parameters[i].getVarName()}";

                //If this is not last iteration
                if (i != length - 1)
                {
                    output += ", ";
                }
            }

            return output;
        }

        public string createConstructorParameters(List<VariableData> parameters)
        {
            string output = "";
            int length = parameters.Count();
            for (int i = 0; i < length; i++)
            {
                VariableData para = parameters[i];
                
                output += $"{parameters[i].getVarType()} {convertToConPara(para.getVarName())}";

                //If this is not last iteration
                if (i != length - 1)
                {
                    output += ", ";
                }
            }

            return output;
        }

        public string convertToConPara(string name)
        {
            return "p" + char.ToUpper(name[0]) + name.Substring(1);
        }
    }
}
