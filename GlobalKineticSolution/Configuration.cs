using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Configuration;

namespace GlobalKineticSolution
{
    public static class Configuration
    {

        public static String GetCSVStorage()
        {
            return ConfigurationManager.AppSettings["CSVStoragePath"];
        }

    }
}
