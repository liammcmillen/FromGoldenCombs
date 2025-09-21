using FromGoldenCombs.Blocks.Langstroth;
using Vintagestory.API.Common;

namespace VFromGoldenCombs.Blocks.Langstroth
{
    class LangstrothBase : LangstrothCore
    {
        //Core block for all Langstroth Blocks
        /// <summary>Called when player right clicks this block.</summary>
        public override bool OnBlockInteractStart(IWorldAccessor world, IPlayer byPlayer, BlockSelection blockSel)
        {
            ItemSlot slot = byPlayer.InventoryManager.ActiveHotbarSlot;
            if (slot.Empty)
            {
                ItemStack stack = new(api.World.BlockAccessor.GetBlock(api.World.BlockAccessor.GetBlock(blockSel.Position, 0).CodeWithVariant("side", "east")));
                api.World.BlockAccessor.SetBlock(0, blockSel.Position);
                return byPlayer.InventoryManager.TryGiveItemstack(stack);
            }
            return base.OnBlockInteractStart(world, byPlayer, blockSel);
        }

    }
}
