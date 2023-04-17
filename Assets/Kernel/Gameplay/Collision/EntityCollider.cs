using Kernel.ECSIntegration;
using UnityEngine;

namespace Kernel.GamePlay.Collision
{
    [RequireComponent(typeof(Collider2D))]
    public class EntityCollider : EntityBehaviour, IGameEntityRegister
    {
        public Collider2D Collider { get; private set; }

        protected override void OnAwake()
        {
            Collider = GetComponent<Collider2D>();
        }
        
        public void Register(GameEntity entity)
        {
            entity.isCollisionable = true;
        }
    }
}