using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{

    public void Play()
    {
      SceneManager.LoadScene(1);
      AudioListener.pause = false;
    }

    public void Quiting()
    {
      Application.Quit();
      Debug.Log("zort");
    }

    public void Menu()
    {
       SceneManager.LoadScene(0);
       AudioListener.pause = false;
    }

}
