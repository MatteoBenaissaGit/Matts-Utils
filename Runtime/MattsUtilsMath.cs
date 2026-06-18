using JetBrains.Annotations;

namespace Unity.MattsUtils
{
    public static partial class MattsUtils
    {
        [PublicAPI]
        public static int ToMilliseconds(this float seconds)
        {
            return (int)(seconds * 1000);
        }

        [PublicAPI]
        public static int ToMilliseconds(this int seconds)
        {
            return seconds * 1000;
        }
    }
}