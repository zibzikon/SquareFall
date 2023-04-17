using System.Linq;
using Entitas;
using Kernel.Gameplay.Color;
using Kernel.UI;

namespace Kernel.Systems
{
    public class InitializeColorSchemeSelectionWindowSystem : IInitializeSystem
    {
        private readonly IMediator _mediator;
        private readonly IColorSchemesProvider _colorSchemesProvider;
        private readonly GameContext _game;
        private readonly IColorSchemeSelectionElementViewFactory _colorSchemeSelectionElementViewFactory;

        public InitializeColorSchemeSelectionWindowSystem(GameContext game ,IMediator mediator, IColorSchemesProvider colorSchemesProvider, IColorSchemeSelectionElementViewFactory colorSchemeSelectionElementViewFactory)
        {
            _game = game;
            _colorSchemeSelectionElementViewFactory = colorSchemeSelectionElementViewFactory;
            _colorSchemesProvider = colorSchemesProvider;
            _mediator = mediator;
        }
        
        public void Initialize()
        {
            var  currentColorScheme = _game.currentColorScheme.Value;
            foreach (var colorScheme in _colorSchemesProvider.GetColorSchemes().OrderBy(x => x.Name))
            {
                var element = _colorSchemeSelectionElementViewFactory.CreateView();
                element.Initialize(colorScheme);
                _mediator.AddColorSchemeSelectionElement(element);
                
                if (currentColorScheme.Name == colorScheme.Name)
                    _mediator.SetSelectedColorScheme(colorScheme);
            }
        }
    }
}