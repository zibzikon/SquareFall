//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Kernel.Components.SpawnRandom spawnRandomComponent = new Kernel.Components.SpawnRandom();

    public bool isSpawnRandom {
        get { return HasComponent(GameComponentsLookup.SpawnRandom); }
        set {
            if (value != isSpawnRandom) {
                var index = GameComponentsLookup.SpawnRandom;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : spawnRandomComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherSpawnRandom;

    public static Entitas.IMatcher<GameEntity> SpawnRandom {
        get {
            if (_matcherSpawnRandom == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SpawnRandom);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpawnRandom = matcher;
            }

            return _matcherSpawnRandom;
        }
    }
}
