using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{


    public UnityEvent OnTimeStart;
    public UnityEvent OnTimeOut;
    public float startTime;
    public float timerCount;

    public bool isStartTimer = true;
    float currentTime;

    public void StartTimer()
    {

           
        OnTimeStart.Invoke();

        isStartTimer = true;
     
        timerCount = startTime;
        
        
    }

    void Update()
    {
        if (isStartTimer)
        {
            currentTime -= Time.deltaTime;
            isStartTimer=true;
            
        }
    }


    void endGame()
    {

        
        isStartTimer = false;

    }

        private void FixedUpdate()
    {
        if (timerCount > 0 && isStartTimer)
        {
            timerCount -= Time.deltaTime;

            if (timerCount <= 0)
            {
                OnTimeOut.Invoke();
                
            }
        }
    }
}

