using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Eventesea
{
    internal static class Globals
    {
        static string db_name = "EventEaseDB.mdb";  //change this to your database name
        static string database_path = @"..\..\" + db_name;
        static string current_dir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        static string full_path = Path.Combine(current_dir,database_path); //path to the root database

        //public const string conStr = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|..\..\EventEaseDB.mdb";
        //public static string conStr = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source="+ Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),"..","..","EventEaseDB.mdb");
        //public static string conStr = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),database_path);
        public static string dbConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + full_path;
    }
}
