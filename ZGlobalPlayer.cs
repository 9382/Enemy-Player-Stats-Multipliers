
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace WhisStatsConfig.Players
{
	public class ZGlobalStats : ModPlayer //The z is for consistency in naming
	{
		public override void PostUpdateEquips() //PostUpdateBuffs()
		{
			player.statLifeMax2 = (int) (player.statLifeMax2 * GlobalConfig.GlobalPlayerHealthMultiplier);
			player.statManaMax2 = (int) (player.statManaMax2 * GlobalConfig.GlobalPlayerManaMultiplier);
			player.statDefense = (int) (player.statDefense * GlobalConfig.GlobalPlayerDefenseMultiplier);
			player.rangedCrit = (int) (player.rangedCrit * GlobalConfig.GlobalPlayerCritChanceMultiplier);
			player.magicCrit = (int) (player.magicCrit * GlobalConfig.GlobalPlayerCritChanceMultiplier);
			player.meleeCrit = (int) (player.meleeCrit * GlobalConfig.GlobalPlayerCritChanceMultiplier);
			player.thrownCrit = (int) (player.thrownCrit * GlobalConfig.GlobalPlayerCritChanceMultiplier);
			player.wingTimeMax = (int) (player.wingTimeMax * GlobalConfig.GlobalPlayerFlightTimeMultiplier);
		}
		public override void UpdateLifeRegen()
		{
			player.lifeRegen = (int) (player.lifeRegen * GlobalConfig.GlobalPlayerHealthRegenMultiplier);
		}
	}
}