using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public Text pointText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointText.text = score.ToString() + "POINTS";
    }

    public void Restart()
    {
        Debug.Log("Game");
        SceneManager.LoadScene("MainGame");

    }

    public void QUITGAME()
    {
        Debug.Log("Game");
        SceneManager.LoadScene("Inventory");

    }
   
}
