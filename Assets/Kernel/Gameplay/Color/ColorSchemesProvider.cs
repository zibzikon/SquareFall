using System.Collections.Generic;

namespace Kernel.Gameplay.Color
{
    public class ColorSchemesProvider : IColorSchemesProvider
    {
        private IEnumerable<ColorSchemeConfiguration> _colorSchemeConfigurations;

        public ColorSchemesProvider(IEnumerable<ColorSchemeConfiguration> colorSchemeConfigurations) 
            => _colorSchemeConfigurations = colorSchemeConfigurations;

        public IEnumerable<ColorSchemeConfiguration> GetColorSchemes() => _colorSchemeConfigurations;
        
    }
}