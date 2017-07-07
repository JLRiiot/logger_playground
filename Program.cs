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
			Log.Message("Initializing app...");
			Log.Message("App initialized!");
			Log.Error("Testing error message...", "Details...");
			Log.Warning("Testing warning message...");
        }
    }
}
