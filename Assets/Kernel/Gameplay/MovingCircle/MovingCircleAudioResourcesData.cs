using UnityEngine;

namespace Kernel.Gameplay
{
    [CreateAssetMenu(fileName = "MovingCircleResourcesData", menuName = "Data/Resources/Audio/MovingCircle")]
    
    public class MovingCircleAudioResourcesData : ScriptableObject
    {
        [field: SerializeField] public string CollectingSoundPath { get; private set; }
        [field: SerializeField] public string ChangeDirectionSoundPath { get; private set; }
        [field: SerializeField] public string HitBorderSoundPath { get; private set; }
    }
}