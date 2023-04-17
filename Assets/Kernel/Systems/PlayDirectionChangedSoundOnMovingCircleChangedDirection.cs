using System.Collections.Generic;
using Entitas;
using Kernel.Gameplay;
using Kernel.Services;
using static GameMatcher;

namespace Kernel.Systems
{
    public class PlayDirectionChangedSoundOnMovingCircleChangedDirection : PausableReactiveSystem<GameEntity>
    {
        private readonly MovingCircleAudioResourcesData _audioResourcesData;
        private readonly IAudioPlayer _audioPlayer;

        public PlayDirectionChangedSoundOnMovingCircleChangedDirection(GameContext context, MovingCircleAudioResourcesData audioResourcesData, IAudioPlayer audioPlayer) : base(context, context)
        {
            _audioResourcesData = audioResourcesData;
            _audioPlayer = audioPlayer;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(ChangedMoveDirection.Added());

        protected override bool Filter(GameEntity movingCircle)
            => AllOf(MovingCircle).Matches(movingCircle);

        protected override void OnExecute(List<GameEntity> movingCircles)
        {
            foreach (var _ in movingCircles)
            {
                _audioPlayer.PlayFromResource(_audioResourcesData.ChangeDirectionSoundPath);
            }
        }
    }
}