using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartBtn()
    {
        Debug.Log("Game");
        SceneManager.LoadScene("Inventory");
        
    }
    public void HowToPlay()
    {
        Debug.Log("How to Play");
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
