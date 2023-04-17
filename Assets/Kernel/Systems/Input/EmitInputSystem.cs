using Entitas;
using Kernel.Services;
using static InputMatcher;

namespace Kernel.Systems
{
    public class EmitInputSystem : IExecuteSystem
    {
        private readonly IInput _input;
        private readonly IGroup<InputEntity> _mouses;

        
        public EmitInputSystem(InputContext inputContext, IInput input)
        {
            _input = input;
            _mouses = inputContext.GetGroup(Mouse);
        }
        
        public void Execute()
        {
            foreach (var mouse in _mouses)
            {
                mouse.isLeftMouse = _input.LeftMouseButton;
            }
        }
    }
}