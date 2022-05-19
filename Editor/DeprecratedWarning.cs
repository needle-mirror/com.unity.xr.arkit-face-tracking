using UnityEngine;

namespace UnityEditor.XR.ARKit
{
    /// <summary>
    /// This class displays a warning that com.unity.xr.arkit-face-tracking is now deprecated.
    /// </summary>
    class DeprecatedWarning
    {
        const string k_Title = "Deprecated: Apple ARKit Face Tracking XR Plug-in Package";
        const string k_Message = "Apple ARKit Face Tracking XR Plug-in package has been deprecated. It is now a part of Apple ARKit XR Plug-in package. If you have an explicit dependency on Apple ARKit Face Tracking XR Plug-in package then replace it with Apple ARKit XR Plug-in package in the manifest.json file.";
        const string k_HideWarningKey = "HideARKitFaceTrackingDeprecatedWarning";

        [InitializeOnLoadMethod]
        static void ShowWarning()
        {
            if (Application.isBatchMode)
            {
                return;
            }

            if (EditorUserSettings.GetConfigValue(k_HideWarningKey)?.Equals("true") ?? false)
            {
                return;
            }

            var hideWarning = !EditorUtility.DisplayDialog(
                k_Title,
                k_Message,
                "Understood",
                "Don't warn me again for this project"
            );
            EditorUserSettings.SetConfigValue(k_HideWarningKey, hideWarning.ToString().ToLower());
        }
    }
}
