using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems
{
    public class InvertMoveDirectionSystem : ReactiveSystem<GameEntity>
    {
        public InvertMoveDirectionSystem(GameContext game) : base(game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(InvertMoveDirection);

        protected override bool Filter(GameEntity movable)
            => AllOf(Movable, MoveDirection).Matches(movable);

        protected override void Execute(List<GameEntity> movables)
        {
            foreach (var movable in movables)
            {
                movable.ReplaceMoveDirection(-movable.moveDirection.Value);
                movable.isInvertMoveDirection = false;
            }
        }
    }
}