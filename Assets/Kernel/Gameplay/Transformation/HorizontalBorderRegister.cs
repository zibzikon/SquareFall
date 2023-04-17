using Kernel.ECSIntegration;
using Kernel.Services;
using UnityEngine;

namespace Kernel.Gameplay
{
    public class HorizontalBorderRegister : EntityRegisterBehaviour
    {
        [SerializeField] private RangeFloat _border;
        
        public override void Register(GameEntity entity) => entity.AddHorizontalBorder(_border);
    }
}