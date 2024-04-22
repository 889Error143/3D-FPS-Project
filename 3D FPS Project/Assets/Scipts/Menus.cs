using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{

    public int levelOne;



    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene(levelOne);
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }
}