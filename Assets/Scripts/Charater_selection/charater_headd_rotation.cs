using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charater_headd_rotation : MonoBehaviour
{
    public Transform cam;
    // Update is called once per frame
    void Update()
    {
        Vector3 newRot = 
       new Vector3 (cam.transform.eulerAngles.x,cam.transform.eulerAngles.y,0f);
       transform.rotation = Quaternion.Euler (newRot);
    }
}
