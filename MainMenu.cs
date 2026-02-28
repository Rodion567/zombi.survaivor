using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Loadmeinscene()
    {
        SceneManager.LoadScene("meinscene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

