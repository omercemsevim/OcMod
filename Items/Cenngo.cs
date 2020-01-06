using Terraria.ID;
using Terraria.ModLoader;

namespace OcMod.Items
{
	public class Cenngo : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cenngo"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Armor Set");
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.useStyle = 5;
			item.autoReuse = true;
			item.holdStyle = 1;
			item.useAnimation = 20;
			item.useTime = 20;
			item.melee = true;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
