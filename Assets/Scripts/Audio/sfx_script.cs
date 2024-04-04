using Meta.Voice.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx_script : MonoBehaviour
{
    public AudioSource AudioPlayer;

     
     public void OnTriggerEnter(Collider collider)
    {
        if(collider .gameObject.tag == "Part")
        {
            AudioPlayer.Play();
        }
       
        
    }
  
}
