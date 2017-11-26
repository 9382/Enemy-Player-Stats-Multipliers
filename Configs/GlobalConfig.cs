
using System;
using System.IO;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;

namespace WhisStatsConfig
{

	public static class GlobalConfig
	{
		public static float GlobalEnemySpawnRateMultiplier = 1.0f;
		public static float GlobalEnemySpawnCapMultiplier = 1.0f;

		public static float GlobalEnemyHealthMultiplier = 1.0f;
		public static float GlobalEnemyDamageMultiplier = 1.0f;
		public static float GlobalProjectileDamageMultiplier = 1.0f;
		public static float GlobalEnemyDefenseMultiplier = 1.0f;
		public static float GlobalEnemyKnockbackMultiplier = 1.0f;
		//public static float GlobalNonBossKnockbackMultiplier = 1.0f;
		//public static float GlobalEnemyScaleMultiplier = 1.0f;
		public static float GlobalEnemyMoneyMultiplier = 1.0f;
		//public static float GlobalEnemyMoveSpeedMultiplier = 1.0f;
		public static float GlobalArmorDefenseMultiplier = 1.0f; //changed to "armordefense"
		public static float GlobalItemDamageMultiplier = 1.0f;
		public static float GlobalPlayerHealthMultiplier = 1.0f;
		public static float GlobalPlayerHealthRegenMultiplier = 1.0f;
		public static float GlobalPlayerManaMultiplier = 1.0f;
		public static float GlobalPlayerDefenseMultiplier = 1.0f;
		public static float GlobalPlayerCritChanceMultiplier = 1.0f;

		public static float GlobalBossHealthMultiplier = 1.0f;
		public static float GlobalBossDamageMultiplier = 1.0f;
		public static float GlobalBossDefenseMultiplier = 1.0f;
		public static float GlobalBossKnockbackMultiplier = 1.0f;
		public static float GlobalBossScaleMultiplier = 1.0f;
		public static float GlobalBossMoneyMultiplier = 1.0f;

		public static float HardmodeGlobalEnemyHealthMultiplier = 1.0f;
		public static float HardmodeGlobalEnemyDamageMultiplier = 1.0f;
		public static float HardmodeGlobalProjectileDamageMultiplier = 1.0f;
		public static float HardmodeGlobalEnemyDefenseMultiplier = 1.0f;
		public static float HardmodeGlobalEnemyKnockbackMultiplier = 1.0f;
		//public static float HardmodeGlobalNonBossKnockbackMultiplier = 1.0f;
		public static float HardmodeGlobalEnemyMoneyMultiplier = 1.0f;

		public static float HardmodeGlobalBossHealthMultiplier = 1.0f;
		public static float HardmodeGlobalBossDamageMultiplier = 1.0f;
		public static float HardmodeGlobalBossDefenseMultiplier = 1.0f;
		public static float HardmodeGlobalBossKnockbackMultiplier = 1.0f;
		public static float HardmodeGlobalBossMoneyMultiplier = 1.0f;

		public static float PostMoonLordGlobalEnemyHealthMultiplier = 1.0f;
		public static float PostMoonLordGlobalEnemyDamageMultiplier = 1.0f;
		public static float PostMoonLordGlobalProjectileDamageMultiplier = 1.0f;
		public static float PostMoonLordGlobalEnemyDefenseMultiplier = 1.0f;
		public static float PostMoonLordGlobalEnemyKnockbackMultiplier = 1.0f;
		//public static float PostMoonLordGlobalNonBossKnockbackMultiplier = 1.0f;
		public static float PostMoonLordGlobalEnemyMoneyMultiplier = 1.0f;

		public static float PostMoonLordGlobalBossHealthMultiplier = 1.0f;
		public static float PostMoonLordGlobalBossDamageMultiplier = 1.0f;
		public static float PostMoonLordGlobalBossDefenseMultiplier = 1.0f;
		public static float PostMoonLordGlobalBossKnockbackMultiplier = 1.0f;
		public static float PostMoonLordGlobalBossMoneyMultiplier = 1.0f;

		static string ConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "GlobalStatsConfig.json");

		static Preferences Configuration = new Preferences(ConfigPath);

		public static void Load()
		{
			bool success = ReadConfig();

			if(!success)
			{
				//ErrorLogger.Log("Failed to read Enemy Stats Config's global config file! Recreating global config...");
				CreateConfig();
			}
		}

		static bool ReadConfig()
		{
			if(Configuration.Load())
			{
				Configuration.Get("GlobalEnemySpawnRateMultiplier", ref GlobalEnemySpawnRateMultiplier);
				Configuration.Get("GlobalEnemySpawnCapMultiplier", ref GlobalEnemySpawnCapMultiplier);
				Configuration.Get("GlobalEnemyHealthMultiplier", ref GlobalEnemyHealthMultiplier);
				Configuration.Get("GlobalEnemyDamageMultiplier", ref GlobalEnemyDamageMultiplier);
				Configuration.Get("GlobalProjectileDamageMultiplier", ref GlobalProjectileDamageMultiplier);
				Configuration.Get("GlobalEnemyDefenseMultiplier", ref GlobalEnemyDefenseMultiplier);
				Configuration.Get("GlobalEnemyKnockbackMultiplier", ref GlobalEnemyKnockbackMultiplier);
				//Configuration.Get("GlobalNonBossKnockbackMultiplier", ref GlobalNonBossKnockbackMultiplier);
				//Configuration.Get("GlobalEnemyScaleMultiplier", ref GlobalEnemyScaleMultiplier);
				Configuration.Get("GlobalEnemyMoneyMultiplier", ref GlobalEnemyMoneyMultiplier);
				//Configuration.Get("GlobalEnemyMoveSpeedMultiplier", ref GlobalEnemyMoveSpeedMultiplier);

				Configuration.Get("GlobalItemDefenseMultiplier", ref GlobalArmorDefenseMultiplier); // Old Values handling
				if(GlobalArmorDefenseMultiplier == 1.0f) {
					Configuration.Get("GlobalArmorDefenseMultiplier", ref GlobalArmorDefenseMultiplier); // new value
				}
				Configuration.Get("GlobalItemDamageMultiplier", ref GlobalItemDamageMultiplier);
				Configuration.Get("GlobalPlayerHealthMultiplier", ref GlobalPlayerHealthMultiplier);
				Configuration.Get("GlobalPlayerHealthRegenMultiplier", ref GlobalPlayerHealthRegenMultiplier);
				Configuration.Get("GlobalPlayerManaMultiplier", ref GlobalPlayerManaMultiplier);
				Configuration.Get("GlobalPlayerDefenseMultiplier", ref GlobalPlayerDefenseMultiplier);
				Configuration.Get("GlobalPlayerCritChanceMultiplier", ref GlobalPlayerCritChanceMultiplier);

				Configuration.Get("GlobalBossHealthMultiplier", ref GlobalBossHealthMultiplier);
				Configuration.Get("GlobalBossDamageMultiplier", ref GlobalBossDamageMultiplier);
				Configuration.Get("GlobalBossDefenseMultiplier", ref GlobalBossDefenseMultiplier);
				Configuration.Get("GlobalBossKnockbackMultiplier", ref GlobalBossKnockbackMultiplier);
				Configuration.Get("GlobalBossScaleMultiplier", ref GlobalBossScaleMultiplier);
				Configuration.Get("GlobalBossMoneyMultiplier", ref GlobalBossMoneyMultiplier);

				Configuration.Get("HardmodeGlobalEnemyHealthMultiplier", ref HardmodeGlobalEnemyHealthMultiplier);
				Configuration.Get("HardmodeGlobalEnemyDamageMultiplier", ref HardmodeGlobalEnemyDamageMultiplier);
				Configuration.Get("HardmodeGlobalProjectileDamageMultiplier", ref HardmodeGlobalProjectileDamageMultiplier);
				Configuration.Get("HardmodeGlobalEnemyDefenseMultiplier", ref HardmodeGlobalEnemyDefenseMultiplier);
				Configuration.Get("HardmodeGlobalEnemyKnockbackMultiplier", ref HardmodeGlobalEnemyKnockbackMultiplier);
				//Configuration.Get("HardmodeGlobalNonBossKnockbackMultiplier", ref HardmodeGlobalNonBossKnockbackMultiplier);
				Configuration.Get("HardmodeGlobalEnemyMoneyMultiplier", ref HardmodeGlobalEnemyMoneyMultiplier);

				Configuration.Get("HardmodeGlobalBossHealthMultiplier", ref HardmodeGlobalBossHealthMultiplier);
				Configuration.Get("HardmodeGlobalBossDamageMultiplier", ref HardmodeGlobalBossDamageMultiplier);
				Configuration.Get("HardmodeGlobalBossDefenseMultiplier", ref HardmodeGlobalBossDefenseMultiplier);
				Configuration.Get("HardmodeGlobalBossKnockbackMultiplier", ref HardmodeGlobalBossKnockbackMultiplier);
				Configuration.Get("HardmodeGlobalBossMoneyMultiplier", ref HardmodeGlobalBossMoneyMultiplier);

				Configuration.Get("PostMoonLordGlobalEnemyHealthMultiplier", ref PostMoonLordGlobalEnemyHealthMultiplier);
				Configuration.Get("PostMoonLordGlobalEnemyDamageMultiplier", ref PostMoonLordGlobalEnemyDamageMultiplier);
				Configuration.Get("PostMoonLordGlobalProjectileDamageMultiplier", ref PostMoonLordGlobalProjectileDamageMultiplier);
				Configuration.Get("PostMoonLordGlobalEnemyDefenseMultiplier", ref PostMoonLordGlobalEnemyDefenseMultiplier);
				Configuration.Get("PostMoonLordGlobalEnemyKnockbackMultiplier", ref PostMoonLordGlobalEnemyKnockbackMultiplier);
				//Configuration.Get("PostMoonLordGlobalNonBossKnockbackMultiplier", ref PostMoonLordGlobalNonBossKnockbackMultiplier);
				Configuration.Get("PostMoonLordGlobalEnemyMoneyMultiplier", ref PostMoonLordGlobalEnemyMoneyMultiplier);

				Configuration.Get("PostMoonLordGlobalBossHealthMultiplier", ref PostMoonLordGlobalBossHealthMultiplier);
				Configuration.Get("PostMoonLordGlobalBossDamageMultiplier", ref PostMoonLordGlobalBossDamageMultiplier);
				Configuration.Get("PostMoonLordGlobalBossDefenseMultiplier", ref PostMoonLordGlobalBossDefenseMultiplier);
				Configuration.Get("PostMoonLordGlobalBossKnockbackMultiplier", ref PostMoonLordGlobalBossKnockbackMultiplier);
				Configuration.Get("PostMoonLordGlobalBossMoneyMultiplier", ref PostMoonLordGlobalBossMoneyMultiplier);
			}
			return false;
		}

		static void CreateConfig()
		{
			Configuration.Clear();
				Configuration.Put("GlobalEnemySpawnRateMultiplier", GlobalEnemySpawnRateMultiplier);
				Configuration.Put("GlobalEnemySpawnCapMultiplier", GlobalEnemySpawnCapMultiplier);
				Configuration.Put("GlobalEnemyHealthMultiplier", GlobalEnemyHealthMultiplier);
				Configuration.Put("GlobalEnemyDamageMultiplier", GlobalEnemyDamageMultiplier);
				Configuration.Put("GlobalProjectileDamageMultiplier", GlobalProjectileDamageMultiplier);
				Configuration.Put("GlobalEnemyDefenseMultiplier", GlobalEnemyDefenseMultiplier);
				Configuration.Put("GlobalEnemyKnockbackMultiplier", GlobalEnemyKnockbackMultiplier);
				//Configuration.Put("GlobalNonBossKnockbackMultiplier", GlobalNonBossKnockbackMultiplier);
				//Configuration.Put("GlobalEnemyScaleMultiplier", GlobalEnemyScaleMultiplier);
				Configuration.Put("GlobalEnemyMoneyMultiplier", GlobalEnemyMoneyMultiplier);
				//Configuration.Put("GlobalEnemyMoveSpeedMultiplier", GlobalEnemyMoveSpeedMultiplier);
				Configuration.Put("GlobalArmorDefenseMultiplier", GlobalArmorDefenseMultiplier);
				Configuration.Put("GlobalItemDamageMultiplier", GlobalItemDamageMultiplier);
				Configuration.Put("GlobalPlayerHealthMultiplier", GlobalPlayerHealthMultiplier);
				Configuration.Put("GlobalPlayerHealthRegenMultiplier", GlobalPlayerHealthRegenMultiplier);
				Configuration.Put("GlobalPlayerManaMultiplier", GlobalPlayerManaMultiplier);
				Configuration.Put("GlobalPlayerDefenseMultiplier", GlobalPlayerDefenseMultiplier);
				Configuration.Put("GlobalPlayerCritChanceMultiplier", GlobalPlayerCritChanceMultiplier);

				Configuration.Put("GlobalBossHealthMultiplier", GlobalBossHealthMultiplier);
				Configuration.Put("GlobalBossDamageMultiplier", GlobalBossDamageMultiplier);
				Configuration.Put("GlobalBossDefenseMultiplier", GlobalBossDefenseMultiplier);
				Configuration.Put("GlobalBossKnockbackMultiplier", GlobalBossKnockbackMultiplier);
				Configuration.Put("GlobalBossMoneyMultiplier", GlobalBossMoneyMultiplier);
				Configuration.Put("GlobalBossScaleMultiplier", GlobalBossScaleMultiplier);

				Configuration.Put("HardmodeGlobalEnemyHealthMultiplier", HardmodeGlobalEnemyHealthMultiplier);
				Configuration.Put("HardmodeGlobalEnemyDamageMultiplier", HardmodeGlobalEnemyDamageMultiplier);
				Configuration.Put("HardmodeGlobalProjectileDamageMultiplier", HardmodeGlobalProjectileDamageMultiplier);
				Configuration.Put("HardmodeGlobalEnemyDefenseMultiplier", HardmodeGlobalEnemyDefenseMultiplier);
				Configuration.Put("HardmodeGlobalEnemyKnockbackMultiplier", HardmodeGlobalEnemyKnockbackMultiplier);
				//Configuration.Put("HardmodeGlobalNonBossKnockbackMultiplier", HardmodeGlobalNonBossKnockbackMultiplier);
				Configuration.Put("HardmodeGlobalEnemyMoneyMultiplier", HardmodeGlobalEnemyMoneyMultiplier);

				Configuration.Put("HardmodeGlobalBossHealthMultiplier", HardmodeGlobalBossHealthMultiplier);
				Configuration.Put("HardmodeGlobalBossDamageMultiplier", HardmodeGlobalBossDamageMultiplier);
				Configuration.Put("HardmodeGlobalBossDefenseMultiplier", HardmodeGlobalBossDefenseMultiplier);
				Configuration.Put("HardmodeGlobalBossKnockbackMultiplier", HardmodeGlobalBossKnockbackMultiplier);
				Configuration.Put("HardmodeGlobalBossMoneyMultiplier", HardmodeGlobalBossMoneyMultiplier);

				Configuration.Put("PostMoonLordGlobalEnemyHealthMultiplier", PostMoonLordGlobalEnemyHealthMultiplier);
				Configuration.Put("PostMoonLordGlobalEnemyDamageMultiplier", PostMoonLordGlobalEnemyDamageMultiplier);
				Configuration.Put("PostMoonLordGlobalProjectileDamageMultiplier", PostMoonLordGlobalProjectileDamageMultiplier);
				Configuration.Put("PostMoonLordGlobalEnemyDefenseMultiplier", PostMoonLordGlobalEnemyDefenseMultiplier);
				Configuration.Put("PostMoonLordGlobalEnemyKnockbackMultiplier", PostMoonLordGlobalEnemyKnockbackMultiplier);
				//Configuration.Put("PostMoonLordGlobalNonBossKnockbackMultiplier", PostMoonLordGlobalNonBossKnockbackMultiplier);
				Configuration.Put("PostMoonLordGlobalEnemyMoneyMultiplier", PostMoonLordGlobalEnemyMoneyMultiplier);

				Configuration.Put("PostMoonLordGlobalBossHealthMultiplier", PostMoonLordGlobalBossHealthMultiplier);
				Configuration.Put("PostMoonLordGlobalBossDamageMultiplier", PostMoonLordGlobalBossDamageMultiplier);
				Configuration.Put("PostMoonLordGlobalBossDefenseMultiplier", PostMoonLordGlobalBossDefenseMultiplier);
				Configuration.Put("PostMoonLordGlobalBossKnockbackMultiplier", PostMoonLordGlobalBossKnockbackMultiplier);
				Configuration.Put("PostMoonLordGlobalBossMoneyMultiplier", PostMoonLordGlobalBossMoneyMultiplier);

				Configuration.Save();
		}
	}
}