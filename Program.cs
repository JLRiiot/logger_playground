using System;
using System.Linq;
using System.Text;
using ImBack.Facades;

namespace ImBack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String logMessage = System.Reflection.Assembly.GetExecutingAssembly().Location;

			Log.WriteError(logMessage);
            Log.WriteWarning(logMessage);
            Log.WriteMessage(logMessage);
        }
    }
}
