using System;
using Kernel.ECSIntegration;
using Kernel.Extensions;
using UnityEngine;

namespace Kernel.GamePlay.Collision
{
    public class TriggerBehavior : EntityBehaviour
    {
        [SerializeField] private LayerMask _triggeringLayers;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if(!TryGetEntity(other, out var collidedEntity) || Entity.hasCollidedEntityId) return;

            Entity.AddCollidedEntityId(collidedEntity.id.Value);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if(!TryGetEntity(other, out var collidedEntity) || !Entity.hasCollidedEntityId) return;
            
            Entity.RemoveCollidedEntityId();
        }

        private bool TryGetEntity(Collider2D other, out GameEntity entity)
        {
            entity = null;
            if(!other.TryGetComponent(out EntityCollider collider) ||
               !collider.SatisfiesLayerMask(_triggeringLayers)) return false;

            entity = collider.Entity;
            return true;
        }
        
    }
}