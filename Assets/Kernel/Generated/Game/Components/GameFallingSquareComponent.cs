//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Kernel.Components.FallingSquare fallingSquareComponent = new Kernel.Components.FallingSquare();

    public bool isFallingSquare {
        get { return HasComponent(GameComponentsLookup.FallingSquare); }
        set {
            if (value != isFallingSquare) {
                var index = GameComponentsLookup.FallingSquare;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : fallingSquareComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherFallingSquare;

    public static Entitas.IMatcher<GameEntity> FallingSquare {
        get {
            if (_matcherFallingSquare == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.FallingSquare);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherFallingSquare = matcher;
            }

            return _matcherFallingSquare;
        }
    }
}
