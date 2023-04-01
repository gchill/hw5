using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneSwitch : MonoBehaviour
{

    public void startgame()
    {
        SceneManager.LoadScene("main");
    }
    public void endgame()
    {
        SceneManager.LoadScene("end");
    }
    public void restart()
    {
        SceneManager.LoadScene("intro");
    }
    public void quit()
    {
        Application.Quit();
    }
}
