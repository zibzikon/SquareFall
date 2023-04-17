using Foundation;
using Kernel.ECSIntegration;
using Kernel.Gameplay.Color;
using Kernel.Gameplay.FallingSquaresSpawner;
using Kernel.Services;
using Kernel.Systems.Registration;
using Kernel.UI;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace Kernel.Installers
{
    public class GamePlayInstaller : MonoInstaller
    {
        [Required, SerializeField] private Bootstrap _bootstrap;
        [Required, SerializeField] private Engine _engine;
        [Required, SerializeField] private Mediator _mediator;
        
        public override void InstallBindings()
        {
            var contexts = Contexts.sharedInstance;
            
            Container.BindInstance(contexts);
            Container.BindInstance(contexts.game);
            Container.BindInstance(contexts.input);
            Container.BindInstance(contexts.configuration);

            Container.Bind<GameSystems>().ToSelf().AsSingle();
            
            Container.BindInstance(_bootstrap);
            Container.BindInstance(_engine);
            Container.Bind<IMediator>().FromInstance(_mediator);

            Container.Bind<IEntityViewFactory>().To<EntityViewFactory>().AsSingle();
            Container.Bind<IEntityIdentifierGenerator>().To<EntityIdentifierGenerator>().AsSingle();
            Container.Bind<IGameEntityCreator>().To<GameEntityCreator>().AsSingle();
            
            Container.Bind<IColorSchemesProvider>().To<ColorSchemesProvider>().AsSingle();

            Container.Bind<IFallingSquareViewFactory>().To<FallingSquareViewFactory>().AsSingle();
            Container.Bind<IColorSchemeSelectionElementViewFactory>().To<ColorSchemeSelectionElementViewFactory>().AsSingle();
        }
    }
}