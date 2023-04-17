using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems
{
    public abstract class DurationUpReactiveSystem : ReactiveSystem<GameEntity>
    {
        protected DurationUpReactiveSystem(GameContext context) : base(context) { }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(DurationUp);

        protected override bool Filter(GameEntity durationUpEntity)
            => AllOf(Duration).Matches(durationUpEntity);
        
    }
}