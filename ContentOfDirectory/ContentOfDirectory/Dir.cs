using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ContentOfDirectory
{
   public class Dir
    {
        static string tempStr;
        public static void printContent(string input)
        {
            try
            {
                if (!Directory.Exists(input))
                {
                    throw new DirectoryNotFoundException();
                }
                else
                    helper(input,0);
                
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Wrong input directory");
            }
        }

        static void helper(string root,int spaceCount)
        {
            tempStr = "FOLDER: " + Path.GetFileName(root);
            Console.WriteLine(tempStr.PadLeft(tempStr.Length + spaceCount, ' '));

            spaceCount++;
            foreach (string temp in Directory.GetFiles(root))
            {
                tempStr = Path.GetFileName(temp);
                Console.WriteLine(tempStr.PadLeft(tempStr.Length + spaceCount, ' '));
            }
            
            foreach (string temp in Directory.GetDirectories(root))
            {
                helper(temp,spaceCount + 1);
            }
        }

    }
}
