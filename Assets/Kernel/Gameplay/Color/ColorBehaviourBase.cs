using Kernel.ECSIntegration;

namespace Kernel.Gameplay.Color
{
    public abstract class ColorBehaviourBase : EntityEventListenerBehaviour, IColorListener
    {
        public override void Register(GameEntity entity) => entity.AddColorListener(this);

        public override void Unregister(GameEntity entity) => entity.RemoveColorListener(this);

        public abstract void OnColor(GameEntity entity, UnityEngine.Color value);
    }
}