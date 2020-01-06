using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OcMod.Items
{
    class NiceArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nice Arrow");
        }

        //arrow properties.
        public override void SetDefaults()
        {
            item.damage = 25;
            item.ranged = true;
            item.width = 8;
            item.height = 12;
            item.maxStack = 999;
            item.consumable = true;
            item.value = Item.buyPrice(copper: 10);
            item.rare = 5;

            //this creates the projectile, you give it the name of the projectile file.
            item.shoot = mod.ProjectileType("NiceProjectile");
            //speed of the projectile.
            item.shootSpeed = 4f;
            //make the item be ammo as an arrow.
            item.ammo = AmmoID.Arrow;
        }

        //if you want to add receipe do here.
    }
}
