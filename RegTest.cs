using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ExtraSports
{
    public class RegTest
    {
        public static void RegStep(string methodName, string stepName)
        { 

            string name = @"C:\Test-ExtraSports\";
            string regPath = name + "20190614";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

    Directory.CreateDirectory(regPath);

            using (StreamWriter writer = new StreamWriter(regPath + @"\" + "TestRegistracija.txt", true))
            {
                writer.WriteLine(DateTime.Now);
                writer.WriteLine(methodName + " " + stepName);
                writer.WriteLine();
            }   
         }  
        
        public static void RegPassedTest()
        {
            string name = @"C:\Test-ExtraSports\";
            string regPath = name + "20190614";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(regPath);

            using (StreamWriter writer = new StreamWriter(regPath + @"\" + "TestRegistracija.txt", true))
            {
                writer.WriteLine("TEST IS PASSED!");
                writer.WriteLine();
            }

        }

        public static void RegFailedTest()
        {
            string name = @"C:\Test-ExtraSports\";
            string regPath = name + "20190614";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(regPath);

            using (StreamWriter writer = new StreamWriter(regPath + @"\" + "TestRegistracija.txt", true))
            {
                writer.WriteLine("TEST IS FAILED!");
                writer.WriteLine();
            }

        }

        public static void RegEnd()
        {
            string name = @"C:\Test-ExtraSports\";
            string regPath = name + "20190614";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(regPath);

            using (StreamWriter writer = new StreamWriter(regPath + @"\" + "TestRegistracija.txt", true))
            {
                writer.WriteLine("--------------------------------------------------------------------------");
                writer.WriteLine();
            }

        }
    }
}
