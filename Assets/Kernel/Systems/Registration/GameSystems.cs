using Zenject;

namespace Kernel.Systems.Registration
{
    public class GameSystems : InjectableFeature
    {
        public GameSystems(DiContainer container) : base(container)
        {
            AddInjected<InitializeInputSystem>();
            AddInjected<EmitInputSystem>();
            
            AddInjected<InitializePlayerSystem>();
            
            AddInjected<CreateFallingSquaresSpawnerOnPlayingStarted>();
            AddInjected<SpawnFallingSquareOnSpawnDurationUpSystem>();
            AddInjected<FallingSquareCreationSystem>();
            
            AddInjected<InvertCircleMoveDirectionOnMousePressed>();
            AddInjected<InvertMoveDirectionOnHorizontalBorderOut>();
            
            AddInjected<AddScoreToPlayerOnMovingCircleCollidedWithCollectableFallingSquare>();
            AddInjected<KillMovingCircleOnCollidedWithHardFallingSquare>();

            AddInjected<InvertMoveDirectionSystem>();
            AddInjected<DirectionalMovingSystem>();
            
            AddInjected<DurationSystem>();
            
            AddInjected<UpdateColorsDependingOnColorSchemeSystem>();
            
            AddInjected<UpdateScoreLabelOnPlayerScoreChangedSystem>();
            
            AddInjected<GameEventSystems>();
        }
    }
}