using System.Collections.Generic;

namespace Kernel.Gameplay.Color
{
    public interface IColorSchemesProvider
    {
        IEnumerable<ColorSchemeConfiguration> GetColorSchemes();
    }
}