using Entitas;
using Kernel.Extensions;
using static GameMatcher;


namespace Kernel.Systems
{
    public class InvertMoveDirectionOnHorizontalBorderOut : PausableExecuteSystem
    {
        private readonly IGroup<GameEntity> _movables;

        
        public InvertMoveDirectionOnHorizontalBorderOut(GameContext game) : base(game)
        {
            _movables = game.GetGroup(AllOf(Movable, Position, MoveDirection, HorizontalBorder));
        }
        
        protected override void OnExecute()
        {
            foreach (var movable in _movables)
            {
                var position = movable.position.Value;
                var border = movable.horizontalBorder.Value;
                var horizontalDirection = movable.moveDirection.Value.x;
                var verticalPosition = position.x;
                
                if ((horizontalDirection > 0 && verticalPosition < border.end)||
                    (horizontalDirection < 0 && verticalPosition > border.start))
                    continue;

                movable.isInvertMoveDirection = true;
                movable.isBorderOut = true;
            }
        }
    }
}