using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace OcMod.Projectiles
{
    public class NiceProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Suku Arrow");
        }

        //set properties of this arrow.
        //in terraria you create a projectile than append its properties to an item. 
        //For example this projectile will be used as an arrow so an arrow is created in the items folder.
        public override void SetDefaults()
        {
            //width and height of the projectile hitbox
            projectile.width = 8;
            projectile.height = 12;

            //determine the AI style of the projectile, look up what number corresponds to what online.
            //1 - Arrow
            projectile.aiStyle = 1;

            //make sure the projectile does not hit friendly targets.
            projectile.friendly = true;

            //how many enemies does the projectile hit.
            projectile.penetrate = 5;

            //damage type.
            projectile.ranged = true;

            //set the projectile to be an arrow.
            projectile.arrow = true;
        }

        //function to randomize if an object is created when the projectile hits the floor.
        //you can get some arrows back.
        public override void Kill(int timeLeft)
        {
            if(projectile.owner == Main.myPlayer)
            {
                int item = Main.rand.NextBool(5) ? Item.NewItem(projectile.getRect(), mod.ItemType("Nice Arrow")) : 0;
            }
        }

    }
}