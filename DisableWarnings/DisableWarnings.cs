using HarmonyLib;

using UnityEngine;

public class DisableWarnings : Mod {
    private const string HarmonyId = "dusrdev.disable.warnings";
    private static Harmony s_harmony;

    public void Start() {
        s_harmony = new Harmony(HarmonyId);
        s_harmony.PatchAll();
        Debug.Log("Mod DisableWarnings has been loaded!");
    }

    public void OnModUnload() {
        s_harmony.UnpatchAll(HarmonyId);
        Debug.Log("Mod DisableWarnings has been unloaded!");
    }
}

[HarmonyPatch(typeof(Application))]
[HarmonyPatch("CallLogCallback")]
public sealed class IgnoreWarningPatch {
    [HarmonyPrefix]
    static bool CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) {
        return type != LogType.Warning;
    }
}