using Kernel.Gameplay.Color;
using Kernel.UI;

namespace Kernel
{
    public interface IMediator
    {
        void SetScore(int score);
        public void SetColorScheme(ColorSchemeConfiguration colorScheme);
        public void SetSelectedColorScheme(ColorSchemeConfiguration colorScheme);
        public void AddColorSchemeSelectionElement(ColorSchemeSelectionElement element);
        
        void StartPlaying();
        void PauseGame();
        void ResumeGame();
        
        void ShowColorSchemeSelectionWindow();
        void HideColorSchemeSelectionWindow();
    }
}