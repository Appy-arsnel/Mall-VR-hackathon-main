using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle_start : MonoBehaviour
{   ParticleSystem myp;
    // Start is called before the first frame update
    
    void Start()
    {
        myp= GetComponent<ParticleSystem>();
        myp.Play();
    }

   
}
