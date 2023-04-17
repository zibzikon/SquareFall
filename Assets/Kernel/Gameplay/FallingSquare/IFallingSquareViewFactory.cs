using Kernel.ECSIntegration;

namespace Kernel.Gameplay.FallingSquaresSpawner
{
    public interface IFallingSquareViewFactory
    {
        EntityView CreateView();
    }
}