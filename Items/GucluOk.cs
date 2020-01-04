using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

namespace OcMod.Items
{
    public class GucluOk : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("tasakli ok");
        }

        //create the item using private variables of ModItem class
        public override void SetDefaults()
        {
            item.damage = 500000;
            item.useAnimation = 10;
            item.useTime = 10;
            item.useStyle = 5;
            item.autoReuse = true;
            item.rare = 13;
            item.width = 40;
            item.height = 40;
            item.UseSound = SoundID.Item1;
            item.knockBack = 6;
            item.shoot = 2;
            item.shootSpeed = 10f;
            item.ranged = true;
            item.crit = 15;
            item.noMelee = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
