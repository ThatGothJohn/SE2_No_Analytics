using HarmonyLib;
using Keen.Game2.Game.Plugins;
using Keen.VRage.Library.Diagnostics;
using System.Reflection;

namespace NoAnalytics
{
    public class Plugin : IPlugin
    {
        public const string Name = "SE2 No Analytics";

        public Plugin()
        {
            Log.Default.WriteLine($"Loaded {Name} Plugin!");

            Harmony harmony = new(Name);
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            Log.Default.WriteLine($"Applied {Name} Patches!");
        }
    }
}