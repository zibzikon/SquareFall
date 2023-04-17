using Kernel.Services;
using UnityEngine;

namespace Kernel.Extensions
{
    public static class NumberExtensions
    {
        public static bool InRange(this int value, int min, int max) => value >= min && value <= max;

        public static int InMilliseconds(this float value) => (value * 1000).RoundToInt();
        
        public static bool InRange(this float value, float min, float max) => value >= min && value <= max;
        public static bool InRange(this float value, RangeFloat range) => value.InRange(range.start, range.end);
        
        public static float Clamp(this float value, float min, float max) => Mathf.Clamp(value, min, max);
        public static float Clamp(this float value, RangeFloat range) => value.Clamp(range.start, range.end);

        public static float Round(this float value) => Mathf.Round(value);
        public static int RoundToInt(this float value) => Mathf.RoundToInt(value);
        
        public static Vector3 AsVector3(this float value) => new(value, value, value);
        public static Vector3 AsVector2(this float value) => new Vector2(value, value);
        public static Vector3 AsYVector3(this float value) => value.AsYVector2();
        public static Vector3 AsXVector3(this float value) => value.AsXVector2();
        public static Vector3 AsZVector3(this float value) => new(0, 0, value);
        public static Vector2 AsYVector2(this float value) => new(0, value);
        public static Vector2 AsXVector2(this float value) => new(value, 0);

    }
}