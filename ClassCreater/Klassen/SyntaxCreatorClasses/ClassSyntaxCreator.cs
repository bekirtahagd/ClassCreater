using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassCreater
{
    public class ClassSyntaxCreator
    {
        //Variables
        private string nspName;
        private string className;
        private bool useRegions;

        private List<VariableData> variables;
        private List<MethodData> methods;


        //Constructor
        public ClassSyntaxCreator(string pNspName, string pClassName, bool pUseRegions, List<MethodData> pMethods)
        {
            nspName = pNspName;
            className = pClassName;
            useRegions = pUseRegions;
            methods = pMethods;
        }

        //Setter and Getter
        public void setNspName(string value)
        {
            nspName = value;
        }
        public string getNspName()
        {
            return nspName;
        }

        public void setClassName(string value)
        {
            className = value;
        }
        public string getClassName()
        {
            return className;
        }

        public void setUseRegions(bool value)
        {
            useRegions = value;
        }
        public bool getUseRegions()
        {
            return useRegions;
        }

        public void setVariables(List<VariableData> value)
        {
            variables = value;
        }
        public List<VariableData> getVariables()
        {
            return variables;
        }

        public void setMethods(List<MethodData> value)
        {
            methods = value;
        }
        public List<MethodData> getMethods()
        {
            return methods;
        }

        //Functions
        public string createClass()
        {
            //References
            VariableSyntaxCreator variableCreator = new VariableSyntaxCreator();
            ConstructorSyntaxCreator constructorCreator = new ConstructorSyntaxCreator();
            GetterSetterSyntaxCreator getterSetterCreator = new GetterSetterSyntaxCreator();
            MethodSyntaxCreator methodCreator = new MethodSyntaxCreator();

            //Create Output Variable
            string output =
                "using System;\nusing System.Collections.Generic;\nusing System.Linq;\nusing System.Text;\nusing System.Windows.Forms;\n\n"  +
                $"namespace {nspName}\n" +
                 "{\n" +
                $"    public class {className}\n" +
                 "    {\n" +
                $"{variableCreator.createVariablesPart(variables, useRegions)}" +
                $"{constructorCreator.createConstructor(className, variables, useRegions)}" + 
                $"{getterSetterCreator.createGSettersPart(variables, useRegions)}" +
                $"{methodCreator.createMethodsPart(methods, useRegions)}" +
                 "    }\n" +  //Class Bracket
                 "}";

            return output;
        }

        public List<VariableData> readVariablesFromGUI(FlowLayoutPanel flp)
        {
            //Variables
            List<Panel> panels = flp.Controls.OfType<Panel>().ToList();
            List<VariableData> variables = new List<VariableData>();
            ErrorHandler errorHandler = new ErrorHandler();

            //Loop
            for(int i = 0; i < panels.Count; i++)
            {
                Panel pnl = panels[i];

                //Search for error
                if(errorHandler.hasBlankTb(pnl))
                {
                    errorHandler.createTbError("FILL OUT ALL VARIABLES AND METHODS");
                    return null;
                }

                //Get Data
                bool isPrivate = !pnl.Controls.OfType<CheckBox>().ToList()[0].Checked;
                string type = pnl.Controls.OfType<TextBox>().ToList()[0].Text;
                string name = pnl.Controls.OfType<TextBox>().ToList()[1].Text;
                 
                //Create Variable
                VariableData v = new VariableData(isPrivate, type, name);

                //Add Variable
                variables.Add(v);
            }

            return variables;
        }

        public List<MethodData> readMethodsFromGUI(FlowLayoutPanel flp)
        {
            //Variables
            List<Panel> panels = flp.Controls.OfType<Panel>().ToList();
            List<MethodData> methods = new List<MethodData>();
            ErrorHandler errorHandler = new ErrorHandler();


            //Loop
            for (int i = 0; i < panels.Count; i++)
            {
                Panel pnl = panels[i];

                //Search for error
                if (errorHandler.hasBlankTb(pnl))
                {
                    errorHandler.createTbError("FILL OUT ALL VARIABLES AND METHODS");
                    return null;
                }

                //Get Data
                bool isPrivate = !pnl.Controls.OfType<CheckBox>().ToList()[0].Checked;
                string type = pnl.Controls.OfType<TextBox>().ToList()[0].Text;
                string name = pnl.Controls.OfType<TextBox>().ToList()[1].Text;
                List<ParameterData> parameters = new List<ParameterData>();

                //Create Variable
                MethodData m = new MethodData(isPrivate, type, name, parameters);

                //Add Variable
                methods.Add(m);
            }

            return methods;
        }
    }
}