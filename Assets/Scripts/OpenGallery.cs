using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGallery : MonoBehaviour
{
    public void OpenFile()
    {
        if (ScreenShot.imageCurrentPath != "A")
        {
            AndroidContentOpenerWrapper.OpenContent(ScreenShot.imageCurrentPath);
        }
        else {
            OpenG();
        }
        
    }
    public void openFolder()
    {
        string myFolderLocation = "/storage/emulated/0/ARCamera";
        AndroidContentOpenerWrapper.OpenContent(myFolderLocation);

    }

    public void OpenG()
    {
        #region [ Intent intent = new Intent(); ]
        //instantiate the class Intent
        AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
        //instantiate the object Intent
        AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
        #endregion [ Intent intent = new Intent(); ]
        #region [ intent.setAction(Intent.ACTION_VIEW); ]
        //call setAction setting ACTION_SEND as parameter
        intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_VIEW"));
        #endregion [ intent.setAction(Intent.ACTION_VIEW); ]
        #region [ intent.setData(Uri.parse("content://media/internal/images/media")); ]
        //instantiate the class Uri
        AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
        //instantiate the object Uri with the parse of the url's file
        AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", "content://media/internal/images/media");
        //call putExtra with the uri object of the file
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"), uriObject);
        #endregion [ intent.setData(Uri.parse("content://media/internal/images/media")); ]
        //set the type of file
        intentObject.Call<AndroidJavaObject>("setType", "image/png");
        #region [ startActivity(intent); ]
        //instantiate the class UnityPlayer
        AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        //instantiate the object currentActivity
        AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
        //call the activity with our Intent
        currentActivity.Call("startActivity", intentObject);
        #endregion [ startActivity(intent); ]
    }
}
