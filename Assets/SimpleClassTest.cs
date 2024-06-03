using UnityEngine;

public class SimpleClassTest : MonoBehaviour
{
    private AndroidJavaObject javaObject;

    public void ShowPopup()
    {
        try
        {
            // Call the Java method to set the current Unity activity
            using (AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                using (AndroidJavaClass pluginClass = new AndroidJavaClass("com.azazellj.unity.stripe.StripeExtKt"))
                {

                    Debug.LogError("player Show Popup ");
                    pluginClass.CallStatic("start", currentActivity);
                }
            }
        }
        catch
            (AndroidJavaException e)
        {
            Debug.LogError("AndroidJavaException: " + e.Message);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Exception: " + e.Message);
        }
    }
}