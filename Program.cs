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
			Log.WriteMessage("Initializing app...");
			Log.WriteMessage("App initialized!");
			Log.WriteError("Testing error message...");
			Log.WriteWarning("Testing warning message...");
        }
    }
}
