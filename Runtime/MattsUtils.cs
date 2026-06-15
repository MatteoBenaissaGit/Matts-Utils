using System;
using UnityEngine;

namespace Unity.MattsUtils
{
    public static class MattsUtils
    {
        #region Logging

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

        #endregion

        #region Text

        public static string Bold(this string message)
        {
            return $"<b>{message}</b>";
        }
        
        public static string Italic(this string message)
        {
            return $"<i>{message}</i>";
        }

        #endregion
    }
}

