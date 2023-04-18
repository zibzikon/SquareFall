using Entitas;
using Kernel.Services;
using static GameMatcher;

namespace Kernel.Systems
{
    public class DurationSystem : PausableExecuteSystem
    {
        private readonly ITime _time;
        private readonly IGroup<GameEntity> _withDuration;

        
        public DurationSystem(GameContext game, ITime time) : base(game)
        {
            _time = time;
            _withDuration = game.GetGroup(AllOf(Duration, DurationLeft).NoneOf(DurationUp));
        }

        protected override void OnExecute()
        {
            foreach (var withDuration in _withDuration.GetEntities())
            {
                var durationLeft = withDuration.durationLeft.Value - _time.DeltaTime;
                
                withDuration.ReplaceDurationLeft(durationLeft);

                if (!(durationLeft <= 0)) continue;
                
                withDuration.RemoveDurationLeft();
                withDuration.isDurationUp = true;
            }
        }
    }
}