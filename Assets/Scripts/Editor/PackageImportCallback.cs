using UnityEditor;
using UnityEngine;

public class PackageImportCallback : AssetPostprocessor
{
    static void OnPostprocessAllAssets(
        string[] importedAssets,
        string[] deletedAssets,
        string[] movedAssets,
        string[] movedFromAssetPaths)
    {
        foreach (string asset in importedAssets)
        {
            if (asset.EndsWith(".unitypackage"))
            {
                // Your callback code here
                OnPackageImported(asset);
            }
        }
    }

    private static void OnPackageImported(string packageName)
    {
        // Your logic here
        Debug.LogWarning("Package imported: " + packageName);
        // You can add additional code to handle the package import completion
    }
}