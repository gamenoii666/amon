using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class GameController : MonoBehaviour
{

    public QuitGame QuitGame;
    int maxPlatform = 0;

    public void GameOver()
    {
        QuitGame.Setup(maxPlatform);

    }

    private void Awake()
    {
        
    }
}
