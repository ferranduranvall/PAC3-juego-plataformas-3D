using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");

    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");

    }

    public void ExitGame()
    {
        Application.Quit();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
