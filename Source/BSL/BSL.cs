using System.Reflection;
using HarmonyLib;
using Verse;

namespace BSL;

[StaticConstructorOnStartup]
public static class BSL
{
    static BSL()
    {
        new Harmony("com.github.toywalrus.bsl").PatchAll(Assembly.GetExecutingAssembly());
    }
}