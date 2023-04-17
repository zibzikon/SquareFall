using Kernel.ECSIntegration;
using UnityEngine;

namespace Kernel.Gameplay
{
    public class PositionListener : EntityEventListenerBehaviour, IPositionListener
    {
        public override void Register(GameEntity entity) => entity.AddPositionListener(this);

        public override void Unregister(GameEntity entity) => entity.RemovePositionListener(this);
        
        public void OnPosition(GameEntity entity, Vector3 value) => transform.position = value;

    }
}