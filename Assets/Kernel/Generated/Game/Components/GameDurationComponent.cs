//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Kernel.Components.Duration duration { get { return (Kernel.Components.Duration)GetComponent(GameComponentsLookup.Duration); } }
    public bool hasDuration { get { return HasComponent(GameComponentsLookup.Duration); } }

    public void AddDuration(float newValue) {
        var index = GameComponentsLookup.Duration;
        var component = (Kernel.Components.Duration)CreateComponent(index, typeof(Kernel.Components.Duration));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDuration(float newValue) {
        var index = GameComponentsLookup.Duration;
        var component = (Kernel.Components.Duration)CreateComponent(index, typeof(Kernel.Components.Duration));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDuration() {
        RemoveComponent(GameComponentsLookup.Duration);
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

    static Entitas.IMatcher<GameEntity> _matcherDuration;

    public static Entitas.IMatcher<GameEntity> Duration {
        get {
            if (_matcherDuration == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Duration);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDuration = matcher;
            }

            return _matcherDuration;
        }
    }
}
