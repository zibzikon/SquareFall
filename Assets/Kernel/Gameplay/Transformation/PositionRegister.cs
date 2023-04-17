using Kernel.ECSIntegration;

namespace Kernel.Gameplay
{
    public class PositionRegister : EntityRegisterBehaviour
    {
        public override void Register(GameEntity entity) => entity.AddPosition(transform.position);
    }
}