using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx_script : MonoBehaviour
{
    public AudioClip AudioClip;
     void OnTriggerStay(Collider Audio)
    {
        AudioSource.PlayClipAtPoint(AudioClip,transform.position);
    }
}
