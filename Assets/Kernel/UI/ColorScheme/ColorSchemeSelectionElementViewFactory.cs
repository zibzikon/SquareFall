using Kernel.Services;

namespace Kernel.UI
{
    public class ColorSchemeSelectionElementViewFactory : IColorSchemeSelectionElementViewFactory
    {
        private readonly IUnityViewService _viewService;
        private readonly IResourcesLoader _resourcesLoader;
        private readonly ColorSchemeSelectionElementViewResourceData _viewResourceData;

        public ColorSchemeSelectionElementViewFactory(IUnityViewService viewService, IResourcesLoader resourcesLoader, ColorSchemeSelectionElementViewResourceData viewResourceData)
        {
            _viewService = viewService;
            _resourcesLoader = resourcesLoader;
            _viewResourceData = viewResourceData;
        }

        public ColorSchemeSelectionElement CreateView() =>
            _viewService.CreateViewFromPrefab(
                _resourcesLoader.Load<ColorSchemeSelectionElement>(_viewResourceData.ViewPath));

    }
}