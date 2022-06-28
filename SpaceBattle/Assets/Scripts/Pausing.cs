using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausing : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenu ;
    [SerializeField] AudioClip audio;
  
    void Start() 
    {
      Resume();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
          if(GameIsPaused)
          {
          
          Resume();
          }

          else
          {
          
          Pause();
          }
        }
    }

    public void Resume()
    {
       PauseMenu.SetActive(false);
       Time.timeScale = 1;
       GameIsPaused = false;
       AudioListener.pause = false;
       Cursor.visible = false;     
    }

    public void Pause()
    {
     PauseMenu.SetActive(true);
     Time.timeScale = 0.02f;
     GameIsPaused = true;
     AudioListener.pause = true;
     Cursor.visible = true;
    }


}
