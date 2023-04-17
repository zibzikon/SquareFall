using Kernel.Gameplay.FallingSquaresSpawner;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace Kernel.Installers
{
    public class DataInstaller : MonoInstaller
    {
        [Required, SerializeField] private FallingSquareViewResourcesData _fallingSquareViewResources;
        
        public override void InstallBindings()
        {
            Container.BindInstance(_fallingSquareViewResources);
        }
    }
}