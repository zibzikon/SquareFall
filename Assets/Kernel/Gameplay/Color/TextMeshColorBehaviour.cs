using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace Kernel.Gameplay.Color
{
    public class TextMeshColorBehaviour: ColorBehaviourBase
    {
        [Required, SerializeField] private TextMeshProUGUI _textMesh;

        public override void OnColor(GameEntity entity, UnityEngine.Color value) => _textMesh.color = value;
    }
}