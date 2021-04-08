using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using HarmonyLib;

namespace AmongUsStreamerMode
{
    [BepInPlugin(Id, "Among Us Streamer Mode", "1.2.0")]
    [BepInProcess("Among Us.exe")]
    public class TheOtherRolesPlugin : BasePlugin
    {
        public const string Id = "me.eisbison.streamermode";
        public Harmony Harmony { get; } = new Harmony(Id);

        public override void Load() {
            Harmony.PatchAll();
        }
    }
}
