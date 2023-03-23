using HarmonyLib;
using UnityEngine.UI;
namespace UKGoodMorning
{
    // patches FishingHUD.ShowFishCaught to modify the text to show the size of the fish set in prefs
    [HarmonyPatch(typeof(FishingHUD), nameof(FishingHUD.ShowFishCaught))]
    public class FishingHUDPatch
    {
        // so we can find and modify the fish size text
        const string OBJECT_NAME_1 = "Fish Caught";
        const string OBJECT_NAME_2 = "Fish Size Text";

        static void Postfix(bool show, FishObject fish)
        {
            var objectWeAreLookingFor = FishingHUD.Instance.transform.Find(OBJECT_NAME_1).Find(OBJECT_NAME_2).GetComponent<Text>();
            if(objectWeAreLookingFor != null)
            {
                objectWeAreLookingFor.text = $"SIZE: {UKGoodMorningManager.FishSize}";
            }
        }
    }
}
