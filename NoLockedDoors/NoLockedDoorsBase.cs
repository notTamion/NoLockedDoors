using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using NoLockedDoors.Patches;

namespace NoLockedDoors;

[BepInPlugin(modGUID, modName, modVersion)]
public class NoLockedDoorsBase : BaseUnityPlugin
{
    private const string modGUID = "tamion.NoLockedDoors";
    private const string modName = "NoLockedDoors";
    private const string modVersion = "1.0.1";
    
    private readonly Harmony harmony = new Harmony(modGUID);
    internal ManualLogSource logger;
    
    private void Awake()
    {
        logger = BepInEx.Logging.Logger.CreateLogSource(modGUID);
        
        logger.LogInfo("NoLockedDoors loaded");
        
        harmony.PatchAll(typeof(DoorLockPatch));
    }
}