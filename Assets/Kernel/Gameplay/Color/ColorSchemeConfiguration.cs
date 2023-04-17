using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.Gameplay.Color
{
    [CreateAssetMenu(fileName = "ColorSchemeConfiguration", menuName = "Configurations/ColorScheme")]
    public class ColorSchemeConfiguration : ScriptableObject
    {
        [field: SerializeField] public UnityEngine.Color Primary { get; private set; }
        [field: SerializeField] public UnityEngine.Color Secondary { get; private set; }
        [field: SerializeField] public UnityEngine.Color Accent { get; private set; }
        [field: SerializeField] public UnityEngine.Color Neutral { get; private set; }
    }
}