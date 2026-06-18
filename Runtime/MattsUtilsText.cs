using JetBrains.Annotations;
using UnityEngine;

namespace Unity.MattsUtils
{
    public static partial class MattsUtils
    {
        [PublicAPI]
        public static string Bold(this string message)
        {
            return $"<b>{message}</b>";
        }
        
        [PublicAPI]
        public static string Italic(this string message)
        {
            return $"<i>{message}</i>";
        }
        
        [PublicAPI]
        public static string Color(this string text, Color color)
        {
            string hex = ColorUtility.ToHtmlStringRGB(color);
            return $"<color=#{hex}> {text} </color>";
        }
    }
}