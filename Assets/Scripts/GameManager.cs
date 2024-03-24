using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject UIGameObject;
    private Snap[] SnapsScripts;
    public LeaderboardManager Leaderboard;
    int numberSnapTotal;
    int numberSnapCurrent;
    bool isAllSnap = false;
    // Start is called before the first frame update
    void Start()
    {
        SnapsScripts = GameObject.FindObjectsOfType<Snap>();
        numberSnapTotal = SnapsScripts.Length;
    }

    // Update is called once per frame
    void Update()
    {
        
        snapCheck();
        if (numberSnapCurrent == numberSnapTotal)
        {
            endGame();
        }

    }

    public void snapCheck()
    {
        numberSnapCurrent = 0;
        foreach (Snap snap in SnapsScripts)
        {
            if (snap.isSnap)
            {
                numberSnapCurrent++;
                Debug.Log(numberSnapCurrent);
            }
            Debug.Log(snap.isSnap);
        }
        Leaderboard.UpdateScore(numberSnapCurrent);
    }
    void endGame()
    {
        UIGameObject.SetActive(true);
        
    }
}
