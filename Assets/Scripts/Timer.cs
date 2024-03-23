using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public UnityEvent OnTimeStart;
    public UnityEvent OnTimeOut;
    public float startTime;
    public float timerCount;

    public bool isStartTimer = false;


    public void StartTimer()
    {
        OnTimeStart.Invoke();

        isStartTimer = true;
        timerCount = startTime;
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

