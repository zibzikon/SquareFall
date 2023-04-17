using Kernel.Gameplay.Color;
using Kernel.UI;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using static Sirenix.OdinInspector.ButtonStyle;

namespace Kernel
{
    public class Mediator : MonoBehaviour, IMediator
    {
        [Required, SerializeField] private ColorSchemeSelectionWindow _colorSchemeSelectionWindow;
        [Required, SerializeField] private TextMeshProUGUI _scoreLabel;
        
        [Required, SerializeField] private Engine _engine;
        
        [HideInEditorMode, Button(FoldoutButton)] public void SetColorScheme(ColorSchemeConfiguration colorScheme) => _engine.SetColorScheme(colorScheme);
        [HideInEditorMode, Button(FoldoutButton)] public void SetSelectedColorScheme(ColorSchemeConfiguration colorScheme) => _colorSchemeSelectionWindow.SetSelectedColorScheme(colorScheme);
            
        [HideInEditorMode, Button(FoldoutButton)] public void SetScore(int score) => _scoreLabel.text = score.ToString();
        [HideInEditorMode, Button(FoldoutButton)] public void AddColorSchemeSelectionElement(ColorSchemeSelectionElement element) => _colorSchemeSelectionWindow.AddElement(element);
        
        [HideInEditorMode, Button] public void StartPlaying() => _engine.StartPlaying();
        [HideInEditorMode, Button] public void PauseGame() => _engine.PauseGame(); [HideInEditorMode, Button] public void ResumeGame() => _engine.ResumeGame();
        
        [HideInEditorMode, Button] public void ShowColorSchemeSelectionWindow() => _colorSchemeSelectionWindow.Show();
        [HideInEditorMode, Button] public void HideColorSchemeSelectionWindow() => _colorSchemeSelectionWindow.Hide();
    }
}