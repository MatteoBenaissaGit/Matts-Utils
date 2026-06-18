using System;
using JetBrains.Annotations;

namespace Unity.MattsUtils
{
    public static partial class MattsUtils
    {
        [PublicAPI]
        public static bool IsValid(this Array array)
        {
            return array != null && array.Length > 0;
        }
    }
}