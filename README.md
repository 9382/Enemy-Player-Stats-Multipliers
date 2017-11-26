# Enemy-Player-Stats-Multipliers
a Terraria Tmodloader mod that allows to configure global multipliers

Visit the home page for more info on how to set up your configuration file!

Update 1.0.7: Added GlobalItemManaUsageMultiplier. Because Player Mana has a strange cap and can't go any higher than 400 it seems. (also for example with 20 mana & 10x multiplier the game won't allow you to go past 120 mana which correspond to a 6x multiplier)

Update 1.0.6: Fix for Crit Chance Multiplier. forgot some damage type (thrown)

Update 1.0.5: Added "GlobalPlayerDefenseMultiplier" which this time will multiply ALL player defense globally including, accessories, prefixes, buffs ....

Update 1.0.4: Added Player Crit Chance multipliers. haven't tested over 100% crit chance if you go crazy on them. Keep in mind this makes more damage & also way more knockback when a crit happens (default game behavior, it's just a reminder for balancing).

Update 1.0.3: Fixed items Mana usage being changed due to left over testing code. sorry folks

Update 1.0.2: Renamed "GlobalItemDefenseMultiplier" to "GlobalArmorDefenseMultiplier", your values will be transferred from the old to the new value. reason being that all my testing shows this value only ever affected Armor base defense, prefixes bonus defense never got multiplied. so this new name reflect that.

Update 1.0.1: Fixed items not being considered for player changes, they are now multiplied correctly.

Update 1.0.0: RELEASE. also concatenated the multiple config files in one.

Update 0.9.5: Thanks to JopoJelly, added player health & mana modifiers.

Update 0.9.4: removed specific per mod per boss modifiers too much support.

Update 0.9.3: removed scaling for non-boss, it was causing AI problems for some entities.
 scaling for boss is still here use at your own risk.

Update 0.9.2: removed non boss only knockback modifier, boss & global are enough, can divide if needed.

Update 0.9.1: Fixed global stats. a lot of entities were NOT affected by the changes due to the way they were implemented in game.
This should now be completely fixed. HOWEVER when using cheatsheet NPC browser tool. the values shown in the interface do not correspond. spawning should work fine either way. Thanks to Mirsario for the help.
work on enemy stats config.
version number pushed back
Update 0.9.0: Forked from compa's 
