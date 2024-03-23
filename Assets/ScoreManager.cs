using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro inputScore;
    [SerializeField]
    private InputField inputName;

    public UnityEvent<string, int> submitScoreEvent;
    public void SubmitScore()
    {
        submitScoreEvent.Invoke(inputName.text, int.Parse(inputScore.text));
    }
}
