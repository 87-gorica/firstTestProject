using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ExtraSports
{
    public class CheckupCartTest
    {
        public static void CheckupCartTestStep(string methodName, string stepName)
        {
            string name = @"C:\Test-ExtraSports\";
            string checkupPath = name + "20190614";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(checkupPath);

            using (StreamWriter writer = new StreamWriter(checkupPath + @"\" + "TestCheckupCart.txt", true))
            {
                writer.WriteLine(DateTime.Now);
                writer.WriteLine(methodName + " " + stepName);
                writer.WriteLine();
            }
        }

        public static void CheckupCartTestPassed()
        {


            string name = @"C:\Test-ExtraSports\";
            string checkupPath = name + "20190614";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(checkupPath);

            using (StreamWriter writer = new StreamWriter(checkupPath + @"\" + "TestCheckupCart.txt", true))
            {

                writer.WriteLine("TEST IS PASSED!");
                writer.WriteLine();
            }
        }

        public static void CheckupCartTestFailed()
        {


            string name = @"C:\Test-ExtraSports\";
            string checkupPath = name + "20190614";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(checkupPath);

            using (StreamWriter writer = new StreamWriter(checkupPath + @"\" + "TestCheckupCart.txt", true))
            {

                writer.WriteLine("TEST IS FAILED!");
                writer.WriteLine();
            }
        }

        public static void CheckupCartTestEnd()
        {


            string name = @"C:\Test-ExtraSports\";
            string checkupPath = name + "20190614";

            if (!Directory.Exists(name))
            {
                Directory.CreateDirectory(name);
            }

            Directory.CreateDirectory(checkupPath);

            using (StreamWriter writer = new StreamWriter(checkupPath + @"\" + "TestCheckupCart.txt", true))
            {

                writer.WriteLine("----------------------------------------------------------------------------------------");
                writer.WriteLine();
            }
        }


    }
}
