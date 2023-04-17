using System.Collections;
using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using Kernel.Gameplay.Color;
using Kernel.Gameplay.FallingSquaresSpawner;
using Kernel.Services;
using Kernel.Utils;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.EventTarget;
namespace Kernel.Components
{
    // @formatter:off
    
    public class Id : IComponent { [PrimaryEntityIndex] public int Value; } 
    
    [Configuration, Unique] public class GameConfiguration : IComponent {} 
    [Configuration] public class FallingSquaresSpawnerConfigurationComponent : IComponent { public FallingSquaresSpawnerConfiguration Value; } 
    
    [Game, Unique] public class GameState : IComponent { }
    [Game] public class Playing : IComponent { }
    
    [Game] public class ColorSchemeButton : IComponent { } 
    
    [Game] public class FallingSquaresSpawner : IComponent { } 
    [Game] public class FallingSquare : IComponent { } 
    [Game] public class MovingCircle : IComponent { }
    [Game] public class Player : IComponent { }
    
    [Game] public class Collisionable : IComponent { }
    [Game] public class Collectable : IComponent { }
    [Game] public class Movable : IComponent { }
    [Game] public class Killed : IComponent { }
    [Game] public class Destructed : IComponent { }
    [Game] public class DependsOnColorScheme : IComponent { }
    
    [Game] public class InvertMoveDirection : IComponent { }
    [Game] public class SpawnRandom : IComponent { }
    [Game] public class DurationUp : IComponent { } 

    [Game, Unique] public class CurrentColorScheme : IComponent { public ColorSchemeConfiguration Value; } 
    
    [Game] public class Score : IComponent { public int Value; } 
    
    [Game] public class ColorTypeComponent : IComponent { public ColorType Value; } 
    [Game] public class Duration : IComponent { public float Value; } 
    [Game] public class DurationLeft : IComponent { public float Value; } 
    [Game] public class SpawnedEntitySpeed : IComponent { public float Value; } 
    [Game] public class MovingSpeed : IComponent { public float Value; } 
    [Game] public class CollectableSquareSpawningChance : IComponent { public float Value; } 
    [Game] public class SpawnInterval : IComponent { public float Value; } 
    [Game] public class CollidedEntityId : IComponent { public int Value; } 
    [Game] public class MoveDirection : IComponent { public Vector2 Value; } 
    [Game] public class HorizontalBorder : IComponent { public RangeFloat Value; } 
    [Game] public class SpawnPositionRange : IComponent { public Vector2Range Value; } 
    
    [Input, Unique] public class Mouse : IComponent { }
    [Input] public class LeftMouse : IComponent { }
    
    [Game, Event(Self)] public class ColorComponent : IComponent { public Color Value; } 
    [Game, Event(Self)] public class Position : IComponent { public Vector3 Value; }
    [Game, Event(Self)] public class Rotation : IComponent { public Vector3 Value; }
}
