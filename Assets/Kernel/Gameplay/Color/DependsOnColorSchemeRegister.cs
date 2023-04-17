using Kernel.ECSIntegration;
using UnityEngine;
using UnityEngine.Serialization;

namespace Kernel.Gameplay.Color
{
    public class DependsOnColorSchemeRegister : EntityRegisterBehaviour
    {
        [SerializeField] private ColorType _dependingType;
        
        public override void Register(GameEntity entity)
        {
            entity.isDependsOnColorScheme = true;
            entity.AddColorType(_dependingType);
        }
    }
}