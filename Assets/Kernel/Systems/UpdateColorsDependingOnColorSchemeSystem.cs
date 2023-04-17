using System;
using System.Collections.Generic;
using Entitas;
using Kernel.Gameplay.Color;
using UnityEngine;
using static GameMatcher;
using static Kernel.Gameplay.Color.ColorType;
using ColorType = Kernel.Gameplay.Color.ColorType;

namespace Kernel.Systems
{
    public class UpdateColorsDependingOnColorSchemeSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGroup<GameEntity> _entitiesDependsOnColorScheme;

        
        public UpdateColorsDependingOnColorSchemeSystem(GameContext game) : base(game)
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
                
                var newColor = SelectColorFromConfiguration(configuration, colorType);
                dependsOnColorScheme.ReplaceColor(newColor);
            }
        }

        private Color SelectColorFromConfiguration(ColorSchemeConfiguration configuration, ColorType type)
            => type switch
            {
                Primary => configuration.Primary,
                Secondary => configuration.Secondary,
                Accent => configuration.Accent,
                Neutral => configuration.Neutral,
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
    }
}