using System;
using System.Collections.Generic;
using Entitas;
using Kernel.Extensions;
using Kernel.Gameplay.Color;
using UnityEngine;
using static GameMatcher;
using static Kernel.Gameplay.Color.ColorType;
using ColorType = Kernel.Gameplay.Color.ColorType;

namespace Kernel.Systems
{
    public class UpdateColorsDependingOnColorSchemeChangedSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGroup<GameEntity> _entitiesDependsOnColorScheme;

        
        public UpdateColorsDependingOnColorSchemeChangedSystem(GameContext game) : base(game)
        {
            _entitiesDependsOnColorScheme = game.GetGroup(AllOf(DependsOnColorScheme, GameMatcher.ColorType));
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(CurrentColorScheme);

        protected override bool Filter(GameEntity colorScheme)
            => true;

        protected override void Execute(List<GameEntity> colorSchemes)
        {
            foreach (var colorScheme in colorSchemes)
            foreach (var dependsOnColorScheme in _entitiesDependsOnColorScheme)
            {
                var configuration = colorScheme.currentColorScheme.Value;
                var colorType = dependsOnColorScheme.colorType.Value;
                
                var newColor = configuration.GetColorByType(colorType);
                dependsOnColorScheme.ReplaceColor(newColor);
            }
        }
        
    }
}