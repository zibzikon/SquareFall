using System;
using System.Reflection;
using Kernel.Gameplay.Color;
using UnityEngine;
using Object = UnityEngine.Object;
using static Kernel.Gameplay.Color.ColorType;
namespace Kernel.Extensions
{
    public static class CleanCodeExtensions
    {
        public static bool HaveCustomAttribute<T>(this object o)
            => o.GetType().GetCustomAttribute(typeof(T)).Exists();

        public static Color GetColorByType(this ColorSchemeConfiguration colorScheme, ColorType type) 
            => type switch
            {
                Primary => colorScheme.Primary,
                Secondary => colorScheme.Secondary,
                Accent => colorScheme.Accent,
                Neutral => colorScheme.Neutral,
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        
        
        public static string GetTypeName(this Type type) => type.Name;
        
        public static bool Exists(this object o) => o is not null;

        public static bool Exists(this Object o) => o;

        public static bool NotExists(this object o) => !o.Exists();

        public static bool NotExists(this Object o) => !o.Exists();
        
    }
}