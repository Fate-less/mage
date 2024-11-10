using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuButton : MonoBehaviour
{
    public void MainmenuStart()
    {
        SceneManager.LoadScene("Classroom");
    }
    public void MainmenuExit()
    {
        Application.Quit();
    }
}
