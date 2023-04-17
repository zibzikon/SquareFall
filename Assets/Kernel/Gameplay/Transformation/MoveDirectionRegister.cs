using Kernel.ECSIntegration;
using Kernel.Extensions;
using UnityEngine;

namespace Kernel.Gameplay
{
    public class MoveDirectionRegister : EntityRegisterBehaviour
    {
        [SerializeField] private Vector2 _direction;
        
        public override void Register(GameEntity entity) => entity.AddMoveDirection(_direction);
    }
}