using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimationScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    void Start()
    {
        if (canvas != null)
        {
            canvas.SetActive(false);
        }
    }
    public void OpenCanvas()
    {
        if(canvas != null)
        {
            bool isActive = canvas.activeSelf;
            canvas.SetActive(!isActive);
        }
    }
    

}
