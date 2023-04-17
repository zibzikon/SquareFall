using Entitas;

namespace Kernel.Systems
{
    public class InitializeInputSystem : IInitializeSystem
    {
        private readonly InputContext _inputContext;

        public InitializeInputSystem(InputContext inputContext)
        {
            _inputContext = inputContext;
        }
        
        public void Initialize()
        {
            _inputContext.isMouse = true;
        }
    }
}