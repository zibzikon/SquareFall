//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Kernel.Components.SpawnInterval spawnInterval { get { return (Kernel.Components.SpawnInterval)GetComponent(GameComponentsLookup.SpawnInterval); } }
    public bool hasSpawnInterval { get { return HasComponent(GameComponentsLookup.SpawnInterval); } }

    public void AddSpawnInterval(float newValue) {
        var index = GameComponentsLookup.SpawnInterval;
        var component = (Kernel.Components.SpawnInterval)CreateComponent(index, typeof(Kernel.Components.SpawnInterval));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSpawnInterval(float newValue) {
        var index = GameComponentsLookup.SpawnInterval;
        var component = (Kernel.Components.SpawnInterval)CreateComponent(index, typeof(Kernel.Components.SpawnInterval));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSpawnInterval() {
        RemoveComponent(GameComponentsLookup.SpawnInterval);
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

    static Entitas.IMatcher<GameEntity> _matcherSpawnInterval;

    public static Entitas.IMatcher<GameEntity> SpawnInterval {
        get {
            if (_matcherSpawnInterval == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SpawnInterval);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpawnInterval = matcher;
            }

            return _matcherSpawnInterval;
        }
    }
}
