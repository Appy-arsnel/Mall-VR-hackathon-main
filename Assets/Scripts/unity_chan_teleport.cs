using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class unity_chan_teleport : MonoBehaviour
{
    public Transform position_start,position_stop;
    public GameObject player;


    public void lets_go(){
        player.transform.position=new Vector3(position_start.eulerAngles.x,position_start.eulerAngles.y,position_start.eulerAngles.z);
    }
        public void lets_leave(){
        player.transform.position=new Vector3(position_stop.eulerAngles.x,position_stop.eulerAngles.y,position_stop.eulerAngles.z);
    }
    
}
