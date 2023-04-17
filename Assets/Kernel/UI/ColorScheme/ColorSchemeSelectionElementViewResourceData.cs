using UnityEngine;

namespace Kernel.UI
{
    [CreateAssetMenu(fileName = "ColorSchemeSelectionElementViewResourceData",
        menuName = "Data/Resources/ColorSelectionElementView")]

    public class ColorSchemeSelectionElementViewResourceData : ScriptableObject
    {
        [field: SerializeField] public string ViewPath { get; private set; }
    }
}