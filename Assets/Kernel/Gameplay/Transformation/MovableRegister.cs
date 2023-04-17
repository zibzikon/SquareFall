using Kernel.ECSIntegration;
using UnityEngine;

namespace Kernel.Gameplay
{
    public class MovableRegister : EntityRegisterBehaviour
    {
        [SerializeField] private float _movingSpeed;
        
        public override void Register(GameEntity entity)
        {
            entity.isMovable = true;
            entity.AddMovingSpeed(_movingSpeed);
        }
    }
}