﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace LeagueOfLegend.Items.AttackDamageClass
{
    public class LongSword : ModItem
    {
        public const int PRICE = 350;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault(string.Format("[c/0596aa:+10 Attack Damage]"));
        }

        public override void SetDefaults()
        {
            item.accessory = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType<Items.Gold>(), PRICE);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            AttackDamagePlayer modPlayer = AttackDamagePlayer.ModPlayer(player);
            modPlayer.attackBonus += 10;
        }
    }
}
