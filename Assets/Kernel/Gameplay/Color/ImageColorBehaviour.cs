using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace Kernel.Gameplay.Color
{
    public class ImageColorBehaviour : ColorBehaviourBase
    {
        [Required, SerializeField] private Image _image;

        public override void OnColor(GameEntity entity, UnityEngine.Color value) => _image.color = value;
    }
}