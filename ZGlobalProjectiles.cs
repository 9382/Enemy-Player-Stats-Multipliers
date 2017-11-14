
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace WhisStatsConfig.Projectiles
{
	public class ZGlobalShoot : GlobalProjectile //the z is for consistency, no real reason as of now
    {
		public override void ModifyHitPlayer(Projectile projectile, Player target, ref int damage, ref bool crit)
        {
			if (projectile.hostile) //to make sure that only baddies projectiles are affected
			{
			 damage = (int)(damage * GlobalConfig.GlobalProjectileDamageMultiplier);
				if (Main.hardMode)
				{
				damage = (int)(damage * GlobalConfig.HardmodeGlobalProjectileDamageMultiplier);
				}
				if (NPC.downedMoonlord)
				{
				damage = (int)(damage * GlobalConfig.PostMoonLordGlobalProjectileDamageMultiplier);
				}
			}
			return;
        }
    }
}