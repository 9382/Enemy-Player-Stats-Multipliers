
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace WhisStatsConfig.NPCs
{
	public class ZGlobalStats : GlobalNPC //The z is to make sure it loads after specific npc changes
	{
		// old function now unused but kept for history. Thanks to Mirsario
		/*
		public override void SetDefaults(NPC npc)
		{


			if (npc.lifeMax > 5 && npc.damage > 0) //affects normal enemies and town npcs
			{
				npc.lifeMax = (int)(npc.lifeMax * GlobalConfig.GlobalEnemyHealthMultiplier);
				npc.defense = (int)(npc.defense * GlobalConfig.GlobalEnemyDefenseMultiplier);
				npc.knockBackResist = (npc.knockBackResist * GlobalConfig.GlobalEnemyKnockbackMultiplier);
				npc.scale = (npc.scale * GlobalConfig.GlobalEnemyScaleMultiplier);
				npc.value = (npc.value * GlobalConfig.GlobalEnemyMoneyMultiplier);
				//npc.velocity = (GlobalConfig.GlobalEnemyMoveSpeedMultiplier);

			}
			if (npc.lifeMax > 0 && npc.damage > 0) //affects normal enemies and living projectiles like fireballs, also technically affects town npcs but they don't use their attack stat
			{

				npc.damage = (int)(npc.damage * GlobalConfig.GlobalEnemyDamageMultiplier);

			}
			if (npc.boss) //affects bosses
			{
				ErrorLogger.Log("EnemyStatsConfig " + npc.FullName + " type:" + npc.type + " isboss:" + npc.boss + " lifemax:" + npc.lifeMax + " dmg:" + npc.damage);
				npc.lifeMax = (int)(npc.lifeMax * GlobalConfig.GlobalBossHealthMultiplier);
				npc.damage = (int)(npc.damage * GlobalConfig.GlobalBossDamageMultiplier);
				npc.defense = (int)(npc.defense * GlobalConfig.GlobalBossDefenseMultiplier);
				npc.knockBackResist = (npc.knockBackResist * GlobalConfig.GlobalBossKnockbackMultiplier);
				npc.scale = (npc.scale * GlobalConfig.GlobalBossScaleMultiplier);
				npc.value = (npc.value * GlobalConfig.GlobalBossMoneyMultiplier);
			}
			else //for non boss only specific stats, all one of em
			{
				npc.knockBackResist = (npc.knockBackResist * GlobalConfig.GlobalNonBossKnockbackMultiplier);
			}
			if (npc.lifeMax > 10 && npc.damage == 0) //affects enemies with no attack while avoiding critters
			{
				npc.lifeMax = (int)(npc.lifeMax * GlobalConfig.GlobalEnemyHealthMultiplier);
				npc.defense = (int)(npc.defense * GlobalConfig.GlobalEnemyDefenseMultiplier);
				npc.knockBackResist = (npc.knockBackResist * GlobalConfig.GlobalEnemyKnockbackMultiplier);
				npc.value = (npc.value * GlobalConfig.GlobalEnemyMoneyMultiplier);
				//npc.velocity = (npc.velocity * GlobalConfig.GlobalEnemyMoveSpeedMultiplier);
			}
			if (Main.hardMode) //hard mode starts here
			{
				if (npc.lifeMax > 5 && npc.damage > 0)
				{
					npc.lifeMax = (int)(npc.lifeMax * GlobalConfig.HardmodeGlobalEnemyHealthMultiplier);
					npc.defense = (int)(npc.defense * GlobalConfig.HardmodeGlobalEnemyDefenseMultiplier);
					npc.knockBackResist = (npc.knockBackResist * GlobalConfig.HardmodeGlobalEnemyKnockbackMultiplier);
					npc.value = (npc.value * GlobalConfig.HardmodeGlobalEnemyMoneyMultiplier);
				}
				if (npc.lifeMax > 0 && npc.damage > 0)
				{

					npc.damage = (int)(npc.damage * GlobalConfig.HardmodeGlobalEnemyDamageMultiplier);

				}
				if (npc.boss)
				{
					npc.lifeMax = (int)(npc.lifeMax * GlobalConfig.HardmodeGlobalBossHealthMultiplier);
					npc.damage = (int)(npc.damage * GlobalConfig.HardmodeGlobalBossDamageMultiplier);
					npc.defense = (int)(npc.defense * GlobalConfig.HardmodeGlobalBossDefenseMultiplier);
					npc.knockBackResist = (npc.knockBackResist * GlobalConfig.HardmodeGlobalBossKnockbackMultiplier);
					npc.value = (npc.value * GlobalConfig.HardmodeGlobalBossMoneyMultiplier);
				}
				else
				{
				npc.knockBackResist = (npc.knockBackResist * GlobalConfig.HardmodeGlobalNonBossKnockbackMultiplier);
				}
				if (npc.lifeMax > 10 && npc.damage == 0)
				{
					npc.lifeMax = (int)(npc.lifeMax * GlobalConfig.HardmodeGlobalEnemyHealthMultiplier);
					npc.defense = (int)(npc.defense * GlobalConfig.HardmodeGlobalEnemyDefenseMultiplier);
					npc.knockBackResist = (npc.knockBackResist * GlobalConfig.HardmodeGlobalEnemyKnockbackMultiplier);
					npc.value = (npc.value * GlobalConfig.HardmodeGlobalEnemyMoneyMultiplier);
				}
			}
			if (NPC.downedMoonlord) //post manlord starts here
			{
				if (npc.lifeMax > 5 && npc.damage > 0)
				{
					npc.lifeMax = (int)(npc.lifeMax * GlobalConfig.PostMoonLordGlobalEnemyHealthMultiplier);
					npc.defense = (int)(npc.defense * GlobalConfig.PostMoonLordGlobalEnemyDefenseMultiplier);
					npc.knockBackResist = (npc.knockBackResist * GlobalConfig.PostMoonLordGlobalEnemyKnockbackMultiplier);
					npc.value = (npc.value * GlobalConfig.PostMoonLordGlobalEnemyMoneyMultiplier);
				}
				if (npc.lifeMax > 0 && npc.damage > 0)
				{

					npc.damage = (int)(npc.damage * GlobalConfig.PostMoonLordGlobalEnemyDamageMultiplier);

				}
				if (npc.boss)
				{
					npc.lifeMax = (int)(npc.lifeMax * GlobalConfig.PostMoonLordGlobalBossHealthMultiplier);
					npc.damage = (int)(npc.damage * GlobalConfig.PostMoonLordGlobalBossDamageMultiplier);
					npc.defense = (int)(npc.defense * GlobalConfig.PostMoonLordGlobalBossDefenseMultiplier);
					npc.knockBackResist = (npc.knockBackResist * GlobalConfig.PostMoonLordGlobalBossKnockbackMultiplier);
					npc.value = (npc.value * GlobalConfig.PostMoonLordGlobalBossMoneyMultiplier);
				}
				else
				{
				npc.knockBackResist = (npc.knockBackResist * GlobalConfig.PostMoonLordGlobalNonBossKnockbackMultiplier);
				}
				if (npc.lifeMax > 10 && npc.damage == 0)
				{
					npc.lifeMax = (int)(npc.lifeMax * GlobalConfig.PostMoonLordGlobalEnemyHealthMultiplier);
					npc.defense = (int)(npc.defense * GlobalConfig.PostMoonLordGlobalEnemyDefenseMultiplier);
					npc.knockBackResist = (npc.knockBackResist * GlobalConfig.PostMoonLordGlobalEnemyKnockbackMultiplier);
					npc.value = (npc.value * GlobalConfig.PostMoonLordGlobalEnemyMoneyMultiplier);
				}
			}
		}
		*/
		public override bool InstancePerEntity { get { return true; } }
		public bool initializedGE;
		private float BossDmgMult;
		private float BossLifeMax;
		private float BossDefense;
		private float BossKnockback; // GlobalConfig.GlobalNonBossKnockbackMultiplier is now disabled
		private float BossScale;
		private float BossMoney;
		private float AdditionalDmgMult;
		private float AdditionalLifeMax;
		private float AdditionalDefense;
		private float AdditionalKnockback;
		private float AdditionalScale;
		private float AdditionalMoney;
		public override bool PreAI(NPC npc)
		{
			if ( initializedGE || npc.lifeMax <= 0 ) { return true; }
			// ErrorLogger.Log("EnemyStatsConfig " + npc.GivenOrTypeName + " type:" + npc.type + " isboss:" + npc.boss + " lifemax:" + npc.lifeMax + " dmg:" + npc.damage);
			// Do Stats Changes Here. These stats won't be shown in cheatsheet NPC browser;
			BossDmgMult = 1.0f;
			BossLifeMax = 1.0f;
			BossDefense = 1.0f;
			BossKnockback = 1.0f; // GlobalConfig.GlobalNonBossKnockbackMultiplier is now disabled
			BossScale = 1.0f;
			BossMoney = 1.0f;
			AdditionalDmgMult = GlobalConfig.GlobalEnemyDamageMultiplier;
			AdditionalLifeMax = GlobalConfig.GlobalEnemyHealthMultiplier;
			AdditionalDefense = GlobalConfig.GlobalEnemyDefenseMultiplier;
			AdditionalKnockback = GlobalConfig.GlobalEnemyKnockbackMultiplier;
			AdditionalScale = 1.0f; // GlobalConfig.GlobalEnemyScaleMultiplier; disabled for non-boss
			AdditionalMoney = GlobalConfig.GlobalEnemyMoneyMultiplier;

			if (npc.boss)
			{
				BossDmgMult = GlobalConfig.GlobalBossDamageMultiplier;
				BossLifeMax = GlobalConfig.GlobalBossHealthMultiplier;
				BossDefense = GlobalConfig.GlobalBossDefenseMultiplier;
				BossKnockback = GlobalConfig.GlobalBossKnockbackMultiplier;
				BossScale = GlobalConfig.GlobalBossScaleMultiplier;
				BossMoney = GlobalConfig.GlobalBossMoneyMultiplier;
				if (Main.hardMode)
				{
					BossDmgMult *= GlobalConfig.HardmodeGlobalBossDamageMultiplier;
					BossLifeMax *= GlobalConfig.HardmodeGlobalBossHealthMultiplier;
					BossDefense *= GlobalConfig.HardmodeGlobalBossDefenseMultiplier;
					BossKnockback *= GlobalConfig.HardmodeGlobalBossKnockbackMultiplier;
					BossMoney *= GlobalConfig.HardmodeGlobalBossMoneyMultiplier;
					if (NPC.downedMoonlord)
					{
						BossDmgMult *= GlobalConfig.PostMoonLordGlobalBossDamageMultiplier;
						BossLifeMax *= GlobalConfig.PostMoonLordGlobalBossHealthMultiplier;
						BossDefense *= GlobalConfig.PostMoonLordGlobalBossDefenseMultiplier;
						BossKnockback *= GlobalConfig.PostMoonLordGlobalBossKnockbackMultiplier;
						BossMoney *= GlobalConfig.PostMoonLordGlobalBossMoneyMultiplier;
					}
				}
			}
			if (Main.hardMode)
			{
				AdditionalDmgMult *= GlobalConfig.HardmodeGlobalEnemyDamageMultiplier;
				AdditionalLifeMax *= GlobalConfig.HardmodeGlobalEnemyHealthMultiplier;
				AdditionalDefense *= GlobalConfig.HardmodeGlobalEnemyDefenseMultiplier;
				AdditionalKnockback *= GlobalConfig.HardmodeGlobalEnemyKnockbackMultiplier;
				AdditionalMoney *= GlobalConfig.HardmodeGlobalEnemyMoneyMultiplier;
				if (NPC.downedMoonlord)
				{
					AdditionalDmgMult *= GlobalConfig.PostMoonLordGlobalEnemyDamageMultiplier;
					AdditionalLifeMax *= GlobalConfig.PostMoonLordGlobalEnemyHealthMultiplier;
					AdditionalDefense *= GlobalConfig.PostMoonLordGlobalEnemyDefenseMultiplier;
					AdditionalKnockback *= GlobalConfig.PostMoonLordGlobalEnemyKnockbackMultiplier;
					AdditionalMoney *= GlobalConfig.PostMoonLordGlobalEnemyMoneyMultiplier;
				}
			}

			npc.damage = (int)(npc.damage * AdditionalDmgMult * BossDmgMult);
			if (npc.lifeMax > 5)
			{
				npc.scale *= AdditionalScale * BossScale;
				npc.value *= AdditionalMoney * BossMoney;
			}
			npc.lifeMax = (int)(npc.lifeMax * AdditionalLifeMax * BossLifeMax);
			npc.defense = (int)(npc.defense * AdditionalDefense * BossDefense);
			npc.knockBackResist *= AdditionalKnockback * BossKnockback;

			npc.life = npc.lifeMax;
			initializedGE = true;
			return true;
		}
	}
}