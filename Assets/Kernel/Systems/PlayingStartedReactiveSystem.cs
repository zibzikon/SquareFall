using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems
{
    public abstract class PlayingStartedReactiveSystem : ReactiveSystem<GameEntity>
    {
        protected PlayingStartedReactiveSystem(GameContext game) : base(game) { }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) 
            => context.CreateCollector(Playing.Added());

        protected override bool Filter(GameEntity gameState) => AllOf(GameState).Matches(gameState);
        
    }
}