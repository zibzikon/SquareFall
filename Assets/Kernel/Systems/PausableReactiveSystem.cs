using System.Collections.Generic;
using Entitas;

namespace Kernel.Systems
{
    public abstract class PausableReactiveSystem<T> : ReactiveSystem<T> where T: Entity
    {
        private readonly GameContext _game;

        protected PausableReactiveSystem(GameContext game, IContext<T> context) : base(context) 
        {
            _game = game;
        }

        protected override void Execute(List<T> entities)
        {
            if (_game.gameStateEntity.isPaused) return;

            OnExecute(entities);
        }

        protected abstract void OnExecute(List<T> entities);
    }
}