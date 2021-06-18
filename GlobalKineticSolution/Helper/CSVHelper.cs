using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using GlobalKineticSolution;

namespace GlobalKineticSolution.Helper
{
    public static class CSVHelper
    {
       

        public static void InsertEntry(string entry,string path)
        {

            using (StreamWriter sw = new StreamWriter(path))
            {
                 sw.WriteLine(entry);
            }
        }

        public static List<string> ReadEntries(string path)
        {
            List<string> result = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                int i = 0;
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (i > 0)
                    {
                        result.Add(line);
                    }
                    i++;
                }
            }
            return result;
        }

        public static void ClearEntries(string path)
        {
            using (StreamWriter sw = new StreamWriter(path,false))
            {
                sw.WriteLine("Amount,Volume");
            }

        }


    }
}
