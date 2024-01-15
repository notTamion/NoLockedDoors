using HarmonyLib;

namespace NoLockedDoors.Patches;

[HarmonyPatch(typeof(DoorLock))]
public class DoorLockPatch
{
    [HarmonyPatch("Update")]
    [HarmonyPrefix]
    static void patchUpdate(ref DoorLock __instance)
    {
        __instance.UnlockDoor();
    }
}