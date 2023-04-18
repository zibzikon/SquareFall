//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Kernel.Components.ChangedMoveDirection changedMoveDirectionComponent = new Kernel.Components.ChangedMoveDirection();

    public bool isChangedMoveDirection {
        get { return HasComponent(GameComponentsLookup.ChangedMoveDirection); }
        set {
            if (value != isChangedMoveDirection) {
                var index = GameComponentsLookup.ChangedMoveDirection;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : changedMoveDirectionComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherChangedMoveDirection;

    public static Entitas.IMatcher<GameEntity> ChangedMoveDirection {
        get {
            if (_matcherChangedMoveDirection == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ChangedMoveDirection);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherChangedMoveDirection = matcher;
            }

            return _matcherChangedMoveDirection;
        }
    }
}