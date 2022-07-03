using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GVR_ButtonEvent : MonoBehaviour
{   
    public Image imgcircle;
    public UnityEvent GVRClick;
    public float totaltime=2;
    bool gvrStatus;
    public float gvrTimer;
   
    void Update()
    {
        if(gvrStatus){
            gvrTimer+=Time.deltaTime;
            imgcircle.fillAmount=gvrTimer/totaltime;
        }
        if(gvrTimer>totaltime){
                    
                    GVRClick.Invoke();
                    GVrOff();
            

        }
    }
    public void GVrOn(){
        gvrStatus=true;
    }
    public void GVrOff(){
        gvrStatus=false;
        gvrTimer=0;
        imgcircle.fillAmount=0;
    }
}
