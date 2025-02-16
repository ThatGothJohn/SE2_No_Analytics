using HarmonyLib;
using Keen.VRage.Core.Extensions;
using Keen.VRage.Core;
using Keen.VRage.Core.Analytics;

namespace NoAnalytics.Patches
{
    [HarmonyPatch(typeof(EngineBuilderExtensions), nameof(EngineBuilderExtensions.AddElasticAnalyticsReporter))]
    internal class EngineBuilderExtensions_AddElasticAnalyticsReporter_Patch
    {
        private static bool Prefix(ref EngineBuilder builder, ref ElasticAnalyticsBuilder ob, ref EngineBuilder __result)
        {
            __result = builder;
            return false;            
        }
    }

}
