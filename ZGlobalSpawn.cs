
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace WhisStatsConfig
{
	public class ZGlobalSpawn : GlobalNPC //the z is for consistency, no real reason as of now
	{
		public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
		{
			spawnRate = (int)(spawnRate / GlobalConfig.GlobalEnemySpawnRateMultiplier);
			maxSpawns = (int)(maxSpawns * GlobalConfig.GlobalEnemySpawnCapMultiplier);
		}
    }
}