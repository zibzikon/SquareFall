using Entitas;
using Kernel.ECSIntegration;

namespace Kernel.Systems
{
    public class InitializePlayerSystem : IInitializeSystem
    {
        private readonly IGameEntityCreator _entityCreator;

        public InitializePlayerSystem(IGameEntityCreator entityCreator)
        {
            _entityCreator = entityCreator;
        }
        
        public void Initialize()
        {
            var player = _entityCreator.CreateEmpty();
            
            player.isPlayer = true;
            
            player.AddScore(0);
        }
    }
}