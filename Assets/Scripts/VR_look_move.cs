using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class VR_look_move : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngle = 30.0f;
     public float UIAngle = 330.0f;
//public GameObject position_start,position_stop;
    public float speed = 3.0f;
    public bool moveForward,isunitychan_active;
    public bool UIactive,isuicanvas = false;
    private CharacterController cc;
    public GameObject UI_canvas, UI_mode,body,Head,ch;
    public ParticleSystem myparticle;





    PhotonView view;
    // Use this for initialization
    void Start()
    {   UIactive=false;
            cc = GetComponent<CharacterController>();
        view = GetComponent<PhotonView>();
         UI_mode.SetActive(false);
         isunitychan_active=false;
        
        

    }

    // Update is called once per frame
    void Update()
    {   Vector3 newRot =
            new Vector3(0f, vrCamera.eulerAngles.y, 0f);
            ch.transform.rotation = Quaternion.Euler(newRot);



            Vector3 newRot1 =
           new Vector3(vrCamera.eulerAngles.x, vrCamera.eulerAngles.y, 0f);
           Head.transform.rotation = Quaternion.Euler(newRot1);
        if (view.IsMine)
        {
            body.SetActive(false);
           // body.renderer.enabled = false;


            
            //
            if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f && UIactive==false)
            {
                moveForward = true;
            }
            
            else
            {
                moveForward = false;
            }

            if (moveForward)
            {
                Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

                cc.SimpleMove(forward * speed);
            }
              if (vrCamera.eulerAngles.x >= UIAngle && vrCamera.eulerAngles.x <=341.0f&&isuicanvas==false)
            {
                        UI_mode.SetActive(true);

                }

            else
            {
                 UI_mode.SetActive(false);
            }

            
           
        }
        
    }
    public void EnterUImode(){


        
            
        UI_mode.SetActive(false);
        UI_canvas.SetActive(true);
            isuicanvas=true;
            UIactive = true;
        
        
    }
    
    public void ExitUImode(){

                if(isunitychan_active){
      transform.position=new Vector3(-52.25343f,0.9187032f,19.89802f);
                isunitychan_active=false;
                }
                   isuicanvas=false;

             UI_canvas.SetActive(false);
        UI_mode.SetActive(true);
          
            UIactive = false;
        

    }
      public void EnterUnityChanmode(){
             UIactive = true;
            isunitychan_active=true;  
           
            
            transform.position=new Vector3(-7.503429f,2.388703f,-33.77198f);

    } 
    public void Emoji(){
        myparticle.Play();
    }
      

}
