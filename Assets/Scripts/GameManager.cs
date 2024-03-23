using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject UIGameObject;
    private Snap[] SnapsScripts;
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


        if (numberSnapCurrent == numberSnapTotal)
        {
            endGame();
        }

    }

    public void snapCheck()
    {
        foreach (Snap snap in SnapsScripts)
        {
            if (snap.isSnap)
            {
               
                numberSnapCurrent++;
            }
        }

    }
    public void endGame()
    {
        UIGameObject.SetActive(true);
    }
}
