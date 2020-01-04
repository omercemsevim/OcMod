using IL.Terraria.ID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace OcMod.Items
{
    class YarakSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Cenngo"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("This is a basic modded sword.");
        }

        public override void SetDefaults()
        {
            item.damage = 500000;
            item.Hitbox = new Microsoft.Xna.Framework.Rectangle { Height = 10000, Width = 10000 };
            item.melee = true;
            item.useTime = 5;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.autoReuse = true;
            item.width = 10000;
            item.height = 10000;
        }
    }
}
