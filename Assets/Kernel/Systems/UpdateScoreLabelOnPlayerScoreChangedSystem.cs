using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Kernel.Systems
{
    public class UpdateScoreLabelOnPlayerScoreChangedSystem : ReactiveSystem<GameEntity>
    {
        private readonly IMediator _mediator;

        public UpdateScoreLabelOnPlayerScoreChangedSystem(GameContext context, IMediator mediator) : base(context)
        {
            _mediator = mediator;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(Score);

        protected override bool Filter(GameEntity player)
            => AllOf(Player).Matches(player);

        protected override void Execute(List<GameEntity> players)
        {
            foreach (var player in players)
            {
                _mediator.SetScore(player.score.Value);
            }
        }
    }
}