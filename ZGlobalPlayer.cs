
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
		public override void PostUpdateBuffs()
		{
			player.statLifeMax2 = (int) (player.statLifeMax2 * GlobalConfig.GlobalPlayerHealthMultiplier);
			player.statManaMax2 = (int) (player.statManaMax2 * GlobalConfig.GlobalPlayerManaMultiplier);

		}
		public override void UpdateLifeRegen()
		{
			player.lifeRegen = (int) (player.lifeRegen * GlobalConfig.GlobalPlayerHealthRegenMultiplier);
		}
	}
}