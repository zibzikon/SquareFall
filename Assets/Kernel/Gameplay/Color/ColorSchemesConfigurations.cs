using System.Collections.Generic;
using UnityEngine;

namespace Kernel.Gameplay.Color
{
    [CreateAssetMenu(fileName = "ColorSchemesConfigurations", menuName = "Configurations/ColorSchemes")]
    public class ColorSchemesConfigurations : ScriptableObject
    {
        [field: SerializeField] public List<ColorSchemeConfiguration> ColorSchemes { get; private set; }
    }
}