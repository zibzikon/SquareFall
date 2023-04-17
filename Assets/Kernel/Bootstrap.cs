using System;
using Kernel;
using Kernel.Gameplay.Color;
using Kernel.Gameplay.FallingSquaresSpawner;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace Foundation
{
    public class Bootstrap : MonoBehaviour
    {
        [Required, SerializeField] private Engine _engine;
        
        [Required, SerializeField] private FallingSquaresSpawnerConfiguration _fallingSquaresSpawnerConfiguration;
        [Required, SerializeField] private ColorSchemeConfiguration _defaultColorSchemeConfiguration;
        
        private ConfigurationContext _configurationContext;
        private GameContext _gameContext;

        [Inject]
        public void Construct(ConfigurationContext configurationContext, GameContext gameContext)
        {
            _gameContext = gameContext;
            _configurationContext = configurationContext;
        }

        private void Awake()
        {
            _configurationContext.isGameConfiguration = true;
            
            _configurationContext.gameConfigurationEntity.AddFallingSquaresSpawnerConfiguration(
                _fallingSquaresSpawnerConfiguration);

            _gameContext.SetCurrentColorScheme(_defaultColorSchemeConfiguration);
            
            _engine.BootLevel();
        }
    }
}