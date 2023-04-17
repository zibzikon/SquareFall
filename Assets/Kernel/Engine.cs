using System;
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
        
        [Button]
        public void StartPlaying()
        {
            _game.gameStateEntity.isPlaying = true;
        }
    }
}