using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace OcMod.Items
{
    class Helm : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Cenngo"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("This is a basic modded sword.");
        }

        public override void SetDefaults()
        {
            item.wornArmor = true;
            item.defense = 5000000;
            item.headSlot = 1;
        }
    }
}
