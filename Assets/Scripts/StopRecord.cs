using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRecord : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas1;
   
    public void VisibleUI()
    {
        canvas1.transform.localScale = new Vector3(1f, 1f, 1f);
    }

}
