//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ColorListenerComponent colorListener { get { return (ColorListenerComponent)GetComponent(GameComponentsLookup.ColorListener); } }
    public bool hasColorListener { get { return HasComponent(GameComponentsLookup.ColorListener); } }

    public void AddColorListener(System.Collections.Generic.List<IColorListener> newValue) {
        var index = GameComponentsLookup.ColorListener;
        var component = (ColorListenerComponent)CreateComponent(index, typeof(ColorListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceColorListener(System.Collections.Generic.List<IColorListener> newValue) {
        var index = GameComponentsLookup.ColorListener;
        var component = (ColorListenerComponent)CreateComponent(index, typeof(ColorListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveColorListener() {
        RemoveComponent(GameComponentsLookup.ColorListener);
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

    static Entitas.IMatcher<GameEntity> _matcherColorListener;

    public static Entitas.IMatcher<GameEntity> ColorListener {
        get {
            if (_matcherColorListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ColorListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherColorListener = matcher;
            }

            return _matcherColorListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddColorListener(IColorListener value) {
        var listeners = hasColorListener
            ? colorListener.value
            : new System.Collections.Generic.List<IColorListener>();
        listeners.Add(value);
        ReplaceColorListener(listeners);
    }

    public void RemoveColorListener(IColorListener value, bool removeComponentWhenEmpty = true) {
        var listeners = colorListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveColorListener();
        } else {
            ReplaceColorListener(listeners);
        }
    }
}
