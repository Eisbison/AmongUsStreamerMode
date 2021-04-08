using System;
using HarmonyLib;
using UnityEngine;

namespace StreamerMode
{
    [HarmonyPatch(typeof(VersionShower), nameof(VersionShower.Start))]
	public static class VersionStartPatch
	{
		private static void Postfix(VersionShower __instance)
		{
            string spacer = new String('\n', 21);
			bool flag = __instance.text.Text.Contains(spacer);
			if (flag)
				__instance.text.Text += "\n[]- Loaded StreamerMode v1.2\n  by [FCCE03FF]Eisbison[]";
			else
				__instance.text.Text += spacer + "[]- Loaded StreamerMode v1.2\n  by [FCCE03FF]Eisbison[]";
		}
	}

    [HarmonyPatch(typeof(GameStartManager), nameof(GameStartManager.Start))]
	public static class GameRoomNamePatch
	{
		// Token: 0x06000002 RID: 2 RVA: 0x000020B1 File Offset: 0x000002B1
		private static void Postfix(GameStartManager __instance)
		{
			GUIUtility.systemCopyBuffer = GANMLJCDGFH.LKMOFAMKMGE(AmongUsClient.Instance.GameId);
			__instance.GameRoomName.Text = "";
		}
	}

    [HarmonyPatch(typeof(TextBox), nameof(TextBox.SetText))]
	public static class JoinGameButtonPatch
	{
		private static void Postfix(TextBox __instance)
		{
			bool flag = __instance.name == "GameIdText";
			if (flag) __instance.outputText.Text = new string('*', __instance.text.Length);
		}
	}
}