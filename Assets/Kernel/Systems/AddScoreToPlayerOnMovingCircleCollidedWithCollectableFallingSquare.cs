using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems
{
    public class AddScoreToPlayerOnMovingCircleCollidedWithCollectableFallingSquare : CollisionReactiveSystem
    {
        private readonly IGroup<GameEntity> _players;
        private readonly IGroup<GameEntity> _fallingCircles;

        public AddScoreToPlayerOnMovingCircleCollidedWithCollectableFallingSquare(GameContext game) : base(game)
        {
            _players = game.GetGroup(AllOf(Player, Score));
            _fallingCircles = game.GetGroup(AllOf(Id, FallingSquare, Collisionable));
        }

        protected override bool Filter(GameEntity collidedEntity) => base.Filter(collidedEntity) && collidedEntity.isMovingCircle;
        

        protected override void Execute(List<GameEntity> movingCircles)
        {
            foreach (var movingCircle in movingCircles)
            foreach (var player in _players)
            foreach (var fallingCircle in _fallingCircles)
            {
                if (movingCircle.collidedEntityId.Value != fallingCircle.id.Value) continue;
                
                player.ReplaceScore(player.score.Value + 1);
                fallingCircle.isDestructed = true;
            }
        }
    }
}