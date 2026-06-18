using UnityEditor;


namespace Unity.MattsUtils.Editor
{
    public class MattsUtilsMenu
    {
        [MenuItem("Tools/Matt's Utils/Log")]
        public static void Log()
        {
            MattsUtils.Log("Matt's Utils", "Thanks for using Matt's Utils!".Color(MattsUtils.RandomColor()));
        }
    }
}