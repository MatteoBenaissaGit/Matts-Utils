using System;
using UnityEngine;

namespace Unity.MattsUtils
{
    public static partial class MattsUtils
    {
        public static void Log(string title, string message, UnityEngine.Object context = null)
        {
            Debug.Log($"[{GetFormattedTimeNow()}] [{title.Bold()}] {message}", context);
        } 
        
        public static void Log(string message, UnityEngine.Object context = null)
        {
            Debug.Log($"[{GetFormattedTimeNow()}] {message}", context);
        }

        private static string GetFormattedTimeNow()
        {
            DateTime now = DateTime.Now;
            return $"{now.Hour}:{now.Minute}:{now.Second}:{now.Millisecond}";
        }
    }
}

