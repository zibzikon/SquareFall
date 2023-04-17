using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems
{
    public class KillMovingCircleOnCollidedWithHardFallingSquare : CollisionReactiveSystem
    {
        private readonly IGroup<GameEntity> _fallingCircles;

        public KillMovingCircleOnCollidedWithHardFallingSquare(GameContext game) : base(game)
        {
            _fallingCircles = game.GetGroup(AllOf(Id, FallingSquare, Collisionable));
        }

        protected override bool Filter(GameEntity collidedEntity) => base.Filter(collidedEntity) && collidedEntity.isMovingCircle;
        
        protected override void Execute(List<GameEntity> movingCircles)
        {
            foreach (var movingCircle in movingCircles)
            foreach (var fallingCircle in _fallingCircles)
            {
                if (movingCircle.collidedEntityId.Value != fallingCircle.id.Value) continue;
                
                movingCircle.isKilled = true;
            }
        }
    }
}