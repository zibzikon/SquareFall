using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace Kernel.UI
{
    public class ColorSchemeButton : MonoBehaviour
    {
        [Required, SerializeField] private Button _button;
        [Required, SerializeField] private Mediator _mediator;

        private void Awake() => RegisterEvents();

        private void OnDestroy() => UnregisterEvents();

        private void RegisterEvents() => _button.onClick.AddListener(OnButtonClick);

        private void UnregisterEvents() => _button.onClick.RemoveListener(OnButtonClick);

        private void OnButtonClick()
        {
            _mediator.ShowColorSchemeSelectionWindow();
            _mediator.PauseGame();
        }
    }
}