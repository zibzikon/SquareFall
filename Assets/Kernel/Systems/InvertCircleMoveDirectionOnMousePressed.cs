using System.Collections.Generic;
using Entitas;
using static GameMatcher;
using static InputMatcher;

namespace Kernel.Systems
{
    public class InvertCircleMoveDirectionOnMousePressed : ReactiveSystem<InputEntity>
    {
        private readonly IGroup<GameEntity> _movables;

        public InvertCircleMoveDirectionOnMousePressed(InputContext input, GameContext game) : base(input) 
            => _movables = game.GetGroup(AllOf(Movable, MovingCircle, MoveDirection));

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> input) =>
            input.CreateCollector(LeftMouse.Added());

        protected override bool Filter(InputEntity entity) => entity.isMouse;

        protected override void Execute(List<InputEntity> entities)
        {
            foreach (var movable in _movables)
            foreach (var _ in entities)
            {
                movable.isInvertMoveDirection = true;
            }
        }
    }
}