using Kernel.ECSIntegration;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Kernel.Gameplay.Color
{
    public class SpriteRendererColorBehaviour : ColorBehaviourBase
    {
        [Required, SerializeField] private SpriteRenderer _renderer;

        public override void OnColor(GameEntity entity, UnityEngine.Color value) => _renderer.color = value;
    }
}