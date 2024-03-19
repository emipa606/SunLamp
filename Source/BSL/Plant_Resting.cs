using HarmonyLib;
using RimWorld;
using Verse;

namespace BSL;

[HarmonyPatch(typeof(Plant))]
[HarmonyPatch("Resting", MethodType.Getter)]
public static class Plant_Resting
{
    [HarmonyPostfix]
    public static void IsResting(Plant __instance, ref bool __result)
    {
        var isInBasin = false;
        foreach (var cri in __instance.OccupiedRect())
        {
            var thingList = __instance.Map.thingGrid.ThingsListAt(cri);
            foreach (var thing in thingList)
            {
                if (thing is not Building_PlantGrower)
                {
                    continue;
                }

                isInBasin = true;
                break;
            }
        }

        if (isInBasin)
        {
            __result = false;
        }
    }
}