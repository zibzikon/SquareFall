using Entitas;
using static GameMatcher;


namespace Kernel.Systems
{
    public class MovingCircleCleanupSystem : PausableExecuteSystem
    {
        private readonly IGroup<GameEntity> _movingCircles;

        
        public MovingCircleCleanupSystem(GameContext game) : base(game)
        {
            _movingCircles = game.GetGroup(MovingCircle);
        }

        protected override void OnExecute()
        {
            foreach (var movingCircle in _movingCircles)
            {
                movingCircle.isBorderOut = false;
                movingCircle.isChangedMoveDirection = false;
            }
        }
    }
}