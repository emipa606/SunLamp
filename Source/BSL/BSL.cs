using System.Reflection;
using HarmonyLib;
using Verse;

namespace BSL;

[StaticConstructorOnStartup]
public class BSL
{
    static BSL()
    {
        var harmony = new Harmony("com.github.toywalrus.bsl");
        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }
}