using Game.UI.Menu;
using HarmonyLib;
using System.Reflection;

namespace DevPlaygroundOptions.Patches
{
    [HarmonyPatch(typeof(AutomaticSettings), "IsDeveloperOnly")]
    class AutomaticSettings_Patches
    {
        static bool Prefix(PropertyInfo property, ref bool __result)
        {
            __result = false;
            return false;
        }
    }
}
