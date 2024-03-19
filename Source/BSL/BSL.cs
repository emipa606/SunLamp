using System.Reflection;
using HarmonyLib;
using Verse;

namespace BSL;

[StaticConstructorOnStartup]
public class BSL
{
    static BSL()
    {
        new Harmony("com.github.toywalrus.bsl").PatchAll(Assembly.GetExecutingAssembly());
    }
}