using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.Gameplay.FallingSquaresSpawner
{
    [CreateAssetMenu(fileName = "FallingSquareViewResourcesData", menuName = "Data/Resources/FallingSquareView")]
    public class FallingSquareViewResourcesData : ScriptableObject
    {
        [field: SerializeField] public string ViewPath { get; private set; }
    }
}