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

    public void QuitGame()
    {
        Application.Quit();
    }
}
