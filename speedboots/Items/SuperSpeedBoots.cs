using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace speedboots.Items
{
    public class SuperSpeedBoots : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Speed Boots");
            Tooltip.SetDefault("WAYYYY TOO FAST ':\\");

        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = 100000;
            Item.rare = ItemRarityID.Master;
            Item.defense = 60; // Set the defense value for the helmet
            Item.legSlot = 0;
        }

        public override void UpdateEquip(Player player)
        {
            // Add set bonus effects here, for example:
            player.statLifeMax2 = (player.statLifeMax2/5)*4; // set max life to be 80% of what it would normally be
            player.moveSpeed *= 10;
            player.slowFall = true;
            player.jumpBoost = true;
            player.jumpSpeedBoost = 10;
            player.stepSpeed *= 10;
            player.autoJump = true;
        }

        public override void DrawArmorColor(Player drawPlayer, float shadow, ref Color color, ref int glowMask, ref Color glowMaskColor)
        {
            base.DrawArmorColor(drawPlayer, shadow, ref color, ref glowMask, ref glowMaskColor);
        }

        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ModContent.ItemType<SuperSpeedBoots>());
            recipe.AddIngredient(ItemID.ManaCrystal, 10);
            recipe.AddIngredient(ItemID.HermesBoots, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
