//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Kernel.Components.DependsOnColorScheme dependsOnColorSchemeComponent = new Kernel.Components.DependsOnColorScheme();

    public bool isDependsOnColorScheme {
        get { return HasComponent(GameComponentsLookup.DependsOnColorScheme); }
        set {
            if (value != isDependsOnColorScheme) {
                var index = GameComponentsLookup.DependsOnColorScheme;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : dependsOnColorSchemeComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherDependsOnColorScheme;

    public static Entitas.IMatcher<GameEntity> DependsOnColorScheme {
        get {
            if (_matcherDependsOnColorScheme == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DependsOnColorScheme);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDependsOnColorScheme = matcher;
            }

            return _matcherDependsOnColorScheme;
        }
    }
}
