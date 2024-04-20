using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ClassCreater
{
    public class ClassFileCreator
    {
        public void createClassFile(string path, string className, string content)
        {
            //Create Path String
            path += $"\\{className}.cs";

            Console.WriteLine("D:\\BTGD\\Documents\\Informatik\\csharp\\projects\\ClassCreater\\ClassCreater\\");
            Console.WriteLine(path);

            //Create File
            File.WriteAllText(path, content);

            //Give Message
            MessageBox.Show("FILE SUCCESSFULLY CREATED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
