using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassCreater
{
    public partial class formMain : Form
    {
        static List<VariableData> variables;

        static List<MethodData> methods;

        public formMain()
        {
            InitializeComponent();
        }

        //Form component functions
        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            //Get Button Reference
            Button btn = sender as Button;

            //Get Variables
            string namespaceName = tbNamespace.Text;
            string className = tbClassName.Text;
            bool useRegions = cbRegions.Checked;

            //Create Class
            ClassSyntaxCreator classCreator = new ClassSyntaxCreator(namespaceName, className, useRegions, methods);

            //Read Variables
            variables = classCreator.readVariablesFromGUI(flpVariables);
            if(variables == null) return;
            classCreator.setVariables(variables);

            //Read Methods
            methods = classCreator.readMethodsFromGUI(flpMethods);
            if (methods == null) return;
            classCreator.setMethods(methods);

            //If user wants to create a file
            string output = classCreator.createClass();
            if (btn.Name == "btnCreateFile")
            {
                //Loop through all textboxes and watch if one is false
                ErrorHandler errorHandler = new ErrorHandler();

                foreach (Control c in Controls)
                {
                    if (c is Panel) 
                    {
                        if (c.Name != "pnlVars" && c.Name != "pnlMethods")
                        {
                            if (errorHandler.hasBlankTb(c))
                            {
                                errorHandler.createTbError("FILL OUT ALL TEXTBOXES");
                                return;
                            }
                        }
                    }
                }
                

                //Create a file
                ClassFileCreator cfl = new ClassFileCreator();
                cfl.createClassFile(tbPath.Text, className, output);
            } 

            //Display Syntax
            rtbOutput.Text = output;

        }



        private void addVariablePanel(object sender, EventArgs e)
        {
            CustomObject customObject = new CustomObject();
            Panel pnl = customObject.createVarPanel(deleteParent);

            flpVariables.Controls.Add(pnl);
        }

        private void addMethodPanel(object sender, EventArgs e)
        {
            CustomObject customObject = new CustomObject();
            Panel pnl = customObject.createMethodPanel(deleteParent);

            flpMethods.Controls.Add(pnl);
        }

        private void deleteParent(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Parent.Dispose();
        }

        private void ChooseFolder(object sender, EventArgs e)
        {
            //Let User choose path where class is going to be saved
            folderBrowserDialog.ShowDialog();

            //Enter Path into Path Text Box
            tbPath.Text = folderBrowserDialog.SelectedPath;
        }
  



        #region unused methods

        private void folderBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
