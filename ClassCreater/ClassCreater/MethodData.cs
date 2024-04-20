using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreater
{
    public class MethodData
    {
        // Variables
        private bool isPrivate;
        private string functionType;
        private string functionName;
        private List<ParameterData> paramaters;

        //Constructor
        public MethodData(bool pIsPrivate, string pFunctionType, string pFunctionName, List<ParameterData> pParamaters)
        {
            isPrivate = pIsPrivate;
            functionType = pFunctionType;
            functionName = pFunctionName;
            paramaters = pParamaters;
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

        public void setFunctionType(string value)
        {
            functionType = value;
        }
        public string getFunctionType()
        {
            return functionType;
        }

        public void setFunctionName(string value)
        {
            functionName = value;
        }
        public string getFunctionName()
        {
            return functionName;
        }

        public void setParamaters(List<ParameterData> value)
        {
            paramaters = value;
        }
        public List<ParameterData> getParamaters()
        {
            return paramaters;
        }
        #endregion
    }
}
