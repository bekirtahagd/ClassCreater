using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreator
{
    public class ParameterData
    {
        // Variables
        private string type;
        private string name;

        //Constructor
        public ParameterData(string pType, string pName)
        {
            type = pType;
            name = pName;
        }

        // Setter and Getter
        #region Setter and Getter
        public void setType(string value)
        {
            type = value;
        }
        public string getType()
        {
            return type;
        }

        public void setName(string value)
        {
            name = value;
        }
        public string getName()
        {
            return name;
        }
        #endregion

        // Methods
    }
}