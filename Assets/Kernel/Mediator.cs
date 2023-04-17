using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace Kernel
{
    public class Mediator : MonoBehaviour, IMediator
    {
        [Required, SerializeField] private TextMeshProUGUI _scoreLabel;

        public void SetScore(int score) => _scoreLabel.text = score.ToString();
    }
}