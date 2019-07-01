using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ExtraSports
{
   public class NavTest
    {

       

        public static void NavTestStep(string methodName, string stepName)
        {
            string name = @"C:\Test-ExtraSports\";
            string navPath = name + "20190614";
            
            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(navPath);

            using (StreamWriter writer = new StreamWriter(navPath + @"\" + "TestNavigation.txt", true))
            {
                writer.WriteLine(DateTime.Now);
                writer.WriteLine(methodName + " " + stepName);
                writer.WriteLine();
            }
        }

        public static void NavTestPassed()
        {

            
            string name = @"C:\Test-ExtraSports\";
            string navPath = name + "20190614";
          
            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(navPath);

            using (StreamWriter writer = new StreamWriter(navPath + @"\" + "TestNavigation.txt", true))
            {
               
               writer.WriteLine("TEST IS PASSED!");
                writer.WriteLine();
            }
        }

        public static void NavTestFailed()
        {
            string name = @"C:\Test-ExtraSports\";
            string navPath = name + "20190614";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(navPath);

            using (StreamWriter writer = new StreamWriter(navPath + @"\" + "TestNavigation.txt", true))
            {
                writer.WriteLine("TEST IS FAILED!");
                writer.WriteLine();
            }
        }

        public static void NavTestEnd()
        {
            string name = @"C:\Test-ExtraSports\";
            string navPath = name + "20190614";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(navPath);

            using (StreamWriter writer = new StreamWriter(navPath + @"\" + "TestNavigation.txt", true))
            {
                writer.WriteLine("----------------------------------------------------------------------------");
                writer.WriteLine();
            }
        }
    }
}
