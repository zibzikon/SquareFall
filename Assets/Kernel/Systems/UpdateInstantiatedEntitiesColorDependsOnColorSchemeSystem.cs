using System.Collections.Generic;
using Entitas;
using Kernel.Extensions;
using static GameMatcher;

namespace Kernel.Systems
{
    public class UpdateInstantiatedEntitiesColorDependsOnColorSchemeSystem : ReactiveSystem<GameEntity>
    {
        private readonly GameContext _game;
        
        public UpdateInstantiatedEntitiesColorDependsOnColorSchemeSystem(GameContext game) : base(game)
        {
            _game = game;
        }
        
        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(DependsOnColorScheme.Added());

        protected override bool Filter(GameEntity dependsOnColorScheme)
            => AllOf(ColorType).Matches(dependsOnColorScheme);

        protected override void Execute(List<GameEntity> dependsOnColorSchemeEntities)
        {
            foreach (var dependsOnColorScheme in dependsOnColorSchemeEntities)
            {
                var colorScheme = _game.currentColorScheme.Value;
                var newColor = colorScheme.GetColorByType(dependsOnColorScheme.colorType.Value);

                dependsOnColorScheme.ReplaceColor(newColor);
            }
        }
    }
}