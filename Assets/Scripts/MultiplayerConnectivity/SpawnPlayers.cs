using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.VR;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject[] playerPrefab;
    private int selected_avatar;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float minZ;
    public float maxZ;
    void EnterVR() {

            // if (UnityEngine.XR.XRSettings. loadedDeviceName == "cardboard") { 
            //     StartCoroutine (LoadDevice("None")); 
            //  } else{
            StartCoroutine (LoadDevice("cardboard"));
            // }

}
IEnumerator LoadDevice(string newDevice){


    UnityEngine.XR.XRSettings.LoadDeviceByName(newDevice);
     yield return null;
     UnityEngine.XR.XRSettings.enabled = true;

    }
    // Start is called before the first frame update
    void Start()
    {   
        EnterVR();
        selected_avatar=PlayerPrefs.GetInt("selectedCharacter");
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        GameObject player =(GameObject) PhotonNetwork.Instantiate(playerPrefab[selected_avatar].name, randomPosition, Quaternion.identity);
        player.transform.Find("Main Camera").gameObject.SetActive(true);
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
