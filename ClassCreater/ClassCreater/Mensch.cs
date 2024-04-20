namespace ClassCreator
{
    public class Mensch
    {
        // Variables
        #region Variables

        private string Name;
        private string Familienname;
        private int age;

        #endregion


        //Constructor
        #region Constructor

        public Mensch(string pName, string pFamilienname, int pAge)
        {
            Name = pName;
            Familienname = pFamilienname;
            age = pAge;
        }

        #endregion


        #region Setter and Getter

        public void setName(string value)
        {
            Name = value;
        }
        public string getName()
        {
            return Name;
        }

        public void setFamilienname(string value)
        {
            Familienname = value;
        }
        public string getFamilienname()
        {
            return Familienname;
        }

        public void setAge(int value)
        {
            age = value;
        }
        public int getAge()
        {
            return age;
        }

        #endregion


        // Methods
        #region Methods

        public void geburtsTag()
        {
            
        }

        public string randomName()
        {
            string output;
            
            return output;
        }

        #endregion
    }
}