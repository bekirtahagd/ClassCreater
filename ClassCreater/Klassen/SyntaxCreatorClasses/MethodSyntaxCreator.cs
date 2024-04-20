using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreater
{
    public class MethodSyntaxCreator
    {
        //Sy Method Creation
        public string createMethodsPart(List<MethodData> methods, bool useRegions)
        {
            //Check whether there are even any methods for us to create
            int length = methods.Count;
            if (length != 0)
            {
                //Create headline
                string output = "        // Methods\n";

                //If user wants to use region then add region header
                if (useRegions)
                {
                    output += "        #region Methods\n\n";
                }

                //Create each line with looping through each method
                for (int i = 0; i < length; i++)
                {
                    output += createMethod(methods[i]);
                    
                    //If this isn't the last index we will add a line space between
                    if (i != length - 1)
                    {
                        output += "\n";
                    }
                }

                //If user wants to use region then close region
                if(useRegions)
                {
                    output +=   "\n        #endregion\n";
                }

                return output;
            }

            return "";
        }

        private string createMethod(MethodData method)
        {
            string output = "";
            string privSyntax = "";
            
            string paraSyntax = "";
            List<ParameterData> parameters = method.getParamaters();

            //Create private string
            if (method.getIsPrivate())
            {
                privSyntax = "private";
            }
            else
            {
                privSyntax = "public";
            }


            //Create Parameter Syntax
            int length = parameters.Count();
            if(length != 0)
            {   
                ParameterSyntaxCreator parameterCreator = new ParameterSyntaxCreator();
                paraSyntax = parameterCreator.createParameters(parameters);
            }


            //Look if we need to return something
            if (method.getFunctionType() == "void")
            {
                output = $"        {privSyntax} {method.getFunctionType()} {method.getFunctionName()}({paraSyntax})\n" +
                          "        {\n" +
                          "            \n" +
                          "        }\n";
            }
            else
            {
                output = $"        {privSyntax} {method.getFunctionType()} {method.getFunctionName()}({paraSyntax})\n" +
                          "        {\n" +
                         $"            {method.getFunctionType()} output;\n" +
                          "            \n" +
                          "            return output;\n" +
                          "        }\n";
            }

            return output;
        }
    }
}
