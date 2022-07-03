using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_chractermodel : MonoBehaviour
{   public Transform cam;
    

    // Update is called once per frame
    void Update()
    {
       Vector3 newRot = 
       new Vector3 (0f, cam.transform.eulerAngles.y,0f);
       transform.rotation = Quaternion.Euler (newRot);
     
    }
}
