using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeProgressDisplay : MonoBehaviour
{
    public Image progressBar;
    public Timer timer;

    private void FixedUpdate()
    {
        if(timer.timerCount > 0 && timer.isStartTimer)
        {
            progressBar.fillAmount = timer.timerCount * (1 / timer.startTime);
        }
    }
}
