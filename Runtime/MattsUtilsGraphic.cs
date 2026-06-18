using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace Unity.MattsUtils
{
    public static partial class MattsUtils
    {
        [PublicAPI]
        public static Color RandomColor()
        {
            float[] values = new float[3];
            for (int i = 0; i < values.Length; i++)
                values[i] = UnityEngine.Random.Range(0f, 1f);

            return new Color(values[0], values[1], values[2], 1f);
        }
        
        [PublicAPI]
        public static Color SetAlpha(this Color c, float alpha)
        {
            c.a = alpha;
            return c;
        }

        [PublicAPI]
        public static void SetAlpha(this Graphic g, float alpha)
        {
            g.color = g.color.SetAlpha(alpha);
        }

        [PublicAPI]
        public static void SetAlpha(this SpriteRenderer r, float alpha)
        {
            r.color = r.color.SetAlpha(alpha);
        }
    }
}