using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class VR_UI : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngle = -50.0f;
    PhotonView view;
    public bool UIactive;
    
    // Start is called before the first frame update
    void Start()
    {
         view = GetComponent<PhotonView>(); 
    }

    // Update is called once per frame
    void Update()
    {
         if (view.IsMine)
        {
            if (vrCamera.eulerAngles.x <= toggleAngle && vrCamera.eulerAngles.x >-90.0f)
            {
                UIactive = true;
            }
            
            else
            {
                UIactive = false;
            }

            if (UIactive)
            {
                
            }
        }
    }
}
