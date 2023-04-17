using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems
{
    public abstract class CollisionReactiveSystem : ReactiveSystem<GameEntity>
    {
        protected CollisionReactiveSystem(GameContext game) : base(game) { }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(CollidedEntityId);

        protected override bool Filter(GameEntity collidedEntity)
            => AllOf(Collisionable).Matches(collidedEntity);
    }
}