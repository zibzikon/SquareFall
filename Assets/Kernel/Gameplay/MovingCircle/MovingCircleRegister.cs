using Kernel.ECSIntegration;
using UnityEngine;

namespace Kernel.Gameplay
{
    public class MovingCircleRegister: EntityRegisterBehaviour
    {
        public override void Register(GameEntity entity) => entity.isMovingCircle = true;
    }
}