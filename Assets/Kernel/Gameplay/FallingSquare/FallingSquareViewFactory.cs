using Kernel.ECSIntegration;
using Kernel.Services;

namespace Kernel.Gameplay.FallingSquaresSpawner
{
    public class FallingSquareViewFactory : IFallingSquareViewFactory
    {
        private readonly IEntityViewFactory _entityViewFactory;
        private readonly FallingSquareViewResourcesData _resourcesData;

        public FallingSquareViewFactory(IEntityViewFactory entityViewFactory, FallingSquareViewResourcesData resourcesData)
        {
            _entityViewFactory = entityViewFactory;
            _resourcesData = resourcesData;
        }

        public EntityView CreateView() =>
            _entityViewFactory.CreateFromResourceName(_resourcesData.ViewPath, "Falling Square");
    }
}