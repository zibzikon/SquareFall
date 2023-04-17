using System.Collections.Generic;
using Kernel.Extensions;
using static GameMatcher;

namespace Kernel.Systems
{
    public class SpawnFallingSquareOnSpawnDurationUpSystem : DurationUpReactiveSystem
    {
        public SpawnFallingSquareOnSpawnDurationUpSystem(GameContext game) : base(game) { }

        protected override bool Filter(GameEntity durationUpEntity) =>
            base.Filter(durationUpEntity) && AllOf(FallingSquaresSpawner, SpawnPositionRange).NoneOf(SpawnRandom).Matches(durationUpEntity);

        protected override void Execute(List<GameEntity> spawners)
        {
            foreach (var spawner in spawners)
            {
                var spawnInterval = spawner.spawnInterval.Value;
                spawner.WindUpDuration(spawnInterval);
                spawner.isSpawnRandom = true;
            }
        }

    }
}