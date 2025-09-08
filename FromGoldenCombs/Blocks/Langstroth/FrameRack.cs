using FromGoldenCombs.BlockEntities;
using FromGoldenCombs.Blocks.Langstroth;
using FromGoldenCombs.Util.Config;
using Vintagestory.API.Common;
using Vintagestory.API.MathTools;

namespace FromGoldenCombs.Blocks
{
    class FrameRack : LangstrothCore
    {
        // Todo: Add interaction help
        public override void OnLoaded(ICoreAPI api)
        {
            base.OnLoaded(api);
        }

        /// <summary>Called when player right clicks the block</summary>
        /// <param name="world">The world.</param>
        /// <param name="byPlayer">The by player.</param>
        /// <param name="blockSel">The Selected Block.</param>
        public override bool OnBlockInteractStart(IWorldAccessor world, IPlayer byPlayer, BlockSelection blockSel)
        {
            if (world.BlockAccessor.GetBlockEntity(blockSel.Position) is BEFrameRack beFrameRack)
            {
                beFrameRack.updateMeshes();
                beFrameRack.MarkDirty(true);
                return beFrameRack.OnInteract(byPlayer, blockSel);
            }
            return false;
        }
    }
}
