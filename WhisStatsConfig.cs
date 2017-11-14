using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WhisStatsConfig
{
	public class WhisStatsConfig : Mod
	{
		public WhisStatsConfig()
		{
			Properties = new ModProperties
			{
				Autoload = true,
			};
		}

		public override void Load()
		{
			GlobalConfig.Load();
		}
	}
}