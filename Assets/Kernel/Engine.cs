using System;
using Kernel.Gameplay.Color;
using Kernel.Systems.Registration;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace Kernel
{
    public class Engine : MonoBehaviour
    {
        private GameContext _game;
        
        private GameSystems _systems;

        [Inject]
        public void Construct(GameSystems systems, GameContext game)
        {
            _game = game;
            _systems = systems;
        }

        private void Start() => _systems.Initialize();

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        private void OnApplicationQuit() => _systems.TearDown();

        public void BootLevel()
        {
            _game.isGameState = true;
        }
        
        public void StartPlaying() => _game.gameStateEntity.isPlaying = true;
        
        public void PauseGame() => _game.gameStateEntity.isPaused = true;
        public void ResumeGame() => _game.gameStateEntity.isPaused = false;
        
        public void SetColorScheme(ColorSchemeConfiguration colorScheme) => _game.ReplaceCurrentColorScheme(colorScheme);
    }
}