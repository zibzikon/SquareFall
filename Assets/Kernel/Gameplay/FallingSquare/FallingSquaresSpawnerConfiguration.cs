using Kernel.Utils;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.Gameplay.FallingSquaresSpawner
{
    [CreateAssetMenu(fileName = "FallingSquaresSpawnerConfiguration", menuName = "Configurations/FallingSquaresSpawner")]
    public class FallingSquaresSpawnerConfiguration : ScriptableObject
    {
        [field: SerializeField, Range(0f, 1f)] public float CollectableSquareSpawningChance { get; private set; }
        [field: SerializeField] public float SpawnInterval { get; private set; }
        [field: SerializeField] public float InitialSquareSpeed { get; private set; }
        [field: SerializeField] public Vector2Range SpawnPositionsRange { get; private set; }
    }
}