using System.Collections.Generic;
using Entitas;
using Kernel.Gameplay;
using Kernel.Services;
using static GameMatcher;

namespace Kernel.Systems
{
    public class PlayBorderHitSoundOnMovingCircleOutTheBorder : PausableReactiveSystem<GameEntity>
    {
        private readonly MovingCircleAudioResourcesData _movingCircleAudioResourcesData;
        private readonly IAudioPlayer _audioPlayer;

        public PlayBorderHitSoundOnMovingCircleOutTheBorder(GameContext game, MovingCircleAudioResourcesData movingCircleAudioResourcesData, IAudioPlayer audioPlayer) : base(game, game)
        {
            _movingCircleAudioResourcesData = movingCircleAudioResourcesData;
            _audioPlayer = audioPlayer;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(BorderOut);

        protected override bool Filter(GameEntity entity) => entity.isMovingCircle;

        protected override void OnExecute(List<GameEntity> movingCircles)
        {
            foreach (var _ in movingCircles)
            {
                _audioPlayer.PlayFromResource(_movingCircleAudioResourcesData.HitBorderSoundPath);
            }
        }
    }
}