using System.Collections.Generic;
using Entitas;
using Kernel.ECSIntegration;
using Kernel.Extensions;
using static ConfigurationMatcher;

namespace Kernel.Systems
{
    public class CreateFallingSquaresSpawnerOnPlayingStarted : PlayingStartedReactiveSystem
    {
        private readonly IGameEntityCreator _gameEntityCreator;
        private readonly IGroup<ConfigurationEntity> _fallingSpawnerConfigurations;

        public CreateFallingSquaresSpawnerOnPlayingStarted(GameContext game, ConfigurationContext configuration,  IGameEntityCreator gameEntityCreator) : base(game)
        {
            _gameEntityCreator = gameEntityCreator;
            _fallingSpawnerConfigurations = configuration.GetGroup(AllOf(FallingSquaresSpawnerConfiguration));
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var _ in entities)
            foreach (var spawnerConfigurationEntity in _fallingSpawnerConfigurations)
            {
                var configuration = spawnerConfigurationEntity.fallingSquaresSpawnerConfiguration.Value;
                
                var spawner = _gameEntityCreator.CreateEmpty();
                
                spawner.isFallingSquaresSpawner = true;
                
                spawner.AddSpawnPositionRange(configuration.SpawnPositionsRange);
                spawner.AddSpawnInterval(configuration.SpawnInterval);
                spawner.AddSpawnedEntitySpeed(configuration.InitialSquareSpeed);
                spawner.AddCollectableSquareSpawningChance(configuration.CollectableSquareSpawningChance);
                spawner.WindUpDuration(configuration.SpawnInterval);
            }

        }
    }
}