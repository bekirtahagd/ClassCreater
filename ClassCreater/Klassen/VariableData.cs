using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassCreater
{
    public class VariableData
    {
        //Variables
        private bool isPrivate;
        private  string varType;
        private string varName;

        //Constructor
        public VariableData(bool pIsPrivate, string pVarType, string pVarName)
        {
            isPrivate = pIsPrivate;
            varType = pVarType;
            varName = pVarName;
        }

        // Setter and Getter
        #region Setter and Getter
        public void setIsPrivate(bool value)
        {
            isPrivate = value;
        }
        public bool getIsPrivate()
        {
            return isPrivate;
        }

        public void setVarType(string value)
        {
            varType = value;
        }
        public string getVarType()
        {
            return varType;
        }

        public void setVarName(string value)
        {
            varName = value;
        }
        public string getVarName()
        {
            return varName;
        }
        #endregion
    }
}