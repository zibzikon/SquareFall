using Entitas;
using Kernel.Services;
using UnityEngine;
using static GameMatcher;

namespace Kernel.Systems
{
    public class DirectionalMovingSystem : PausableExecuteSystem
    {
        private readonly ITime _time;
        private readonly IGroup<GameEntity> _movables;

        public DirectionalMovingSystem(GameContext game, ITime time) : base(game)
        {
            _time = time;
            _movables = game.GetGroup(AllOf(Movable, MoveDirection, MovingSpeed, Position));
        }
        
        protected override void OnExecute()
        {
            foreach (var movable in _movables)
            {
                var moveDirection = movable.moveDirection.Value;
                var position = movable.position.Value;
                var speed = movable.movingSpeed.Value;

                var newPosition = position + (Vector3)(moveDirection * speed * _time.DeltaTime);

                movable.ReplacePosition(newPosition);
            }
        }
    }
}