using System.Collections.Generic;
using Kernel.Gameplay;
using Kernel.Gameplay.Color;
using Kernel.Gameplay.FallingSquaresSpawner;
using Kernel.UI;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace Kernel.Installers
{
    public class DataInstaller : MonoInstaller
    {
        
        [Required, SerializeField] private ColorSchemesConfigurations _colorSchemesConfigurations;
        [Required, SerializeField] private FallingSquareViewResourcesData _fallingSquareViewResources;
        [Required, SerializeField] private MovingCircleAudioResourcesData _movingCircleAudioResourcesData;
        [Required, SerializeField] private ColorSchemeSelectionElementViewResourceData _colorSchemeSelectionElementViewResourceData;
        
        public override void InstallBindings()
        {
            Container.Bind<IEnumerable<ColorSchemeConfiguration>>().FromInstance(_colorSchemesConfigurations.ColorSchemes);
            Container.BindInstance(_fallingSquareViewResources);
            Container.BindInstance(_movingCircleAudioResourcesData);
            Container.BindInstance(_colorSchemeSelectionElementViewResourceData);
        }
    }
}