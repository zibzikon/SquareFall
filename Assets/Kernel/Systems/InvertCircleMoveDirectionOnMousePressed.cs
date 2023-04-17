using System.Collections.Generic;
using Entitas;
using static GameMatcher;
using static InputMatcher;

namespace Kernel.Systems
{
    public class InvertCircleMoveDirectionOnMousePressed : PausableReactiveSystem<InputEntity>
    {
        private readonly IGroup<GameEntity> _movables;

        public InvertCircleMoveDirectionOnMousePressed(InputContext input, GameContext game) : base(game, input) 
            => _movables = game.GetGroup(AllOf(Movable, MovingCircle, MoveDirection));

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> input) =>
            input.CreateCollector(LeftMouse.Added());

        protected override bool Filter(InputEntity entity) => entity.isMouse;

        protected override void OnExecute(List<InputEntity> movingCircles)
        {
            foreach (var movable in _movables)
            foreach (var _ in movingCircles)
            {
                movable.isInvertMoveDirection = true;
                movable.isChangedMoveDirection = true;
            }
        }
    }
}