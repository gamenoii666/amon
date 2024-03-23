using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float timeLeft = 5f;

    Text showTime;

    void Start(){
        showTime = GameObject.Find("/Canvas/txtShowTime").GetComponent<Text>();
    }

    void FixedUpdate(){
        if(timeLeft > 0){
           timeLeft -= Time.deltaTime;
            showTime.text = timeLeft.ToString("###0");
        }
    }   
}
