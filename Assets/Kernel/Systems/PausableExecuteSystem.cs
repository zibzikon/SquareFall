using Entitas;

namespace Kernel.Systems
{
    public abstract class PausableExecuteSystem : IExecuteSystem
    {
        private readonly GameContext _game;

        protected PausableExecuteSystem(GameContext game)
        {
            _game = game;
        }
        
        public void Execute()
        {
            if (_game.gameStateEntity.isPaused) return;
            
            OnExecute();
        }

        protected abstract void OnExecute();
    }
}