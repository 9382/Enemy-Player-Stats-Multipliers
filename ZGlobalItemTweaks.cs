
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace WhisStatsConfig.Items
{
	public class ZGlobalItems : GlobalItem //the z is for consistency, no real reason as of now
	{
		public override void SetDefaults(Item item)
		{
			item.defense = (int)(item.defense * GlobalConfig.GlobalArmorDefenseMultiplier);
			item.damage = (int)(item.damage * GlobalConfig.GlobalItemDamageMultiplier);
			item.mana = (int)(item.mana * GlobalConfig.GlobalItemManaUsageMultiplier);
		}
	}
}