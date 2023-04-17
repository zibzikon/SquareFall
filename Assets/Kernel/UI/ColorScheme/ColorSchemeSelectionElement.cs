using System;
using Kernel.Gameplay.Color;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Kernel.UI
{
    public class ColorSchemeSelectionElement : MonoBehaviour
    {
        public ColorSchemeConfiguration ColorScheme { get; private set; }

        public event Action<ColorSchemeSelectionElement> Pressed;

        [Required, SerializeField] private Image _selectedPointerImage;
        [Required, SerializeField] private TextMeshProUGUI _colorSchemeNameLabel;
        
        [Required, SerializeField] private Image
            _primaryColorImage, _seconndaryColorImage, _accentColorImage, _neutralColorImage;
        
        [Required, SerializeField] private Button _button;

        private void Awake() => RegisterEvents();

        private void Start() => UpdateView();

        private void OnDestroy() => UnregisterEvents();

        public void Initialize(ColorSchemeConfiguration colorScheme)
        {
            Deselect();
            ColorScheme = colorScheme;
        }

        public void Select() => _selectedPointerImage.gameObject.SetActive(true);
        public void Deselect() => _selectedPointerImage.gameObject.SetActive(false);
        
        private void UpdateView()
        {
            _colorSchemeNameLabel.text = ColorScheme.Name;
            _primaryColorImage.color = ColorScheme.Primary;
            _seconndaryColorImage.color = ColorScheme.Secondary;
            _accentColorImage.color = ColorScheme.Accent;
            _neutralColorImage.color = ColorScheme.Neutral;
        }

        private void RegisterEvents() => _button.onClick.AddListener(OnButtonClick);
        
        private void UnregisterEvents() => _button.onClick.RemoveListener(OnButtonClick);
        
        private void OnButtonClick() => Pressed?.Invoke(this);

    }
}