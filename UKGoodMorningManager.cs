using BepInEx;
using HarmonyLib;

namespace UKGoodMorning
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
    public class UKGoodMorningManager : BaseUnityPlugin
    {
        public static int FishSize => PrefsManager.Instance == null ? 2 : PrefsManager.Instance.GetIntLocal("fish_size", 2);

        public void Awake()
        {
            Logger.LogInfo("I ONLY SAY MORNING");

            // Patch fishing size
            var harmony = Harmony.CreateAndPatchAll(typeof(FishingHUDPatch)); // Patches display text size
        }
    }
}
