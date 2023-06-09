//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Kernel.Components.SpawnPositionRange spawnPositionRange { get { return (Kernel.Components.SpawnPositionRange)GetComponent(GameComponentsLookup.SpawnPositionRange); } }
    public bool hasSpawnPositionRange { get { return HasComponent(GameComponentsLookup.SpawnPositionRange); } }

    public void AddSpawnPositionRange(Kernel.Utils.Vector2Range newValue) {
        var index = GameComponentsLookup.SpawnPositionRange;
        var component = (Kernel.Components.SpawnPositionRange)CreateComponent(index, typeof(Kernel.Components.SpawnPositionRange));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSpawnPositionRange(Kernel.Utils.Vector2Range newValue) {
        var index = GameComponentsLookup.SpawnPositionRange;
        var component = (Kernel.Components.SpawnPositionRange)CreateComponent(index, typeof(Kernel.Components.SpawnPositionRange));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSpawnPositionRange() {
        RemoveComponent(GameComponentsLookup.SpawnPositionRange);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSpawnPositionRange;

    public static Entitas.IMatcher<GameEntity> SpawnPositionRange {
        get {
            if (_matcherSpawnPositionRange == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SpawnPositionRange);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpawnPositionRange = matcher;
            }

            return _matcherSpawnPositionRange;
        }
    }
}
