using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace OcMod.Items
{
    public class Pickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Cenngo"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("This is a basic modded sword.");
        }

        public override void SetDefaults()
        {
            item.pick = 1000000;
            item.damage = 500000;
            item.useTime = 1;
            item.useAnimation = 10;
            item.melee = true;
            item.useStyle = 1;
            item.autoReuse = true;
            item.width = 40;
            item.height = 40;
            item.tileBoost = 1000000;
        }
    }
}
