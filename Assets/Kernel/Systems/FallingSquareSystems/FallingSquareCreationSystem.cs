using System.Collections.Generic;
using Entitas;
using Kernel.ECSIntegration;
using Kernel.Gameplay.FallingSquaresSpawner;
using Kernel.Utils;
using UnityEngine;
using static GameMatcher;
using Random = Unity.Mathematics.Random;

namespace Kernel.Systems
{
    public class FallingSquareCreationSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGameEntityCreator _entityCreator;
        private readonly IFallingSquareViewFactory _viewFactory;
        private readonly IGroup<GameEntity> _movingCircles;

        public FallingSquareCreationSystem(GameContext game, IGameEntityCreator entityCreator, IFallingSquareViewFactory viewFactory) : base(game)
        {
            _entityCreator = entityCreator;
            _viewFactory = viewFactory;
            _movingCircles = game.GetGroup(AllOf(MovingCircle, Position));
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> game) =>
            game.CreateCollector(SpawnRandom);

        protected override bool Filter(GameEntity spawner) =>
            AllOf(FallingSquaresSpawner, SpawnPositionRange, SpawnedEntitySpeed).Matches(spawner);

        protected override void Execute(List<GameEntity> spawnersRequestsSpawn)
        {
            foreach (var spawner in spawnersRequestsSpawn)
            foreach (var movingCircle in _movingCircles)
            {
                var movingCirclePosition = (Vector2) movingCircle.position.Value;
                var positionRange = spawner.spawnPositionRange.Value;
                var position = CalculateRandomPosition(positionRange);
                var speed = spawner.spawnedEntitySpeed.Value;
                var direction = (movingCirclePosition - position).normalized;
                
                var fallingSquare = _entityCreator.CreateEmpty();

                fallingSquare.isFallingSquare = true;
                fallingSquare.isMovable = true;
                
                fallingSquare.AddPosition(position);
                fallingSquare.AddMovingSpeed(speed);
                fallingSquare.AddMoveDirection(direction);

                _viewFactory.CreateView().Initialize(fallingSquare);
                
                spawner.isSpawnRandom = false;
            }
        }

        private Vector2 CalculateRandomPosition(Vector2Range positionRange)
        {
            var random = new Random((uint)UnityEngine.Random.Range(1, 100000));
            var t = random.NextFloat(0, 1);

            return Vector2.Lerp(positionRange.start, positionRange.end, t);
        }
        
    }
}